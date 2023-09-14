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
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\WordList\\" + "words.txt", true);


            sw.WriteLine(textBoxEng.Text);
            sw.WriteLine(textBoxUz.Text);
            sw.Close();


            if (string.IsNullOrEmpty(textBoxEng.Text) || string.IsNullOrEmpty(textBoxUz.Text))
            {
                return;
            }

            ListViewItem item = new ListViewItem(textBoxEng.Text);
            item.SubItems.Add(textBoxUz.Text);
            AddWordListView.Items.Add(item);

            textBoxEng.Clear();
            textBoxUz.Clear();
            textBoxEng.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (AddWordListView.Items.Count > 0)
            {
                AddWordListView.Items.Remove(AddWordListView.SelectedItems[0]);
            }
        }

        private void AddWordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
