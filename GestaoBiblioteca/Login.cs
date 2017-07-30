using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestaoBiblioteca
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestaoBibliotecaDataSet.Leitor' table. You can move, or remove it, as needed.
            this.leitorTableAdapter.Fill(this.gestaoBibliotecaDataSet.Leitor);
        }

        void VerfTextBox()
        {
            lblRepPalPasse.Visible = false;
            txtRepPalPasse.Visible = false;
            btnContinuar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void picEntrar_Click(object sender, EventArgs e)
        {
            //Verifica se as TextBox estão visiveis
            VerfTextBox();

            //Verificação se as TextBox's estão preenchidas
            if (txtUsername.Text != "" && txtPalPasse.Text != "")
            {
                //Verifica se o Username existe
                leitorBindingSource.Filter = " Username = '" + txtUsername.Text + "'";
                if (leitorBindingSource.Position != -1)
                {
                    leitorBindingSource.Filter = " PalavraPasse = '" + txtPalPasse.Text + "'";
                    if (leitorBindingSource.Position != -1)
                    {
                        frmSugestoes Entrar = new frmSugestoes(txtUsername.Text);
                        Entrar.ShowDialog();
                    }
                    else
                        MessageBox.Show("Nao existe palavra passe");
                }
                else
                    MessageBox.Show("Nao existe nome");
            }
        }

        private void picRegistar_Click(object sender, EventArgs e)
        {
            //Torna as TextBox's necessarias para registar visiveis
            lblRepPalPasse.Visible = true;
            txtRepPalPasse.Visible = true;
            btnContinuar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Verificação se as TextBox's estão preenchidas
            if (txtUsername.Text != "" && txtPalPasse.Text != "" && txtRepPalPasse.Text != "")
            {
                //Verificação se as Palavras-Passe são iguas
                if (txtPalPasse.Text == txtRepPalPasse.Text)
                {
                    //Verificação se o Username existe
                    leitorBindingSource.Filter = " Username = '" + txtUsername.Text + "'";
                    if (leitorBindingSource.Position == -1)
                    {
                        frmRegistar NovoRegisto = new frmRegistar(txtUsername.Text, txtPalPasse.Text,1);
                        NovoRegisto.ShowDialog();
                    }
                    else
                        MessageBox.Show("Esse utilizador já existe");
                }
                else
                    MessageBox.Show("As Palavras Passe são diferentes");
            }
            else
                MessageBox.Show("É preciso preencher todos os campos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Verifica se as TextBox estão visiveis
            VerfTextBox();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem a certeza que quer fechar!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
                Application.Exit();
        }
    }
}
