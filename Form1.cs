using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS2122_4E_INF_QuadrelliFabio_GestioneArticoli.Library;

namespace AS2122_4E_INF_QuadrelliFabio_GestioneArticoli
{
    public partial class Form1 : Form
    {
        Dictionary<string, Articolo> articoli;

        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }

        private void form1_load(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
            {
                articoli[xtCodice.Text] = new Articolo(txtCodice.Text, cmbunitaDiMisura, txtDescrizione, txtPrezzo.Text);
            }
            else
            {
                articoli[xtCodice.Text] = new Articolo(txtCodice.Text, cmbunitaDiMisura, txtDescrizione, txtPrezzo.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
