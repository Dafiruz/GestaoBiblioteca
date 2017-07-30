namespace GestaoBiblioteca
{
    partial class frmLogin
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
            this.txtPalPasse = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtRepPalPasse = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRepPalPasse = new System.Windows.Forms.Label();
            this.lblPalPasse = new System.Windows.Forms.Label();
            this.picEntrar = new System.Windows.Forms.PictureBox();
            this.picSair = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.picRegistar = new System.Windows.Forms.PictureBox();
            this.gestaoBibliotecaDataSet = new GestaoBiblioteca.GestaoBibliotecaDataSet();
            this.leitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leitorTableAdapter = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter();
            this.tableAdapterManager = new GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalPasse
            // 
            this.txtPalPasse.Location = new System.Drawing.Point(270, 334);
            this.txtPalPasse.Name = "txtPalPasse";
            this.txtPalPasse.PasswordChar = '*';
            this.txtPalPasse.Size = new System.Drawing.Size(148, 20);
            this.txtPalPasse.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(270, 304);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtRepPalPasse
            // 
            this.txtRepPalPasse.Location = new System.Drawing.Point(270, 377);
            this.txtRepPalPasse.Name = "txtRepPalPasse";
            this.txtRepPalPasse.PasswordChar = '*';
            this.txtRepPalPasse.Size = new System.Drawing.Size(148, 20);
            this.txtRepPalPasse.TabIndex = 2;
            this.txtRepPalPasse.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(209, 304);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Nome:";
            // 
            // lblRepPalPasse
            // 
            this.lblRepPalPasse.AutoSize = true;
            this.lblRepPalPasse.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPalPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPalPasse.ForeColor = System.Drawing.Color.White;
            this.lblRepPalPasse.Location = new System.Drawing.Point(94, 377);
            this.lblRepPalPasse.Name = "lblRepPalPasse";
            this.lblRepPalPasse.Size = new System.Drawing.Size(170, 20);
            this.lblRepPalPasse.TabIndex = 4;
            this.lblRepPalPasse.Text = "Repetir Palavra-Passe:";
            this.lblRepPalPasse.Visible = false;
            // 
            // lblPalPasse
            // 
            this.lblPalPasse.AutoSize = true;
            this.lblPalPasse.BackColor = System.Drawing.Color.Transparent;
            this.lblPalPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalPasse.ForeColor = System.Drawing.Color.White;
            this.lblPalPasse.Location = new System.Drawing.Point(150, 332);
            this.lblPalPasse.Name = "lblPalPasse";
            this.lblPalPasse.Size = new System.Drawing.Size(114, 20);
            this.lblPalPasse.TabIndex = 4;
            this.lblPalPasse.Text = "Palavra-Passe:";
            // 
            // picEntrar
            // 
            this.picEntrar.BackColor = System.Drawing.Color.Transparent;
            this.picEntrar.Image = global::GestaoBiblioteca.Properties.Resources.btn_Entrar;
            this.picEntrar.Location = new System.Drawing.Point(480, 285);
            this.picEntrar.Name = "picEntrar";
            this.picEntrar.Size = new System.Drawing.Size(200, 100);
            this.picEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntrar.TabIndex = 6;
            this.picEntrar.TabStop = false;
            this.picEntrar.Click += new System.EventHandler(this.picEntrar_Click);
            // 
            // picSair
            // 
            this.picSair.BackColor = System.Drawing.Color.Transparent;
            this.picSair.Image = global::GestaoBiblioteca.Properties.Resources.x;
            this.picSair.Location = new System.Drawing.Point(661, 427);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(38, 37);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSair.TabIndex = 7;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(299, 403);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 27);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // picRegistar
            // 
            this.picRegistar.BackColor = System.Drawing.Color.Transparent;
            this.picRegistar.Image = global::GestaoBiblioteca.Properties.Resources.btn_Regi;
            this.picRegistar.Location = new System.Drawing.Point(480, 325);
            this.picRegistar.Name = "picRegistar";
            this.picRegistar.Size = new System.Drawing.Size(200, 100);
            this.picRegistar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegistar.TabIndex = 11;
            this.picRegistar.TabStop = false;
            this.picRegistar.Click += new System.EventHandler(this.picRegistar_Click);
            // 
            // gestaoBibliotecaDataSet
            // 
            this.gestaoBibliotecaDataSet.DataSetName = "GestaoBibliotecaDataSet";
            this.gestaoBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeitorTableAdapter = this.leitorTableAdapter;
            this.tableAdapterManager.Livro_LeitorTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestaoBiblioteca.GestaoBibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoBiblioteca.Properties.Resources.biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 476);
            this.ControlBox = false;
            this.Controls.Add(this.picRegistar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.picEntrar);
            this.Controls.Add(this.lblPalPasse);
            this.Controls.Add(this.lblRepPalPasse);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtRepPalPasse);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPalPasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoBibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalPasse;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtRepPalPasse;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRepPalPasse;
        private System.Windows.Forms.Label lblPalPasse;
        private System.Windows.Forms.PictureBox picEntrar;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox picRegistar;
        private GestaoBibliotecaDataSet gestaoBibliotecaDataSet;
        private System.Windows.Forms.BindingSource leitorBindingSource;
        private GestaoBibliotecaDataSetTableAdapters.LeitorTableAdapter leitorTableAdapter;
        private GestaoBibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}