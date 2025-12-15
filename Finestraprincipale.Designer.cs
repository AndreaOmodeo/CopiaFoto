
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
            txtSorgente = new System.Windows.Forms.TextBox();
            txtDestinazione = new System.Windows.Forms.TextBox();
            btnSorgente = new System.Windows.Forms.Button();
            btnDestinazione = new System.Windows.Forms.Button();
            btnProcedi = new System.Windows.Forms.Button();
            grpAzione = new System.Windows.Forms.GroupBox();
            rdoCopia = new System.Windows.Forms.RadioButton();
            rdoMuovi = new System.Windows.Forms.RadioButton();
            grpAzione.SuspendLayout();
            SuspendLayout();
            // 
            // txtSorgente
            // 
            txtSorgente.Location = new System.Drawing.Point(12, 12);
            txtSorgente.Name = "txtSorgente";
            txtSorgente.Size = new System.Drawing.Size(437, 23);
            txtSorgente.TabIndex = 0;
            txtSorgente.Text = "C:\\";
            // 
            // txtDestinazione
            // 
            txtDestinazione.Location = new System.Drawing.Point(13, 42);
            txtDestinazione.Name = "txtDestinazione";
            txtDestinazione.Size = new System.Drawing.Size(436, 23);
            txtDestinazione.TabIndex = 1;
            txtDestinazione.Text = "D:\\";
            // 
            // btnSorgente
            // 
            btnSorgente.Location = new System.Drawing.Point(455, 12);
            btnSorgente.Name = "btnSorgente";
            btnSorgente.Size = new System.Drawing.Size(104, 23);
            btnSorgente.TabIndex = 2;
            btnSorgente.Text = "Sorgente...";
            btnSorgente.UseVisualStyleBackColor = true;
            btnSorgente.Click += btnSorgente_Click;
            // 
            // btnDestinazione
            // 
            btnDestinazione.Location = new System.Drawing.Point(455, 42);
            btnDestinazione.Name = "btnDestinazione";
            btnDestinazione.Size = new System.Drawing.Size(104, 23);
            btnDestinazione.TabIndex = 3;
            btnDestinazione.Text = "Destinazione...";
            btnDestinazione.UseVisualStyleBackColor = true;
            btnDestinazione.Click += btnDestinazione_Click;
            // 
            // btnProcedi
            // 
            btnProcedi.Location = new System.Drawing.Point(373, 91);
            btnProcedi.Name = "btnProcedi";
            btnProcedi.Size = new System.Drawing.Size(186, 67);
            btnProcedi.TabIndex = 4;
            btnProcedi.Text = "Procedi";
            btnProcedi.UseVisualStyleBackColor = true;
            btnProcedi.Click += btnProcedi_Click;
            // 
            // grpAzione
            // 
            grpAzione.Controls.Add(rdoMuovi);
            grpAzione.Controls.Add(rdoCopia);
            grpAzione.Location = new System.Drawing.Point(30, 101);
            grpAzione.Name = "grpAzione";
            grpAzione.Size = new System.Drawing.Size(200, 100);
            grpAzione.TabIndex = 5;
            grpAzione.TabStop = false;
            grpAzione.Text = "Azione";
            // 
            // rdoCopia
            // 
            rdoCopia.AutoSize = true;
            rdoCopia.Location = new System.Drawing.Point(10, 22);
            rdoCopia.Name = "rdoCopia";
            rdoCopia.Size = new System.Drawing.Size(182, 19);
            rdoCopia.TabIndex = 0;
            rdoCopia.TabStop = true;
            rdoCopia.Text = "&Copia mantenendo l'originale";
            rdoCopia.UseVisualStyleBackColor = true;
            // 
            // rdoMuovi
            // 
            rdoMuovi.AutoSize = true;
            rdoMuovi.Location = new System.Drawing.Point(10, 47);
            rdoMuovi.Name = "rdoMuovi";
            rdoMuovi.Size = new System.Drawing.Size(89, 19);
            rdoMuovi.TabIndex = 1;
            rdoMuovi.TabStop = true;
            rdoMuovi.Text = "&Muovi i files";
            rdoMuovi.UseVisualStyleBackColor = true;
            // 
            // Finestraprincipale
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(691, 447);
            Controls.Add(grpAzione);
            Controls.Add(btnProcedi);
            Controls.Add(btnDestinazione);
            Controls.Add(btnSorgente);
            Controls.Add(txtDestinazione);
            Controls.Add(txtSorgente);
            Name = "Finestraprincipale";
            Text = "Copia";
            grpAzione.ResumeLayout(false);
            grpAzione.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSorgente;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.Button btnSorgente;
        private System.Windows.Forms.Button btnDestinazione;
        private System.Windows.Forms.Button btnProcedi;
        private System.Windows.Forms.GroupBox grpAzione;
        private System.Windows.Forms.RadioButton rdoMuovi;
        private System.Windows.Forms.RadioButton rdoCopia;
    }
}

