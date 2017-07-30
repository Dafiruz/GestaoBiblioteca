namespace GestaoBiblioteca
{
    partial class frmRegistar
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label palavraPasseLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label imagemPerfilLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistar));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.palavraPasseTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic22 = new System.Windows.Forms.PictureBox();
            this.pic33 = new System.Windows.Forms.PictureBox();
            this.pic44 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoBibliotecaDataSet = new GestaoBiblioteca.GestaoBibliotecaDataSet();
            this.leitorTableAdapter = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter();
            this.tableAdapterManager = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager();
            this.imagemPerfilTextBox = new System.Windows.Forms.TextBox();
            usernameLabel = new System.Windows.Forms.Label();
            palavraPasseLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            imagemPerfilLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(43, 41);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 30;
            usernameLabel.Text = "Username:";
            // 
            // palavraPasseLabel
            // 
            palavraPasseLabel.AutoSize = true;
            palavraPasseLabel.Location = new System.Drawing.Point(23, 120);
            palavraPasseLabel.Name = "palavraPasseLabel";
            palavraPasseLabel.Size = new System.Drawing.Size(78, 13);
            palavraPasseLabel.TabIndex = 32;
            palavraPasseLabel.Text = "Palavra Passe:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(63, 69);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 36;
            nomeLabel.Text = "Nome:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(55, 95);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 38;
            moradaLabel.Text = "Morada:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(77, 196);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 40;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(85, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagem";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(107, 38);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(85, 20);
            this.usernameTextBox.TabIndex = 31;
            // 
            // palavraPasseTextBox
            // 
            this.palavraPasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "PalavraPasse", true));
            this.palavraPasseTextBox.Location = new System.Drawing.Point(107, 117);
            this.palavraPasseTextBox.Name = "palavraPasseTextBox";
            this.palavraPasseTextBox.Size = new System.Drawing.Size(85, 20);
            this.palavraPasseTextBox.TabIndex = 33;
            this.palavraPasseTextBox.UseSystemPasswordChar = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(107, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(85, 20);
            this.nomeTextBox.TabIndex = 37;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(107, 88);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(85, 20);
            this.moradaTextBox.TabIndex = 39;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.leitorBindingSource, "DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(12, 212);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Repetir Passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "é preciso?";
            // 
            // pic22
            // 
            this.pic22.Image = global::GestaoBiblioteca.Properties.Resources._2;
            this.pic22.Location = new System.Drawing.Point(339, 9);
            this.pic22.Name = "pic22";
            this.pic22.Size = new System.Drawing.Size(12, 11);
            this.pic22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic22.TabIndex = 29;
            this.pic22.TabStop = false;
            this.pic22.Tag = "2";
            this.pic22.Visible = false;
            // 
            // pic33
            // 
            this.pic33.Image = global::GestaoBiblioteca.Properties.Resources._3;
            this.pic33.Location = new System.Drawing.Point(339, 26);
            this.pic33.Name = "pic33";
            this.pic33.Size = new System.Drawing.Size(12, 11);
            this.pic33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic33.TabIndex = 28;
            this.pic33.TabStop = false;
            this.pic33.Tag = "3";
            this.pic33.Visible = false;
            // 
            // pic44
            // 
            this.pic44.Image = global::GestaoBiblioteca.Properties.Resources._4;
            this.pic44.Location = new System.Drawing.Point(357, 9);
            this.pic44.Name = "pic44";
            this.pic44.Size = new System.Drawing.Size(12, 11);
            this.pic44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic44.TabIndex = 27;
            this.pic44.TabStop = false;
            this.pic44.Tag = "4";
            this.pic44.Visible = false;
            // 
            // pic11
            // 
            this.pic11.Image = global::GestaoBiblioteca.Properties.Resources._1;
            this.pic11.Location = new System.Drawing.Point(357, 26);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(11, 11);
            this.pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic11.TabIndex = 24;
            this.pic11.TabStop = false;
            this.pic11.Tag = "1";
            this.pic11.Visible = false;
            // 
            // picNext
            // 
            this.picNext.Image = global::GestaoBiblioteca.Properties.Resources.gonext;
            this.picNext.Location = new System.Drawing.Point(682, 167);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(50, 50);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 23;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::GestaoBiblioteca.Properties.Resources._2;
            this.pic2.Location = new System.Drawing.Point(551, 41);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(125, 120);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 22;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::GestaoBiblioteca.Properties.Resources._3;
            this.pic3.Location = new System.Drawing.Point(682, 41);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(125, 120);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 21;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // picPrev
            // 
            this.picPrev.Image = global::GestaoBiblioteca.Properties.Resources.goback;
            this.picPrev.Location = new System.Drawing.Point(495, 167);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(50, 50);
            this.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrev.TabIndex = 19;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::GestaoBiblioteca.Properties.Resources._1;
            this.pic1.Location = new System.Drawing.Point(420, 41);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(125, 120);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 17;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Transparent;
            this.picImagem.Image = global::GestaoBiblioteca.Properties.Resources.default_user;
            this.picImagem.Location = new System.Drawing.Point(243, 43);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(125, 120);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 16;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestaoBiblioteca.Properties.Resources.x;
            this.pictureBox3.Location = new System.Drawing.Point(378, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picGuardar
            // 
            this.picGuardar.Image = global::GestaoBiblioteca.Properties.Resources.confirmar;
            this.picGuardar.Location = new System.Drawing.Point(348, 211);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(25, 25);
            this.picGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGuardar.TabIndex = 14;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(272, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // leitorBindingSource
            // 
            this.leitorBindingSource.DataMember = "Leitor";
            this.leitorBindingSource.DataSource = this.gestaoBibliotecaDataSet;
            // 
            // gestaoBibliotecaDataSet
            // 
            this.gestaoBibliotecaDataSet.DataSetName = "GestaoBibliotecaDataSet";
            this.gestaoBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leitorTableAdapter
            // 
            this.leitorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeitorTableAdapter = this.leitorTableAdapter;
            this.tableAdapterManager.Livro_LeitorTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagemPerfilLabel
            // 
            imagemPerfilLabel.AutoSize = true;
            imagemPerfilLabel.Location = new System.Drawing.Point(28, 172);
            imagemPerfilLabel.Name = "imagemPerfilLabel";
            imagemPerfilLabel.Size = new System.Drawing.Size(73, 13);
            imagemPerfilLabel.TabIndex = 42;
            imagemPerfilLabel.Text = "Imagem Perfil:";
            // 
            // imagemPerfilTextBox
            // 
            this.imagemPerfilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leitorBindingSource, "ImagemPerfil", true));
            this.imagemPerfilTextBox.Location = new System.Drawing.Point(107, 169);
            this.imagemPerfilTextBox.Name = "imagemPerfilTextBox";
            this.imagemPerfilTextBox.Size = new System.Drawing.Size(84, 20);
            this.imagemPerfilTextBox.TabIndex = 43;
            // 
            // frmRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 256);
            this.ControlBox = false;
            this.Controls.Add(imagemPerfilLabel);
            this.Controls.Add(this.imagemPerfilTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(palavraPasseLabel);
            this.Controls.Add(this.palavraPasseTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(this.pic22);
            this.Controls.Add(this.pic33);
            this.Controls.Add(this.pic44);
            this.Controls.Add(this.pic11);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistar";
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.frmRegistar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox pic33;
        private System.Windows.Forms.PictureBox pic22;
        private System.Windows.Forms.PictureBox pic11;
        private System.Windows.Forms.PictureBox pic44;
        private GestaoBibliotecaDataSet gestaoBibliotecaDataSet;
        private System.Windows.Forms.BindingSource leitorBindingSource;
        private GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter leitorTableAdapter;
        private GestaoBibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox palavraPasseTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imagemPerfilTextBox;
    }
}