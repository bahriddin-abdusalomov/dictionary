namespace Dictionary.Forms
{
    partial class WordListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordListForm));
            btnEdit = new Button();
            textBoxEng = new TextBox();
            labelEng = new Label();
            btnRemove = new Button();
            textBoxUz = new TextBox();
            labelUz = new Label();
            WordListView = new ListView();
            English = new ColumnHeader();
            Uzbek = new ColumnHeader();
            btnShowWords = new Button();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSkyBlue;
            btnEdit.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(323, 98);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBoxEng
            // 
            textBoxEng.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEng.Location = new Point(104, 43);
            textBoxEng.Name = "textBoxEng";
            textBoxEng.Size = new Size(271, 30);
            textBoxEng.TabIndex = 4;
            // 
            // labelEng
            // 
            labelEng.AutoSize = true;
            labelEng.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEng.Location = new Point(22, 42);
            labelEng.Name = "labelEng";
            labelEng.Size = new Size(76, 25);
            labelEng.TabIndex = 3;
            labelEng.Text = "English";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightSkyBlue;
            btnRemove.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(537, 98);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 40);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // textBoxUz
            // 
            textBoxUz.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUz.Location = new Point(495, 43);
            textBoxUz.Name = "textBoxUz";
            textBoxUz.Size = new Size(271, 30);
            textBoxUz.TabIndex = 7;
            textBoxUz.TextChanged += textBoxUz_TextChanged;
            // 
            // labelUz
            // 
            labelUz.AutoSize = true;
            labelUz.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUz.Location = new Point(413, 41);
            labelUz.Name = "labelUz";
            labelUz.Size = new Size(68, 25);
            labelUz.TabIndex = 6;
            labelUz.Text = "Uzbek";
            // 
            // WordListView
            // 
            WordListView.Columns.AddRange(new ColumnHeader[] { English, Uzbek });
            WordListView.FullRowSelect = true;
            WordListView.GridLines = true;
            WordListView.Location = new Point(21, 160);
            WordListView.MultiSelect = false;
            WordListView.Name = "WordListView";
            WordListView.Size = new Size(757, 335);
            WordListView.TabIndex = 9;
            WordListView.UseCompatibleStateImageBehavior = false;
            WordListView.View = View.Details;
            // 
            // English
            // 
            English.Text = "English";
            English.Width = 375;
            // 
            // Uzbek
            // 
            Uzbek.Text = "Uzbek";
            Uzbek.Width = 375;
            // 
            // btnShowWords
            // 
            btnShowWords.BackColor = Color.LightSkyBlue;
            btnShowWords.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowWords.Location = new Point(615, 510);
            btnShowWords.Name = "btnShowWords";
            btnShowWords.Size = new Size(163, 40);
            btnShowWords.TabIndex = 10;
            btnShowWords.Text = "Show words";
            btnShowWords.UseVisualStyleBackColor = false;
            btnShowWords.Click += btnShowWords_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.LightSkyBlue;
            btnSelect.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.Location = new Point(119, 98);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(146, 40);
            btnSelect.TabIndex = 11;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // WordListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 553);
            Controls.Add(btnSelect);
            Controls.Add(btnShowWords);
            Controls.Add(WordListView);
            Controls.Add(btnRemove);
            Controls.Add(textBoxUz);
            Controls.Add(labelUz);
            Controls.Add(btnEdit);
            Controls.Add(textBoxEng);
            Controls.Add(labelEng);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WordListForm";
            Text = "WordListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private TextBox textBoxEng;
        private Label labelEng;
        private Button btnRemove;
        private TextBox textBoxUz;
        private Label labelUz;
        private ListView WordListView;
        private ColumnHeader English;
        private ColumnHeader Uzbek;
        private Button btnShowWords;
        private Button btnSelect;
    }
}