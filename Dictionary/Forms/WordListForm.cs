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
    public partial class WordListForm : Form
    {

        public WordListForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(textBoxEng.Text);
            item.SubItems.Add(textBoxUz.Text);
            WordListView.Items.Add(item);
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(Application.StartupPath + "\\WordList\\" + "words.txt");

            string[] strs = sr.ReadToEnd().Split("\r\n");

            for (int i = 0; i < strs.Length - 1; i += 2)
            {
                ListViewItem item = new ListViewItem(strs[i]);
                item.SubItems.Add(strs[i + 1]);
                WordListView.Items.Add(item);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (WordListView.Items.Count > 0)
            {
                WordListView.Items.Remove(WordListView.SelectedItems[0]);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string item1 = WordListView.SelectedItems[0].SubItems[0].Text;
            textBoxEng.Text = item1;

            string item2 = WordListView.SelectedItems[0].SubItems[1].Text;
            textBoxUz.Text = item2;

            if (WordListView.Items.Count > 0)
            {
                WordListView.Items.Remove(WordListView.SelectedItems[0]);
            }
        }

        private void textBoxUz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
