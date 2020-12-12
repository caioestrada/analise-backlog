using AnaliseBacklog.Domain.Interfaces.ExcelServices;
using AnaliseBacklog.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace AnaliseBacklog.Domain.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IBacklogExcelService _backlogExcelService;
        private readonly ITrackingExcelService _trackingExcelService;
        private readonly IBaseBacklogExcelService _baseBacklogExcelService;
        private readonly IBacklogTrackingService _backlogTrackingService;
        private readonly IResultadoBaseBacklogService _resultadoBaseBacklogService;

        public ProcessoService(IBacklogExcelService backlogExcelService, ITrackingExcelService trackingExcelService,
            IBaseBacklogExcelService baseBacklogExcelService, IBacklogTrackingService backlogTrackingService,
            IResultadoBaseBacklogService resultadoBaseBacklogService)
        {
            _backlogExcelService = backlogExcelService;
            _trackingExcelService = trackingExcelService;
            _baseBacklogExcelService = baseBacklogExcelService;
            _backlogTrackingService = backlogTrackingService;
            _resultadoBaseBacklogService = resultadoBaseBacklogService;
        }

        public string UnificarDados(string caminhoDaPlanilhaBacklog, string caminhoDaPlanilhaTracking, string caminhoDaPlanilhaBase)
        {
            try
            {
                var backlog = _backlogExcelService.ObterTodos(caminhoDaPlanilhaBacklog);
                if (!backlog.Any())
                    return "Erro ao ler a planilha de backlog ou esta vazia!";

                var tracking = _trackingExcelService.ObterTodos(caminhoDaPlanilhaTracking);
                if (!tracking.Any())
                    return "Erro ao ler a planilha de tracking ou esta vazia!";

                var baseBacklog = _baseBacklogExcelService.ObterTodos(caminhoDaPlanilhaBase);
                if (!baseBacklog.Any())
                    return "Erro ao ler a planilha de base backlog ou esta vazia!";

                var resultado = _backlogTrackingService.Unificar(backlog, tracking);
                var resultadoComBaseBacklog = _resultadoBaseBacklogService.Unificar(resultado, baseBacklog);

                if (!_baseBacklogExcelService.GerarPlanilhaComResultado(resultadoComBaseBacklog))
                    return "Não foi possível gerar a planilha final, revise as planilhas e tente novamente!";

                return "Planilha gerada com sucesso!";
            }
            catch (Exception)
            {
                return "Não foi possível gerar a planilha final, revise as planilhas e tente novamente!";
            }
        }
    }
}
