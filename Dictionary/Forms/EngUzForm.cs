using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Forms
{

    public partial class EngUzForm : Form
    {
        private int count = 0;

        private int countRepeat = 0;

        private List<string> ListWords = new List<string>();

        public EngUzForm()
        {
            InitializeComponent();
        }

        private void btnBoshlash_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");

            lebelSozTanla.Text = list[count];
            count += 2;
        }

        private void btnTekshirish_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");
            int index = Array.IndexOf(list, lebelSozTanla.Text);

            try
            {
                if (list[index + 1] == textBoxUz.Text)
                {
                    labelNatija.Text = "Correct answer";
                    labelNatija.ForeColor = Color.Green;
                    textBoxUz.ForeColor = Color.Green;
                }
                else
                {
                    labelNatija.Text = "Wrong answer";
                    labelNatija.ForeColor = Color.Red;
                    textBoxUz.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("So'z xato kiritilgan !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxUz.ForeColor = Color.Black;
        }

        private void btnKeyingisi_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");



            lebelSozTanla.Text = list[count];

            count += 2;
            countRepeat++;

            if (countRepeat % 10 == 0)
            {

                lebelSozTanla.Text = ListWords[countRepeat / 10 - 1];
            }

            textBoxUz.Text = string.Empty;
            labelNatija.Text = string.Empty;
        }

        private void btnKorish_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");
            int index = Array.IndexOf(list, lebelSozTanla.Text);

            textBoxUz.ForeColor = Color.Red;

            labelNatija.Text = list[index + 1];
            labelNatija.ForeColor = Color.Red;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {

            ListWords.Add(lebelSozTanla.Text);

            MessageBox.Show("Bu so'zni yana takrorlaysiz.");
        }

        private void textBoxUz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
