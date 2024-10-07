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
    public partial class formStudenti : Form
    {
        public string imeStudenta, prezimeStudenta, smjerStudenta, brojIndeksaStudenta, datumRodjenjaStudenta;
        public formStudenti()
        {
            InitializeComponent();
            listBoxStudenti.Items.Remove("listBoxStudenti");
        }

        private void openNewStudentForm()
        {
            formaUnosNovogStudenta forma2 = new formaUnosNovogStudenta();
            DialogResult rezultat = forma2.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                imeStudenta = forma2.imeStudenta;
                prezimeStudenta = forma2.prezimeStudenta;
                smjerStudenta = forma2.smjerStudenta;
                brojIndeksaStudenta = forma2.brojIndeksaStudenta;
                datumRodjenjaStudenta = forma2.datumRodjenjaStudenta;
            }
        }

        private void formStudenti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openNewStudentForm();
            Student noviStudent = new Student(imeStudenta, prezimeStudenta, smjerStudenta, brojIndeksaStudenta, datumRodjenjaStudenta);

            listBoxStudenti.Items.Add(noviStudent.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.SelectedItem != null)
            {
                listBoxStudenti.Items.Remove(listBoxStudenti.SelectedItem);
            }
            else
            {
                MessageBox.Show("Molimo odaberite studenta za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
