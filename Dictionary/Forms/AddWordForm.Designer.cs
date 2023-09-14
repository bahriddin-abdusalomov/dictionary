namespace Dictionary.Forms
{
    partial class AddWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWordForm));
            label1 = new Label();
            textBoxEng = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            textBoxUz = new TextBox();
            labelUz = new Label();
            AddWordListView = new ListView();
            English = new ColumnHeader();
            Uzbek = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "English";
            // 
            // textBoxEng
            // 
            textBoxEng.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEng.Location = new Point(188, 46);
            textBoxEng.Name = "textBoxEng";
            textBoxEng.Size = new Size(331, 30);
            textBoxEng.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSkyBlue;
            btnAdd.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(600, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightSkyBlue;
            btnRemove.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(600, 98);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 40);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // textBoxUz
            // 
            textBoxUz.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUz.Location = new Point(188, 105);
            textBoxUz.Name = "textBoxUz";
            textBoxUz.Size = new Size(331, 30);
            textBoxUz.TabIndex = 4;
            // 
            // labelUz
            // 
            labelUz.AutoSize = true;
            labelUz.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUz.Location = new Point(74, 104);
            labelUz.Name = "labelUz";
            labelUz.Size = new Size(68, 25);
            labelUz.TabIndex = 3;
            labelUz.Text = "Uzbek";
            // 
            // AddWordListView
            // 
            AddWordListView.Columns.AddRange(new ColumnHeader[] { English, Uzbek });
            AddWordListView.FullRowSelect = true;
            AddWordListView.GridLines = true;
            AddWordListView.Location = new Point(22, 168);
            AddWordListView.Name = "AddWordListView";
            AddWordListView.Size = new Size(757, 335);
            AddWordListView.TabIndex = 6;
            AddWordListView.UseCompatibleStateImageBehavior = false;
            AddWordListView.View = View.Details;
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
            // AddWordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 523);
            Controls.Add(AddWordListView);
            Controls.Add(btnRemove);
            Controls.Add(textBoxUz);
            Controls.Add(labelUz);
            Controls.Add(btnAdd);
            Controls.Add(textBoxEng);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddWordForm";
            Text = "AddWordForm";
            Load += AddWordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxEng;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox textBoxUz;
        private Label labelUz;
        private ListView AddWordListView;
        private ColumnHeader English;
        private ColumnHeader Uzbek;
    }
}