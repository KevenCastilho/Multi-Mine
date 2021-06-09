
namespace Multi_Mine
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbPastas = new System.Windows.Forms.ComboBox();
            this.pbMinePack = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.lblCriadoEm = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinePack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPastas
            // 
            this.cbPastas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPastas.FormattingEnabled = true;
            this.cbPastas.Location = new System.Drawing.Point(168, 12);
            this.cbPastas.Name = "cbPastas";
            this.cbPastas.Size = new System.Drawing.Size(135, 21);
            this.cbPastas.TabIndex = 2;
            this.cbPastas.SelectedIndexChanged += new System.EventHandler(this.cbPastas_SelectedIndexChanged);
            // 
            // pbMinePack
            // 
            this.pbMinePack.BackColor = System.Drawing.Color.Transparent;
            this.pbMinePack.Image = global::Multi_Mine.Properties.Resources.none;
            this.pbMinePack.Location = new System.Drawing.Point(12, 12);
            this.pbMinePack.Name = "pbMinePack";
            this.pbMinePack.Size = new System.Drawing.Size(151, 151);
            this.pbMinePack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinePack.TabIndex = 3;
            this.pbMinePack.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Jogar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCaminho);
            this.groupBox1.Controls.Add(this.lblCriadoEm);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(168, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(72, 72);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(22, 13);
            this.lblCaminho.TabIndex = 6;
            this.lblCaminho.Text = ". . .";
            // 
            // lblCriadoEm
            // 
            this.lblCriadoEm.AutoSize = true;
            this.lblCriadoEm.Location = new System.Drawing.Point(72, 48);
            this.lblCriadoEm.Name = "lblCriadoEm";
            this.lblCriadoEm.Size = new System.Drawing.Size(22, 13);
            this.lblCriadoEm.TabIndex = 5;
            this.lblCriadoEm.Text = ". . .";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(72, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(22, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = ". . .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caminho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criado em: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Multi_Mine.Properties.Resources.d4m00v3_e3ad6c0b_c466_4eff_9eec_4ac7dad60bff;
            this.ClientSize = new System.Drawing.Size(475, 175);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbMinePack);
            this.Controls.Add(this.cbPastas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Mine";
            ((System.ComponentModel.ISupportInitialize)(this.pbMinePack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbPastas;
        private System.Windows.Forms.PictureBox pbMinePack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label lblCriadoEm;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

