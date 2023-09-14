namespace Dictionary.Forms
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            textBoxSentence = new TextBox();
            btnSend = new Button();
            labelTranlate = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSkyBlue;
            btnSearch.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(551, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(135, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(331, 30);
            textBoxSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 210);
            label1.Name = "label1";
            label1.Size = new Size(299, 18);
            label1.TabIndex = 5;
            label1.Text = "A sentence or text related to this word.";
            // 
            // textBoxSentence
            // 
            textBoxSentence.Font = new Font("MS Reference Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSentence.Location = new Point(62, 249);
            textBoxSentence.Multiline = true;
            textBoxSentence.Name = "textBoxSentence";
            textBoxSentence.Size = new Size(702, 197);
            textBoxSentence.TabIndex = 6;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightSkyBlue;
            btnSend.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(618, 456);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(146, 40);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // labelTranlate
            // 
            labelTranlate.AutoSize = true;
            labelTranlate.Font = new Font("Mongolian Baiti", 15.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTranlate.ForeColor = Color.Red;
            labelTranlate.Location = new Point(205, 129);
            labelTranlate.Name = "labelTranlate";
            labelTranlate.Size = new Size(192, 29);
            labelTranlate.TabIndex = 8;
            labelTranlate.Text = "** translate **";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(802, 500);
            Controls.Add(labelTranlate);
            Controls.Add(btnSend);
            Controls.Add(textBoxSentence);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private TextBox textBoxSentence;
        private Button btnSend;
        private Label labelTranlate;
    }
}