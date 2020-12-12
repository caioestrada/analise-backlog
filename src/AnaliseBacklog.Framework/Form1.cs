using System;
using System.Windows.Forms;

namespace AnaliseBacklog.Framework
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
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
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                var caminhoDaPlanilhaDeBacklog = this.txtBacklog.Text;
                var caminhoDaPlanilhaDeTracking = this.txtTracking.Text;
                var caminhoDaPlanilhaDeBase = this.txtBase.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
