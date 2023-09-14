namespace Dictionary.Forms
{
    partial class RememberForm
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
            btnUzEng = new Button();
            btnEngUz = new Button();
            SuspendLayout();
            // 
            // btnUzEng
            // 
            btnUzEng.BackColor = Color.LimeGreen;
            btnUzEng.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUzEng.Location = new Point(257, 142);
            btnUzEng.Name = "btnUzEng";
            btnUzEng.Size = new Size(275, 57);
            btnUzEng.TabIndex = 0;
            btnUzEng.Text = "Uzbek - English";
            btnUzEng.UseVisualStyleBackColor = false;
            btnUzEng.Click += btnUzEng_Click;
            // 
            // btnEngUz
            // 
            btnEngUz.BackColor = Color.Red;
            btnEngUz.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEngUz.Location = new Point(257, 233);
            btnEngUz.Name = "btnEngUz";
            btnEngUz.Size = new Size(275, 57);
            btnEngUz.TabIndex = 1;
            btnEngUz.Text = "English - Uzbek";
            btnEngUz.UseVisualStyleBackColor = false;
            btnEngUz.Click += btnEngUz_Click;
            // 
            // RememberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEngUz);
            Controls.Add(btnUzEng);
            Name = "RememberForm";
            Text = "RememberForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUzEng;
        private Button btnEngUz;
    }
}