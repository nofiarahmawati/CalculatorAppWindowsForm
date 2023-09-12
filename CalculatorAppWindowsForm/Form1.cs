using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add items to the comboBox1 during form initialization
            comboBox1.Items.Add("Penambahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
        }

        // Calculation methods for the different operations
        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        // Event handler for the "Hitung" button's Click event
        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Parse the values entered in the text boxes
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            // Clear the previous results in the list box
            lstHasil.Items.Clear();

            // Check the selected operation in comboBox1 and display the result
            if (comboBox1.SelectedIndex == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b)));
            }

            if (comboBox1.SelectedIndex == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            }

            if (comboBox1.SelectedIndex == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, Perkalian(a, b)));
            }

            if (comboBox1.SelectedIndex == 3)
            {
                lstHasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, Pembagian(a, b)));
            }
        }

        // Other event handlers and methods (you can leave them empty for now)
    }
}
