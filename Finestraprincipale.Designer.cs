
namespace CopiaFoto
{
    partial class Finestraprincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSorgente = new System.Windows.Forms.TextBox();
            this.txtDestinazione = new System.Windows.Forms.TextBox();
            this.btnSorgente = new System.Windows.Forms.Button();
            this.btnDestinazione = new System.Windows.Forms.Button();
            this.btnProcedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSorgente
            // 
            this.txtSorgente.Location = new System.Drawing.Point(12, 12);
            this.txtSorgente.Name = "txtSorgente";
            this.txtSorgente.Size = new System.Drawing.Size(437, 23);
            this.txtSorgente.TabIndex = 0;
            this.txtSorgente.Text = "C:\\";
            // 
            // txtDestinazione
            // 
            this.txtDestinazione.Location = new System.Drawing.Point(13, 42);
            this.txtDestinazione.Name = "txtDestinazione";
            this.txtDestinazione.Size = new System.Drawing.Size(436, 23);
            this.txtDestinazione.TabIndex = 1;
            this.txtDestinazione.Text = "D:\\";
            // 
            // btnSorgente
            // 
            this.btnSorgente.Location = new System.Drawing.Point(455, 12);
            this.btnSorgente.Name = "btnSorgente";
            this.btnSorgente.Size = new System.Drawing.Size(104, 23);
            this.btnSorgente.TabIndex = 2;
            this.btnSorgente.Text = "Sorgente...";
            this.btnSorgente.UseVisualStyleBackColor = true;
            this.btnSorgente.Click += new System.EventHandler(this.btnSorgente_Click);
            // 
            // btnDestinazione
            // 
            this.btnDestinazione.Location = new System.Drawing.Point(455, 42);
            this.btnDestinazione.Name = "btnDestinazione";
            this.btnDestinazione.Size = new System.Drawing.Size(104, 23);
            this.btnDestinazione.TabIndex = 3;
            this.btnDestinazione.Text = "Destinazione...";
            this.btnDestinazione.UseVisualStyleBackColor = true;
            this.btnDestinazione.Click += new System.EventHandler(this.btnDestinazione_Click);
            // 
            // btnProcedi
            // 
            this.btnProcedi.Location = new System.Drawing.Point(59, 87);
            this.btnProcedi.Name = "btnProcedi";
            this.btnProcedi.Size = new System.Drawing.Size(186, 67);
            this.btnProcedi.TabIndex = 4;
            this.btnProcedi.Text = "Procedi";
            this.btnProcedi.UseVisualStyleBackColor = true;
            this.btnProcedi.Click += new System.EventHandler(this.btnProcedi_Click);
            // 
            // Finestraprincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 447);
            this.Controls.Add(this.btnProcedi);
            this.Controls.Add(this.btnDestinazione);
            this.Controls.Add(this.btnSorgente);
            this.Controls.Add(this.txtDestinazione);
            this.Controls.Add(this.txtSorgente);
            this.Name = "Finestraprincipale";
            this.Text = "Copia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSorgente;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.Button btnSorgente;
        private System.Windows.Forms.Button btnDestinazione;
        private System.Windows.Forms.Button btnProcedi;
    }
}

