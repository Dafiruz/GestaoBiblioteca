namespace GestaoBiblioteca
{
    partial class frmSugestoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codLivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label numPaginasLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label capaLabel;
            System.Windows.Forms.Label imagemPerfilLabel;
            System.Windows.Forms.Label usernameLabel;
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.lblEdidarPerfil = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panLivroClick = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDescLiv = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNumPag = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFecharDesc = new System.Windows.Forms.PictureBox();
            this.picCapaLivSug = new System.Windows.Forms.PictureBox();
            this.tmrDescricao = new System.Windows.Forms.Timer(this.components);
            this.gestaoBibliotecaDataSet = new GestaoBiblioteca.GestaoBibliotecaDataSet();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.LivroTableAdapter();
            this.tableAdapterManager = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager();
            this.codLivroTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.numPaginasTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.leitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leitorTableAdapter = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter();
            this.imagemPerfilTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            codLivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            numPaginasLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            imagemPerfilLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.panLivroClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFecharDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapaLivSug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codLivroLabel
            // 
            codLivroLabel.AutoSize = true;
            codLivroLabel.Location = new System.Drawing.Point(1123, 100);
            codLivroLabel.Name = "codLivroLabel";
            codLivroLabel.Size = new System.Drawing.Size(55, 13);
            codLivroLabel.TabIndex = 74;
            codLivroLabel.Text = "Cod Livro:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(1123, 126);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 76;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(1123, 152);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 78;
            autorLabel.Text = "Autor:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(1123, 178);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(43, 13);
            editoraLabel.TabIndex = 80;
            editoraLabel.Text = "Editora:";
            // 
            // numPaginasLabel
            // 
            numPaginasLabel.AutoSize = true;
            numPaginasLabel.Location = new System.Drawing.Point(1123, 204);
            numPaginasLabel.Name = "numPaginasLabel";
            numPaginasLabel.Size = new System.Drawing.Size(73, 13);
            numPaginasLabel.TabIndex = 82;
            numPaginasLabel.Text = "Num Paginas:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(1123, 230);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 84;
            categoriaLabel.Text = "Categoria:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(1123, 256);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 86;
            descricaoLabel.Text = "Descricao:";
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Location = new System.Drawing.Point(1123, 282);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(35, 13);
            capaLabel.TabIndex = 88;
            capaLabel.Text = "Capa:";
            // 
            // imagemPerfilLabel
            // 
            imagemPerfilLabel.AutoSize = true;
            imagemPerfilLabel.Location = new System.Drawing.Point(1123, 356);
            imagemPerfilLabel.Name = "imagemPerfilLabel";
            imagemPerfilLabel.Size = new System.Drawing.Size(73, 13);
            imagemPerfilLabel.TabIndex = 89;
            imagemPerfilLabel.Text = "Imagem Perfil:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(1138, 328);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 90;
            usernameLabel.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensagens";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(499, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Nome";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.label3);
            this.panMenu.Controls.Add(this.lblUsername);
            this.panMenu.Controls.Add(this.lblEdidarPerfil);
            this.panMenu.Controls.Add(this.picImagem);
            this.panMenu.Controls.Add(this.label1);
            this.panMenu.Location = new System.Drawing.Point(2, 3);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(710, 81);
            this.panMenu.TabIndex = 57;
            // 
            // lblEdidarPerfil
            // 
            this.lblEdidarPerfil.AutoSize = true;
            this.lblEdidarPerfil.Location = new System.Drawing.Point(499, 31);
            this.lblEdidarPerfil.Name = "lblEdidarPerfil";
            this.lblEdidarPerfil.Size = new System.Drawing.Size(57, 13);
            this.lblEdidarPerfil.TabIndex = 4;
            this.lblEdidarPerfil.Text = "Ediar Perfil";
            this.lblEdidarPerfil.Click += new System.EventHandler(this.label4_Click);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(419, 3);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(65, 71);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 2;
            this.picImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logotipo/Nome da Biblioteca";
            // 
            // panLivroClick
            // 
            this.panLivroClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panLivroClick.Controls.Add(this.lblDescricao);
            this.panLivroClick.Controls.Add(this.lblDescLiv);
            this.panLivroClick.Controls.Add(this.lblCategoria);
            this.panLivroClick.Controls.Add(this.lblNumPag);
            this.panLivroClick.Controls.Add(this.lblEditora);
            this.panLivroClick.Controls.Add(this.lblAutor);
            this.panLivroClick.Controls.Add(this.lblTitulo);
            this.panLivroClick.Controls.Add(this.picFecharDesc);
            this.panLivroClick.Controls.Add(this.picCapaLivSug);
            this.panLivroClick.Location = new System.Drawing.Point(718, 82);
            this.panLivroClick.Name = "panLivroClick";
            this.panLivroClick.Size = new System.Drawing.Size(382, 457);
            this.panLivroClick.TabIndex = 74;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Silver;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(25, 280);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(346, 159);
            this.lblDescricao.TabIndex = 48;
            this.lblDescricao.Text = "...\r\n";
            // 
            // lblDescLiv
            // 
            this.lblDescLiv.AutoSize = true;
            this.lblDescLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescLiv.ForeColor = System.Drawing.Color.White;
            this.lblDescLiv.Location = new System.Drawing.Point(11, 260);
            this.lblDescLiv.Name = "lblDescLiv";
            this.lblDescLiv.Size = new System.Drawing.Size(88, 20);
            this.lblDescLiv.TabIndex = 47;
            this.lblDescLiv.Text = "Descrição: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(30, 193);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblCategoria.TabIndex = 46;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblNumPag
            // 
            this.lblNumPag.AutoSize = true;
            this.lblNumPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPag.ForeColor = System.Drawing.Color.White;
            this.lblNumPag.Location = new System.Drawing.Point(21, 218);
            this.lblNumPag.Name = "lblNumPag";
            this.lblNumPag.Size = new System.Drawing.Size(95, 20);
            this.lblNumPag.TabIndex = 45;
            this.lblNumPag.Text = "Nº Páginas: ";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.ForeColor = System.Drawing.Color.White;
            this.lblEditora.Location = new System.Drawing.Point(48, 168);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(68, 20);
            this.lblEditora.TabIndex = 44;
            this.lblEditora.Text = "Editora: ";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(133, 103);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 24);
            this.lblAutor.TabIndex = 43;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(122, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 70);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "TÍTULO";
            // 
            // picFecharDesc
            // 
            this.picFecharDesc.Image = global::GestaoBiblioteca.Properties.Resources.x;
            this.picFecharDesc.Location = new System.Drawing.Point(352, 3);
            this.picFecharDesc.Name = "picFecharDesc";
            this.picFecharDesc.Size = new System.Drawing.Size(25, 28);
            this.picFecharDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFecharDesc.TabIndex = 41;
            this.picFecharDesc.TabStop = false;
            this.picFecharDesc.Click += new System.EventHandler(this.picFecharDesc_Click);
            // 
            // picCapaLivSug
            // 
            this.picCapaLivSug.BackColor = System.Drawing.Color.White;
            this.picCapaLivSug.Location = new System.Drawing.Point(15, 23);
            this.picCapaLivSug.Name = "picCapaLivSug";
            this.picCapaLivSug.Size = new System.Drawing.Size(101, 128);
            this.picCapaLivSug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapaLivSug.TabIndex = 40;
            this.picCapaLivSug.TabStop = false;
            // 
            // tmrDescricao
            // 
            this.tmrDescricao.Interval = 1;
            this.tmrDescricao.Tick += new System.EventHandler(this.tmrDescricao_Tick);
            // 
            // gestaoBibliotecaDataSet
            // 
            this.gestaoBibliotecaDataSet.DataSetName = "GestaoBibliotecaDataSet";
            this.gestaoBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.gestaoBibliotecaDataSet;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeitorTableAdapter = null;
            this.tableAdapterManager.Livro_LeitorTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codLivroTextBox
            // 
            this.codLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "CodLivro", true));
            this.codLivroTextBox.Location = new System.Drawing.Point(1202, 97);
            this.codLivroTextBox.Name = "codLivroTextBox";
            this.codLivroTextBox.Size = new System.Drawing.Size(74, 20);
            this.codLivroTextBox.TabIndex = 75;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(1202, 123);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(74, 20);
            this.tituloTextBox.TabIndex = 77;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(1202, 149);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(74, 20);
            this.autorTextBox.TabIndex = 79;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(1202, 175);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(74, 20);
            this.editoraTextBox.TabIndex = 81;
            // 
            // numPaginasTextBox
            // 
            this.numPaginasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "NumPaginas", true));
            this.numPaginasTextBox.Location = new System.Drawing.Point(1202, 201);
            this.numPaginasTextBox.Name = "numPaginasTextBox";
            this.numPaginasTextBox.Size = new System.Drawing.Size(74, 20);
            this.numPaginasTextBox.TabIndex = 83;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(1202, 227);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(74, 20);
            this.categoriaTextBox.TabIndex = 85;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(1202, 253);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(74, 20);
            this.descricaoTextBox.TabIndex = 87;
            // 
            // capaTextBox
            // 
            this.capaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Capa", true));
            this.capaTextBox.Location = new System.Drawing.Point(1202, 279);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(74, 20);
            this.capaTextBox.TabIndex = 89;
            // 
            // leitorBindingSource
            // 
            this.leitorBindingSource.DataMember = "Leitor";
            this.leitorBindingSource.DataSource = this.gestaoBibliotecaDataSet;
            // 
            // leitorTableAdapter
            // 
            this.leitorTableAdapter.ClearBeforeFill = true;
            // 
            // imagemPerfilTextBox
            // 
            this.imagemPerfilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "ImagemPerfil", true));
            this.imagemPerfilTextBox.Location = new System.Drawing.Point(1202, 353);
            this.imagemPerfilTextBox.Name = "imagemPerfilTextBox";
            this.imagemPerfilTextBox.Size = new System.Drawing.Size(74, 20);
            this.imagemPerfilTextBox.TabIndex = 90;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(1202, 325);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(74, 20);
            this.usernameTextBox.TabIndex = 91;
            // 
            // frmSugestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 542);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(imagemPerfilLabel);
            this.Controls.Add(this.imagemPerfilTextBox);
            this.Controls.Add(codLivroLabel);
            this.Controls.Add(this.codLivroTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(numPaginasLabel);
            this.Controls.Add(this.numPaginasTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(capaLabel);
            this.Controls.Add(this.capaTextBox);
            this.Controls.Add(this.panLivroClick);
            this.Controls.Add(this.panMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSugestoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sugestoes";
            this.Load += new System.EventHandler(this.frmSugestoes_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.panLivroClick.ResumeLayout(false);
            this.panLivroClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFecharDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapaLivSug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label lblEdidarPerfil;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panLivroClick;
        private System.Windows.Forms.PictureBox picCapaLivSug;
        private System.Windows.Forms.Timer tmrDescricao;
        private System.Windows.Forms.PictureBox picFecharDesc;
        private GestaoBibliotecaDataSet gestaoBibliotecaDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private GestaoBibliotecaDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private GestaoBibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDescLiv;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNumPag;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox codLivroTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox numPaginasTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.BindingSource leitorBindingSource;
        private GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter leitorTableAdapter;
        private System.Windows.Forms.TextBox imagemPerfilTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}