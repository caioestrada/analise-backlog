using AnaliseBacklog.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace AnaliseBacklog.App.Views
{
    public partial class Principal : Form
    {
        private readonly IProcessoService _processoService;

        public Principal(IProcessoService processoService)
        {
            _processoService = processoService;

            InitializeComponent();
        }

        private void btnBackLog_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResultBacklog = this.openFileBacklog.ShowDialog();
                if (dialogResultBacklog == DialogResult.OK)
                    this.txtBacklog.Text = this.openFileBacklog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Análise Backlog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResultTracking = this.openFileTracking.ShowDialog();
                if (dialogResultTracking == DialogResult.OK)
                    this.txtTracking.Text = this.openFileTracking.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Análise Backlog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResultBase = this.openFileBase.ShowDialog();
                if (dialogResultBase == DialogResult.OK)
                    this.txtBase.Text = this.openFileBase.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Análise Backlog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Necessário informar as três planilhas!", "Análise Backlog", MessageBoxButtons.OK);
                    return;
                }

                var resultado = _processoService.UnificarDados(txtBacklog.Text, txtTracking.Text, txtBase.Text);
                MessageBox.Show(resultado, "Análise Backlog", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Análise Backlog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrEmpty(txtBacklog.Text) 
                    && !string.IsNullOrEmpty(txtTracking.Text) 
                    && !string.IsNullOrEmpty(txtBase.Text);
        }
    }
}
