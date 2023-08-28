namespace TestInteropCS_net4._8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxWord = new System.Windows.Forms.PictureBox();
            this.pictureBoxExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(43, 53);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(323, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escribe el texto:";
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.Image = global::TestInteropCS_net4._8.Properties.Resources.microsoft_office_word_logo_icon_145724__1_;
            this.pictureBoxWord.Location = new System.Drawing.Point(91, 124);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWord.TabIndex = 4;
            this.pictureBoxWord.TabStop = false;
            this.pictureBoxWord.Click += new System.EventHandler(this.pictureBoxWord_Click);
            // 
            // pictureBoxExcel
            // 
            this.pictureBoxExcel.Image = global::TestInteropCS_net4._8.Properties.Resources.microsoft_office_excel_logo_icon_145720__1_;
            this.pictureBoxExcel.Location = new System.Drawing.Point(209, 124);
            this.pictureBoxExcel.Name = "pictureBoxExcel";
            this.pictureBoxExcel.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExcel.TabIndex = 5;
            this.pictureBoxExcel.TabStop = false;
            this.pictureBoxExcel.Click += new System.EventHandler(this.pictureBoxExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 228);
            this.Controls.Add(this.pictureBoxExcel);
            this.Controls.Add(this.pictureBoxWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Crear documentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxWord;
        private System.Windows.Forms.PictureBox pictureBoxExcel;
    }
}

