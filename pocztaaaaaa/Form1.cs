using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocztaaaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxType.Image = Image.FromFile("pocztowka.png");
            comboBox1.Items.AddRange(new string[]
            {
                "1",
                "2",
                "3",
                "4"
            });
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string postalCode = textBoxPostCode.Text;
            int valueOfCode;

            if (postalCode.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczb cyfr w kodzie pocztowym");
            }else if(!Int32.TryParse(postalCode, out valueOfCode) || valueOfCode < 0)
            {
                MessageBox.Show("Kod ppocztowy powinien składać się z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }

        private void buttonCheckPrice_Click(object sender, EventArgs e)
        {
            //normalnie sprawdzasz ifami

            var checkedButton = groupBoxType.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            switch (checkedButton.Name)
            {
                case "radioPostcard":
                    //pictureBoxType.Image = Properties.Resources.pocztowka_png;
                    pictureBoxType.Image = Image.FromFile("pocztowka.png");
                    break;
                case "radioLetter":
                    //pictureBoxType.Image = Properties.Resources.list_png;
                    pictureBoxType.Image = Image.FromFile("list.png");
                    break;
                case "radioPackage":
                    //pictureBoxType.Image = Properties.Resources.paczka_png;
                    pictureBoxType.Image = Image.FromFile("paczka.png");
                    break;
                default:
                    break;

            }

            labelPrice.Text = comboBox1.SelectedItem.ToString() + " " + checkedButton.Text;

        }
    }
}
