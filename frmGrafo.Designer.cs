namespace EstructuraDatos.pry
{
    partial class frmGrafo
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
            this.lstCamino = new System.Windows.Forms.ListBox();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.cmbCamino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCamino
            // 
            this.lstCamino.FormattingEnabled = true;
            this.lstCamino.ItemHeight = 20;
            this.lstCamino.Location = new System.Drawing.Point(31, 228);
            this.lstCamino.Name = "lstCamino";
            this.lstCamino.Size = new System.Drawing.Size(491, 244);
            this.lstCamino.TabIndex = 0;
            // 
            // btnGrafo
            // 
            this.btnGrafo.Location = new System.Drawing.Point(426, 187);
            this.btnGrafo.Name = "btnGrafo";
            this.btnGrafo.Size = new System.Drawing.Size(96, 35);
            this.btnGrafo.TabIndex = 1;
            this.btnGrafo.Text = "Consulta";
            this.btnGrafo.UseVisualStyleBackColor = true;
            this.btnGrafo.Click += new System.EventHandler(this.btnGrafo_Click);
            // 
            // cmbCamino
            // 
            this.cmbCamino.FormattingEnabled = true;
            this.cmbCamino.Location = new System.Drawing.Point(292, 153);
            this.cmbCamino.Name = "cmbCamino";
            this.cmbCamino.Size = new System.Drawing.Size(230, 28);
            this.cmbCamino.TabIndex = 3;
            this.cmbCamino.SelectedIndexChanged += new System.EventHandler(this.cmbCamino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ruta de vuelos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecciona tu ruta de vuelo con destino:\r\nBOGOTA, COLOMBIA.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salidas y escalas:";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCamino);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.lstCamino);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCamino;
        private System.Windows.Forms.Button btnGrafo;
        private System.Windows.Forms.ComboBox cmbCamino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}