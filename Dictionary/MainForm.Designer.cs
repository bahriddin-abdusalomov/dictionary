namespace Dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAddWord = new Button();
            btnSearch = new Button();
            btnRemember = new Button();
            btnExit = new Button();
            btnWordList = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnAddWord
            // 
            btnAddWord.BackColor = Color.FromArgb(0, 192, 0);
            btnAddWord.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddWord.Location = new Point(138, 118);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(203, 57);
            btnAddWord.TabIndex = 0;
            btnAddWord.Text = "Add word";
            btnAddWord.UseVisualStyleBackColor = false;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 192, 192);
            btnSearch.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(138, 200);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(203, 57);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRemember
            // 
            btnRemember.BackColor = Color.FromArgb(255, 128, 128);
            btnRemember.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemember.Location = new Point(138, 370);
            btnRemember.Name = "btnRemember";
            btnRemember.Size = new Size(203, 57);
            btnRemember.TabIndex = 2;
            btnRemember.Text = "Remember";
            btnRemember.UseVisualStyleBackColor = false;
            btnRemember.Click += btnRemember_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(138, 465);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 57);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnWordList
            // 
            btnWordList.BackColor = Color.Yellow;
            btnWordList.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnWordList.Location = new Point(138, 281);
            btnWordList.Name = "btnWordList";
            btnWordList.Size = new Size(203, 57);
            btnWordList.TabIndex = 4;
            btnWordList.Text = "Word list";
            btnWordList.UseVisualStyleBackColor = false;
            btnWordList.Click += btnWordList_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(60, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(60, 370);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(60, 465);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(359, 77);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(259, 386);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(639, 618);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnWordList);
            Controls.Add(btnExit);
            Controls.Add(btnRemember);
            Controls.Add(btnSearch);
            Controls.Add(btnAddWord);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddWord;
        private Button btnSearch;
        private Button btnRemember;
        private Button btnExit;
        private Button btnWordList;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}