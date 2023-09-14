using Dictionary.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            AddWordForm addWordForm = new AddWordForm();
            addWordForm.ShowDialog();
        }

        private void btnWordList_Click(object sender, EventArgs e)
        {
            WordListForm wordListForm = new WordListForm();
            wordListForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void btnRemember_Click(object sender, EventArgs e)
        {
            RememberForm rememberForm = new RememberForm();
            rememberForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

