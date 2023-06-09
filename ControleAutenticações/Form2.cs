﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAutenticações
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String cep = txtCep.Text;
            var content = client.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");
            MessageBox.Show(content);
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString("hh:mm"));
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString("dd/MM/YYYY"));
        }

        private void btnUsb_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String cep = txtCep.Text;
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
            MessageBox.Show(content);
        }

        private void btnBrl_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
            MessageBox.Show(content);
        }
    }
}
