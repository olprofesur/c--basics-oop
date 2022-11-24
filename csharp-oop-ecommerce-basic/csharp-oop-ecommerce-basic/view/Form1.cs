using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using csharp_oop_ecommerce_basic.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharp_oop_ecommerce_basic
{
    public partial class Form1 : Form
    {
        private Carrello carr;
        int listIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] intestazione = new string[] { "ID", "NOME", "DESCRIZIONE", "PREZZO" };

            for (int i = 0; i < intestazione.Length; i++)
            {
                listino.Columns.Add(intestazione[i]);
            }


            Prodotto[] prodotti=carr.Prodotti;

            for (int i=0;i<prodotti.Length;i++)
            {   
                //se ToString presenta esattamente i campi necessari..
                ListViewItem riga = new ListViewItem(prodotti[i].ToString().Split(';'));
                listino.Items.Add(riga);
            }

  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            carr = new Carrello("CARR1");
            Prodotto prod1 = new Prodotto("IDPROD1", "IPHONE14", "Apple", "IPHONE14", 1100);
            Prodotto prod2 = new Prodotto("IDPROD2", "MI SMART TV 43''", "Xiaomi", "MI SMART TV 43''", 299);
            carr.Aggiungi(prod1);
            carr.Aggiungi(prod2);
            MessageBox.Show("Carrello creato");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listino.FocusedItem == null) return;
            int listIndex = listino.FocusedItem.Index;
            MessageBox.Show(Convert.ToString(listIndex));

        }
    }
}
