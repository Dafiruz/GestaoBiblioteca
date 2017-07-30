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
    public partial class frmRegistar : Form
    {
        string Username, PalavraPasse;
        int numVerific;
        public frmRegistar(string RegUsername, string RegPalpasse, int num)
        {
            InitializeComponent();

            Username = RegUsername;
            PalavraPasse = RegPalpasse;
            numVerific = num;
        }

        private void picImagem_Click(object sender, EventArgs e)
        {
            if (this.Width == 843)
            {
                this.Width = 426;
                this.Height = 294;
            }
            else
            {
                this.Width = 843;
                this.Height = 294;
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if (pic1.Tag == pic11.Tag)
            {
                pic1.Image = Properties.Resources._2;
                pic2.Image = Properties.Resources._3;
                pic3.Image = Properties.Resources._4;
                pic1.Tag = "2";

            }
            else if (pic1.Tag == pic22.Tag)
            {
                pic1.Image = Properties.Resources._3;
                pic2.Image = Properties.Resources._4;
                pic3.Image = Properties.Resources._5;
                pic1.Tag = "3";
            }
            else if (pic1.Tag == pic33.Tag)
            {
                pic1.Image = Properties.Resources._4;
                pic2.Image = Properties.Resources._5;
                pic3.Image = Properties.Resources._6;
                pic1.Tag = "4";
            }
        }

        private void picPrev_Click(object sender, EventArgs e)
        {
            if (pic1.Tag == pic44.Tag)
            {
                pic1.Image = Properties.Resources._3;
                pic2.Image = Properties.Resources._4;
                pic3.Image = Properties.Resources._5;
                pic1.Tag = "3";
            }
            else if (pic1.Tag == pic33.Tag)
            {
                pic1.Image = Properties.Resources._2;
                pic2.Image = Properties.Resources._3;
                pic3.Image = Properties.Resources._4;
                pic1.Tag = "2";
            }
            else if (pic1.Tag == pic22.Tag)
            {
                pic1.Image = Properties.Resources._1;
                pic2.Image = Properties.Resources._2;
                pic3.Image = Properties.Resources._3;
                pic1.Tag = "1";

            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            picImagem.Image = pic1.Image;

            if (pic1.Tag == pic11.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\1.jpg";
            }
            else if (pic1.Tag == pic22.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\2.jpg";
            }
            else if (pic1.Tag == pic33.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\3.jpg";
            }
            else if (pic1.Tag == pic44.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\4.jpg";
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            picImagem.Image = pic2.Image;

            if (pic1.Tag == pic11.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\2.jpg";
            }
            else if (pic1.Tag == pic22.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\3.jpg";
            }
            else if (pic1.Tag == pic33.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\4.jpg";
            }
            else if (pic1.Tag == pic44.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\5.jpg";
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            picImagem.Image = pic3.Image;

            if (pic1.Tag == pic11.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\3.jpg";
            }
            else if (pic1.Tag == pic22.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\4.jpg";
            }
            else if (pic1.Tag == pic33.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\5.jpg";
            }
            else if (pic1.Tag == pic44.Tag)
            {
                imagemPerfilTextBox.Text = @"ImagemPerfil\6.jpg";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem a certexa que quer sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void leitorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leitorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoBibliotecaDataSet);

        }

        private void frmRegistar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestaoBibliotecaDataSet.Leitor' table. You can move, or remove it, as needed.
            this.leitorTableAdapter.Fill(this.gestaoBibliotecaDataSet.Leitor);
            if (numVerific==1)
            {
                leitorBindingSource.AddNew();
                usernameTextBox.Text = Username;
                palavraPasseTextBox.Text = PalavraPasse;
            }
            else
            {
                leitorBindingSource.Filter = "Username = '" + Username + "'";
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            Validate();
            leitorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(gestaoBibliotecaDataSet);
            this.Close();
            frmSugestoes formSugestoes = new frmSugestoes(usernameTextBox.Text);
            formSugestoes.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
