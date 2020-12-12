using AnaliseBacklog.App.Views;
using AnaliseBacklog.Data.ExcelServices;
using AnaliseBacklog.Domain.Interfaces.ExcelServices;
using AnaliseBacklog.Domain.Interfaces.Services;
using AnaliseBacklog.Domain.Services;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace AnaliseBacklog.App
{
    static class Program
    {
        private static Container _container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(_container.GetInstance<Principal>());
        }

        private static void Bootstrap()
        {
            _container = new Container();

            // Domain
            _container.Register<IBacklogTrackingService, BacklogTrackingService>(Lifestyle.Singleton);
            _container.Register<IResultadoBaseBacklogService, ResultadoBaseBacklogService>(Lifestyle.Singleton);
            _container.Register<IProcessoService, ProcessoService>(Lifestyle.Singleton);

            // ExcelService
            _container.Register<IBacklogExcelService, BacklogExcelService>(Lifestyle.Singleton);
            _container.Register<ITrackingExcelService, TrackingExcelService>(Lifestyle.Singleton);
            _container.Register<IBaseBacklogExcelService, BaseBacklogExcelService>(Lifestyle.Singleton);

            // Form
            _container.Register<Principal>(Lifestyle.Singleton);

            _container.Verify();
        }
    }
}
