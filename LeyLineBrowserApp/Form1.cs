using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LeyLineBrowserApp
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }  

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Magia.Navigate(txtBxUrl.Text);
        }

        private void btnRegressar_Click(object sender, EventArgs e)
        {
            Magia.GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Magia.GoForward();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Magia.Stop();
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            Magia.Refresh();
        }

        private void txtBxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Magia.Navigate(txtBxUrl.Text);

            } else if (e.KeyCode == Keys.Escape)
            {
                Magia.GoSearch();
            }
        }


        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            var favoritos = new ArrayList();
            favoritos.Add(txtBxUrl.Text);

           // favoritos[0] = lbl1.Text;
           // favoritos[1] = lbl2.Text;
           // favoritos[2] = lbl3.Text;

            //Da certo mas com apenas um Favorito, não consegui fazer com mais.
            
            foreach (var item in favoritos)
            {
               lbl1.Text = item.ToString();
            } 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Magia.Navigate("https://google.com");
        }

        private void Magia_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
