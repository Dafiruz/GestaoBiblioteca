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
    public partial class frmSugestoes : Form
    {
        string Username;
        public frmSugestoes(string user)
        {
            InitializeComponent();
            Username = user;
        }

        private void tmrDescricao_Tick(object sender, EventArgs e)
        {
            panLivroClick.Left -= 5;
            if (panLivroClick.Left < 340)
                tmrDescricao.Stop();
        }

        private void frmSugestoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestaoBibliotecaDataSet.Leitor' table. You can move, or remove it, as needed.
            this.leitorTableAdapter.Fill(this.gestaoBibliotecaDataSet.Leitor);
            // TODO: This line of code loads data into the 'gestaoBibliotecaDataSet.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter.Fill(this.gestaoBibliotecaDataSet.Livro);

            //Preenchimento do Menu
            //Menu();
            //Preenchimento das PictureBox's com os livros sugeridos
            LivSugeridos();
        }

        void Menu()
        {
            //Preenchimento dos dados do utilizador no menu
            leitorBindingSource.Filter = "Nome = '" + Username + "'";
            lblUsername.Text = usernameTextBox.Text;
            picImagem.Image = Image.FromFile(imagemPerfilTextBox.Text);
        }

        void LivSugeridos()
        {
            #region Cria as PictureBox's
            PictureBox[,] picCapaLiv = new PictureBox[3, 6];
            int x = 8, y = 106, c = 0;
            for (int lin = 0; lin < picCapaLiv.GetLength(0); lin++)
            {
                for (int col = 0; col < picCapaLiv.GetLength(1); col++)
                {
                    picCapaLiv[lin, col] = new PictureBox();
                    this.Controls.Add(picCapaLiv[lin, col]);
                    picCapaLiv[lin, col].Size = new Size(101, 128);
                    picCapaLiv[lin, col].BackColor = Color.Black;
                    picCapaLiv[lin, col].Location = new Point(x, y);
                    picCapaLiv[lin, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    picCapaLiv[lin, col].Click += new EventHandler(picCapaLiv_Click);
                    x += 119;
                    c++;
                }
                y += 144;
                x = 8;
            }
            #endregion

            //Preenchimento das PictureBox's
            int max = livroBindingSource.Count;
            int [] NR = new int[18];
            Random NumAl = new Random();
            //int n = NumAl.Next(0, max);
            //MessageBox.Show(n.ToString());
            //NR[0] = n;
            for (int lin = 0; lin < picCapaLiv.GetLength(0); lin++)
            {
                for (int col = 0; col < picCapaLiv.GetLength(1); col++)
                {
                    livroBindingSource.RemoveFilter();
                    //n = NumAl.Next(0, max);
                    livroBindingSource.Filter = "CodLivro = " + 1.ToString();
                    picCapaLiv[lin, col].Image = Image.FromFile(capaTextBox.Text);
                    picCapaLiv[lin, col].Tag = capaTextBox.Text;
                }
            }

        }

        private void picCapaLiv_Click(object sender, EventArgs e)
        {
            //Esconde o Painel de Descrição do Livro escolhido
            panLivroClick.Location = new Point(718, 82);
            //Mostra o Painel de Descrição do Livro escolhido
            tmrDescricao.Start();

            //Verifica qual das PictureBox's foi carregada
            PictureBox PicSugerida = (PictureBox)sender;
            livroBindingSource.RemoveFilter();
            livroBindingSource.Filter = "Capa = '" + PicSugerida.Tag + "'";
            
            #region Mostra os dados do livro
            lblTitulo.Text = tituloTextBox.Text;
            lblAutor.Text = autorTextBox.Text;
            lblEditora.Text = "Editora: " + editoraTextBox.Text;
            lblCategoria.Text = "Categoria: " + categoriaTextBox.Text;
            lblNumPag.Text = "Nº Páginas: " + numPaginasTextBox.Text;
            lblDescricao.Text = descricaoTextBox.Text;
            picCapaLivSug.Image = Image.FromFile(capaTextBox.Text);
            #endregion
        }

        private void picFecharDesc_Click(object sender, EventArgs e)
        {
            //Esconde o Painel de Descrição do Livro escolhido
            panLivroClick.Location = new Point(718, 82);
            livroBindingSource.RemoveFilter();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmRegistar Registar = new frmRegistar(lblUsername.Text, null, 0);
            Registar.ShowDialog();
        }
    }
}
