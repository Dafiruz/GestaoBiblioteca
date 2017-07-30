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
    public partial class frmPlanta : Form
    {
        public frmPlanta()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
           picZoom.Image = Properties.Resources.planta1;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
           picZoom.Image = Properties.Resources.planta2;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta3;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta4;
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta5;
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta6;
        }

        private void pic7_Click(object sender, EventArgs e)
        {
           picZoom.Image = Properties.Resources.planta7;
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta8;
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            picZoom.Image = Properties.Resources.planta9;
        }

        private void Planta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestaoBibliotecaDataSet.Leitor' table. You can move, or remove it, as needed.
            this.leitorTableAdapter.Fill(this.gestaoBibliotecaDataSet.Leitor);
            //controls.add();
            picPlanta.Image = Properties.Resources.planta_Projecto;
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {
            frmRegistar formRegistar = new frmRegistar(lblUsername.Text, null, 0);
            formRegistar.ShowDialog();
        }

        private void picSuges_Click(object sender, EventArgs e)
        {
            frmSugestoes formSugestoes = new frmSugestoes(null);
            formSugestoes.Show();
        }

        private void tmrUser_Tick(object sender, EventArgs e)
        {
            // picPerfil.Image = Image.FromFile(imagemPerfilTextBox.Text);
        }

        private void leitorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leitorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoBibliotecaDataSet);

        }
    }
}
