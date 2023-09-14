namespace Dictionary.Forms
{
    partial class UzEngForm
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
            textBoxEng = new TextBox();
            labelEng = new Label();
            label1 = new Label();
            lebelSozTanla = new Label();
            btnKeyingisi = new Button();
            btnTekshirish = new Button();
            labelNatija = new Label();
            btnKorish = new Button();
            btnTakrorlash = new Button();
            btnBoshlash = new Button();
            SuspendLayout();
            // 
            // textBoxEng
            // 
            textBoxEng.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEng.Location = new Point(183, 132);
            textBoxEng.Name = "textBoxEng";
            textBoxEng.Size = new Size(271, 30);
            textBoxEng.TabIndex = 6;
            // 
            // labelEng
            // 
            labelEng.AutoSize = true;
            labelEng.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEng.Location = new Point(88, 131);
            labelEng.Name = "labelEng";
            labelEng.Size = new Size(76, 25);
            labelEng.TabIndex = 5;
            labelEng.Text = "English";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 65);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 7;
            label1.Text = "Uzbek";
            // 
            // lebelSozTanla
            // 
            lebelSozTanla.AutoSize = true;
            lebelSozTanla.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lebelSozTanla.Location = new Point(221, 65);
            lebelSozTanla.Name = "lebelSozTanla";
            lebelSozTanla.Size = new Size(206, 32);
            lebelSozTanla.TabIndex = 8;
            lebelSozTanla.Text = "############";
            // 
            // btnKeyingisi
            // 
            btnKeyingisi.BackColor = Color.LimeGreen;
            btnKeyingisi.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeyingisi.Location = new Point(401, 372);
            btnKeyingisi.Name = "btnKeyingisi";
            btnKeyingisi.Size = new Size(147, 40);
            btnKeyingisi.TabIndex = 9;
            btnKeyingisi.Text = "Keyingisi";
            btnKeyingisi.UseVisualStyleBackColor = false;
            btnKeyingisi.Click += btnKeyingisi_Click;
            // 
            // btnTekshirish
            // 
            btnTekshirish.BackColor = Color.LightSkyBlue;
            btnTekshirish.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTekshirish.Location = new Point(564, 124);
            btnTekshirish.Name = "btnTekshirish";
            btnTekshirish.Size = new Size(147, 40);
            btnTekshirish.TabIndex = 10;
            btnTekshirish.Text = "Tekshirish";
            btnTekshirish.UseVisualStyleBackColor = false;
            btnTekshirish.Click += btnTekshirish_Click;
            // 
            // labelNatija
            // 
            labelNatija.AutoSize = true;
            labelNatija.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNatija.ForeColor = Color.Black;
            labelNatija.Location = new Point(270, 233);
            labelNatija.Name = "labelNatija";
            labelNatija.Size = new Size(224, 35);
            labelNatija.TabIndex = 11;
            labelNatija.Text = ">> Natija <<";
            // 
            // btnKorish
            // 
            btnKorish.BackColor = Color.Red;
            btnKorish.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKorish.Location = new Point(41, 372);
            btnKorish.Name = "btnKorish";
            btnKorish.Size = new Size(302, 40);
            btnKorish.TabIndex = 12;
            btnKorish.Text = "To'g'ri javobni ko'rish";
            btnKorish.UseVisualStyleBackColor = false;
            btnKorish.Click += btnKorish_Click;
            // 
            // btnTakrorlash
            // 
            btnTakrorlash.BackColor = Color.Yellow;
            btnTakrorlash.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakrorlash.Location = new Point(597, 372);
            btnTakrorlash.Name = "btnTakrorlash";
            btnTakrorlash.Size = new Size(147, 40);
            btnTakrorlash.TabIndex = 13;
            btnTakrorlash.Text = "Takrorlash";
            btnTakrorlash.UseVisualStyleBackColor = false;
            btnTakrorlash.Click += btnTakrorlash_Click;
            // 
            // btnBoshlash
            // 
            btnBoshlash.BackColor = Color.LightSkyBlue;
            btnBoshlash.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoshlash.Location = new Point(564, 58);
            btnBoshlash.Name = "btnBoshlash";
            btnBoshlash.Size = new Size(147, 40);
            btnBoshlash.TabIndex = 14;
            btnBoshlash.Text = "Boshlash";
            btnBoshlash.UseVisualStyleBackColor = false;
            btnBoshlash.Click += btnBoshlash_Click;
            // 
            // UzEngForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(794, 421);
            Controls.Add(btnBoshlash);
            Controls.Add(btnTakrorlash);
            Controls.Add(btnKorish);
            Controls.Add(labelNatija);
            Controls.Add(btnTekshirish);
            Controls.Add(btnKeyingisi);
            Controls.Add(lebelSozTanla);
            Controls.Add(label1);
            Controls.Add(textBoxEng);
            Controls.Add(labelEng);
            Name = "UzEngForm";
            Text = "UzEngForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEng;
        private Label labelEng;
        private Label label1;
        private Label lebelSozTanla;
        private Button btnKeyingisi;
        private Button btnTekshirish;
        private Label labelNatija;
        private Button btnKorish;
        private Button btnTakrorlash;
        private Button btnBoshlash;
    }
}