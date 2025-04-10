namespace UC11_JOGO_DA_FORCA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonINICIAR = new System.Windows.Forms.Button();
            this.pictureBoxFOTO = new System.Windows.Forms.PictureBox();
            this.labelPalavraSecreta = new System.Windows.Forms.Label();
            this.textBoxLETRA = new System.Windows.Forms.TextBox();
            this.buttonVERIFICAR = new System.Windows.Forms.Button();
            this.buttonRESULTADO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFOTO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "  JOGO DA FORCA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonINICIAR
            // 
            this.buttonINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonINICIAR.Location = new System.Drawing.Point(12, 330);
            this.buttonINICIAR.Name = "buttonINICIAR";
            this.buttonINICIAR.Size = new System.Drawing.Size(112, 27);
            this.buttonINICIAR.TabIndex = 2;
            this.buttonINICIAR.Text = "INICIAR O JOGO";
            this.buttonINICIAR.UseVisualStyleBackColor = true;
            this.buttonINICIAR.Click += new System.EventHandler(this.buttonINICIAR_Click);
            // 
            // pictureBoxFOTO
            // 
            this.pictureBoxFOTO.Image = global::UC11_JOGO_DA_FORCA.Properties.Resources.braco2;
            this.pictureBoxFOTO.Location = new System.Drawing.Point(157, 42);
            this.pictureBoxFOTO.Name = "pictureBoxFOTO";
            this.pictureBoxFOTO.Size = new System.Drawing.Size(221, 236);
            this.pictureBoxFOTO.TabIndex = 0;
            this.pictureBoxFOTO.TabStop = false;
            // 
            // labelPalavraSecreta
            // 
            this.labelPalavraSecreta.AutoSize = true;
            this.labelPalavraSecreta.Location = new System.Drawing.Point(363, 386);
            this.labelPalavraSecreta.Name = "labelPalavraSecreta";
            this.labelPalavraSecreta.Size = new System.Drawing.Size(109, 13);
            this.labelPalavraSecreta.TabIndex = 5;
            this.labelPalavraSecreta.Text = "PALAVRA SECRETA";
            // 
            // textBoxLETRA
            // 
            this.textBoxLETRA.Location = new System.Drawing.Point(323, 363);
            this.textBoxLETRA.Name = "textBoxLETRA";
            this.textBoxLETRA.Size = new System.Drawing.Size(160, 20);
            this.textBoxLETRA.TabIndex = 6;
            // 
            // buttonVERIFICAR
            // 
            this.buttonVERIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVERIFICAR.Location = new System.Drawing.Point(39, 379);
            this.buttonVERIFICAR.Name = "buttonVERIFICAR";
            this.buttonVERIFICAR.Size = new System.Drawing.Size(112, 27);
            this.buttonVERIFICAR.TabIndex = 7;
            this.buttonVERIFICAR.Text = "VERIFICAR";
            this.buttonVERIFICAR.UseVisualStyleBackColor = true;
            this.buttonVERIFICAR.Click += new System.EventHandler(this.buttonVERIFICAR_Click);
            // 
            // buttonRESULTADO
            // 
            this.buttonRESULTADO.Location = new System.Drawing.Point(212, 407);
            this.buttonRESULTADO.Name = "buttonRESULTADO";
            this.buttonRESULTADO.Size = new System.Drawing.Size(87, 23);
            this.buttonRESULTADO.TabIndex = 8;
            this.buttonRESULTADO.Text = "RESULTADO";
            this.buttonRESULTADO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 470);
            this.Controls.Add(this.buttonRESULTADO);
            this.Controls.Add(this.buttonVERIFICAR);
            this.Controls.Add(this.textBoxLETRA);
            this.Controls.Add(this.labelPalavraSecreta);
            this.Controls.Add(this.buttonINICIAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFOTO);
            this.Name = "Form1";
            this.Text = "Jogo da Forca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFOTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFOTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonINICIAR;
        private System.Windows.Forms.Label labelPalavraSecreta;
        private System.Windows.Forms.TextBox textBoxLETRA;
        private System.Windows.Forms.Button buttonVERIFICAR;
        private System.Windows.Forms.Button buttonRESULTADO;
    }
}

