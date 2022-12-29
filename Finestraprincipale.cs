﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CopiaFoto
{
    public partial class Finestraprincipale : Form
    {
        public Finestraprincipale()
        {
            InitializeComponent();
            string strSorgente= ConfigurationManager.AppSettings.Get("sorgente");
            if (Directory.Exists(strSorgente))
                txtSorgente.Text = strSorgente;
            string strDestinazione = ConfigurationManager.AppSettings.Get("destinazione");
            if (Directory.Exists(strDestinazione))
                txtDestinazione.Text = strDestinazione;
        }

        private void btnSorgente_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser1 = new FolderBrowserDialog();
            folderBrowser1.SelectedPath = txtDestinazione.Text;
            if (DialogResult.OK == folderBrowser1.ShowDialog())
                txtSorgente.Text = folderBrowser1.SelectedPath;
        }

        private void btnDestinazione_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser1 = new FolderBrowserDialog();
            folderBrowser1.SelectedPath = txtDestinazione.Text;
            folderBrowser1.ShowNewFolderButton = true;
            if (DialogResult.OK == folderBrowser1.ShowDialog())
                txtDestinazione.Text = folderBrowser1.SelectedPath;

        }

        private void btnProcedi_Click(object sender, EventArgs e)
        {
            string dirSorgente = txtSorgente.Text;
            string dirDest = txtDestinazione.Text;

            CopiaRipetuta(dirSorgente, dirDest);

        }

        private void CopiaRipetuta(string dirSorgente, string dirDest)
        {
            string mPattern = "2022";
            foreach (string s in Directory.GetFiles(dirSorgente))
            {
                System.IO.FileInfo fi = new FileInfo(s);
                if (s.IndexOf(mPattern) > 0)
                    MoveCopy(s, dirDest);
            }
        }

        private void MoveCopy(string sPartenza, string baseDirDest)
        {
            string data = EstraiData(sPartenza);
            if(data!=null)
            {
                data = String.Concat(data.Substring(0, 4), "-", data.Substring(4, 2), "-", data.Substring(6, 2));
                string dirDest = Path.Combine(baseDirDest, data);
                string pathDest= Path.Combine(dirDest, Path.GetFileName(sPartenza));
                if (!Directory.Exists(dirDest))
                    Directory.CreateDirectory(dirDest);
                File.Copy(sPartenza, pathDest, false);
            }
        }

        private string EstraiData(string sPartenza)
        {
            var m = Regex.Matches(sPartenza, @"(IMG|VID)_(\d{8})");
            if (m.Count==1)
            {
                return m[0].Value.Substring(4,8);
            }
            return null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ConfigurationManager.AppSettings.Set("sorgente", txtSorgente.Text);
            ConfigurationManager.AppSettings.Set("destinazione", txtDestinazione.Text);
            base.OnFormClosing(e);
        }
    }
}
