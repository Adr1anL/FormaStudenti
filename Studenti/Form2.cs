using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class formaUnosNovogStudenta : Form
    {

        public string imeStudenta => textBoxIme.Text;
        public string prezimeStudenta => textBoxPrezime.Text; 
        public string smjerStudenta => comboBoxSmjer.Text;
        public string brojIndeksaStudenta => textBoxBrojIndeksa.Text;
        public string datumRodjenjaStudenta => dateTimePickerDatumRodjenja.Value.ToString("yyyy-MM-dd");
        public formaUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBrojIndeksa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
