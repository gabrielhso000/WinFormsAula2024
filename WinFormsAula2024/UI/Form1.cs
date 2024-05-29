using System.Windows.Forms;
using WinFormsAula2024.BLL;
using WinFormsAula2024.DTO;

namespace WinFormsAula2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNome.Text) && !lstNomes.Items.Contains(txtNome.Text) && !lstNomes.Items.Contains(txtEmail.Text) && !lstNomes.Items.Contains(txtTelefone.Text))
            {
                var nomeRecebido = txtNome.Text.Trim();
                var emailRecebido = txtEmail.Text.Trim();
                var telefoneRecebido = txtTelefone.Text.Trim();

                NomesDTO objetoNomes = new NomesDTO()
                {
                    Nome = nomeRecebido,
                    Email = emailRecebido,
                    Telefone = telefoneRecebido,
                };

                NomesBLL nomesBLL = new NomesBLL();
                int retorno = nomesBLL.CadastrarDados(objetoNomes);

                if(retorno == 0)
                {
                    MessageBox.Show("Nome não cadastrado!");

                } else if(retorno == 1)
                {
                    lstNomes.Items.Add(nomeRecebido);
                    lstNomes.Items.Add(emailRecebido);
                    lstNomes.Items.Add(telefoneRecebido);
                }                
                txtNome.Text = "";
            }
        }

        private void btnExcluirNome_Click(object sender, EventArgs e)
        {
            for (int i = lstNomes.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstNomes.SelectedIndices[i];
                lstNomes.Items.RemoveAt(index);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
