using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dictionary.Forms
{
    public partial class UzEngForm : Form
    {
        private int count = 0;

        private int countRepeat = 0;

        private List<string> ListWords = new List<string>();

        public UzEngForm()
        {
            InitializeComponent();
        }

        private void btnBoshlash_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");

            lebelSozTanla.Text = list[count + 1];
            count += 2;
        }

        private void btnTekshirish_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");
            int index = Array.IndexOf(list, lebelSozTanla.Text);

            try
            {
                if (list[count - 2] == textBoxEng.Text)
                {
                    labelNatija.Text = "To'g'ri javob";
                    labelNatija.ForeColor = Color.Green;
                    textBoxEng.ForeColor = Color.Green;
                }
                else
                {
                    labelNatija.Text = "Noto'g'ri javob";
                    labelNatija.ForeColor = Color.Red;
                    textBoxEng.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("So'z xato kiritilgan !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxEng.ForeColor = Color.Black;
        }

        private void btnKorish_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");
            int index = Array.IndexOf(list, lebelSozTanla.Text);

            textBoxEng.ForeColor = Color.Red;

            labelNatija.Text = list[index - 1];
            labelNatija.ForeColor = Color.Red;
        }

        private void btnKeyingisi_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");



            lebelSozTanla.Text = list[count + 1];

            count += 2;
            countRepeat++;

            if (countRepeat % 10 == 0)
            {

                lebelSozTanla.Text = ListWords[countRepeat / 10 - 1];
            }

            textBoxEng.Text = string.Empty;
            labelNatija.Text = string.Empty;
        }

        private void btnTakrorlash_Click(object sender, EventArgs e)
        {
            ListWords.Add(lebelSozTanla.Text);

            MessageBox.Show("Bu so'zni yana takrorlaysiz.");
        }
    }
}
