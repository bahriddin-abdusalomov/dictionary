namespace Dictionary.Forms
{
    partial class EngUzForm
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
            btnBoshlash = new Button();
            btnRepeat = new Button();
            btnKorish = new Button();
            labelNatija = new Label();
            btnTekshirish = new Button();
            btnKeyingisi = new Button();
            lebelSozTanla = new Label();
            label1 = new Label();
            textBoxUz = new TextBox();
            labelEng = new Label();
            SuspendLayout();
            // 
            // btnBoshlash
            // 
            btnBoshlash.BackColor = Color.LightSkyBlue;
            btnBoshlash.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoshlash.Location = new Point(572, 48);
            btnBoshlash.Name = "btnBoshlash";
            btnBoshlash.Size = new Size(147, 40);
            btnBoshlash.TabIndex = 24;
            btnBoshlash.Text = "Start";
            btnBoshlash.UseVisualStyleBackColor = false;
            btnBoshlash.Click += btnBoshlash_Click;
            // 
            // btnRepeat
            // 
            btnRepeat.BackColor = Color.Yellow;
            btnRepeat.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRepeat.Location = new Point(605, 362);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(147, 40);
            btnRepeat.TabIndex = 23;
            btnRepeat.Text = "Repeat";
            btnRepeat.UseVisualStyleBackColor = false;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnKorish
            // 
            btnKorish.BackColor = Color.Red;
            btnKorish.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKorish.Location = new Point(49, 362);
            btnKorish.Name = "btnKorish";
            btnKorish.Size = new Size(302, 40);
            btnKorish.TabIndex = 22;
            btnKorish.Text = "Show answer";
            btnKorish.UseVisualStyleBackColor = false;
            btnKorish.Click += btnKorish_Click;
            // 
            // labelNatija
            // 
            labelNatija.AutoSize = true;
            labelNatija.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNatija.Location = new Point(293, 218);
            labelNatija.Name = "labelNatija";
            labelNatija.Size = new Size(228, 35);
            labelNatija.TabIndex = 21;
            labelNatija.Text = ">> Result <<";
            // 
            // btnTekshirish
            // 
            btnTekshirish.BackColor = Color.LightSkyBlue;
            btnTekshirish.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTekshirish.Location = new Point(572, 114);
            btnTekshirish.Name = "btnTekshirish";
            btnTekshirish.Size = new Size(147, 40);
            btnTekshirish.TabIndex = 20;
            btnTekshirish.Text = "Check";
            btnTekshirish.UseVisualStyleBackColor = false;
            btnTekshirish.Click += btnTekshirish_Click;
            // 
            // btnKeyingisi
            // 
            btnKeyingisi.BackColor = Color.LimeGreen;
            btnKeyingisi.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeyingisi.Location = new Point(409, 362);
            btnKeyingisi.Name = "btnKeyingisi";
            btnKeyingisi.Size = new Size(147, 40);
            btnKeyingisi.TabIndex = 19;
            btnKeyingisi.Text = "Next";
            btnKeyingisi.UseVisualStyleBackColor = false;
            btnKeyingisi.Click += btnKeyingisi_Click;
            // 
            // lebelSozTanla
            // 
            lebelSozTanla.AutoSize = true;
            lebelSozTanla.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lebelSozTanla.Location = new Point(229, 55);
            lebelSozTanla.Name = "lebelSozTanla";
            lebelSozTanla.Size = new Size(206, 32);
            lebelSozTanla.TabIndex = 18;
            lebelSozTanla.Text = "############";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 17;
            label1.Text = "English";
            // 
            // textBoxUz
            // 
            textBoxUz.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUz.Location = new Point(191, 122);
            textBoxUz.Name = "textBoxUz";
            textBoxUz.Size = new Size(271, 30);
            textBoxUz.TabIndex = 16;
            textBoxUz.TextChanged += textBoxUz_TextChanged;
            // 
            // labelEng
            // 
            labelEng.AutoSize = true;
            labelEng.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEng.Location = new Point(96, 121);
            labelEng.Name = "labelEng";
            labelEng.Size = new Size(68, 25);
            labelEng.TabIndex = 15;
            labelEng.Text = "Uzbek";
            // 
            // EngUzForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(794, 416);
            Controls.Add(btnBoshlash);
            Controls.Add(btnRepeat);
            Controls.Add(btnKorish);
            Controls.Add(labelNatija);
            Controls.Add(btnTekshirish);
            Controls.Add(btnKeyingisi);
            Controls.Add(lebelSozTanla);
            Controls.Add(label1);
            Controls.Add(textBoxUz);
            Controls.Add(labelEng);
            Name = "EngUzForm";
            Text = "EngUzForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBoshlash;
        private Button btnRepeat;
        private Button btnKorish;
        private Label labelNatija;
        private Button btnTekshirish;
        private Button btnKeyingisi;
        private Label lebelSozTanla;
        private Label label1;
        private TextBox textBoxUz;
        private Label labelEng;
    }
}