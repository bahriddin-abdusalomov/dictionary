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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            labelTranlate.Text = string.Empty;

            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] list = sr.ReadToEnd().Split("\r\n");

            if (textBoxSearch.Text != string.Empty)
            {

                int index = Array.IndexOf(list, textBoxSearch.Text);


                if (index % 2 == 0)
                {
                    labelTranlate.Text += "Eng - Uz: " + list[index] + " - " + list[index + 1];
                }
                else
                {
                    labelTranlate.Text += "Uz - Eng: " + list[index] + " - " + list[index - 1];
                }

                try
                {
                    StreamReader sentences = new StreamReader(Application.StartupPath + "\\SentenceFile\\" + $"{textBoxSearch.Text}.txt");
                    string sentence = sentences.ReadToEnd();

                    sentences.Close();

                    textBoxSentence.Text = sentence;
                }
                catch
                {
                    //  MessageBox.Show("Shu so'zga oid matn kiritishingiz mumkin !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("So'z kiriting !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StreamWriter sentence = new StreamWriter(Application.StartupPath + "\\SentenceFile\\" + $"{textBoxSearch.Text}.txt");

            sentence.WriteLine(textBoxSentence.Text);
            sentence.Close();

            textBoxSentence.Text = string.Empty;


            //if (textBoxSentence is null)
            //{
            //    MessageBox.Show("So'z yoki matn kiriting !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    MessageBox.Show("Amaliyotni muvafaqiyatli amalga oshirdingiz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
