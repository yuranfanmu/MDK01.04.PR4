namespace MDK01._04.PR4
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
            label1 = new Label();
            btnSwap = new Button();
            panel1 = new Panel();
            rbENG = new RadioButton();
            rbRU = new RadioButton();
            label2 = new Label();
            cbxNum = new CheckBox();
            cbxCaps = new CheckBox();
            cbxScroll = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 151);
            label1.TabIndex = 0;
            label1.Text = "Наведите сюда, чтобы скрыть указатель мыши";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // btnSwap
            // 
            btnSwap.Location = new Point(214, 9);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(574, 151);
            btnSwap.TabIndex = 1;
            btnSwap.Text = "Поменять кнопки мыши местами";
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += btnSwap_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbENG);
            panel1.Controls.Add(rbRU);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 125);
            panel1.TabIndex = 2;
            // 
            // rbENG
            // 
            rbENG.AutoSize = true;
            rbENG.Location = new Point(13, 72);
            rbENG.Name = "rbENG";
            rbENG.Size = new Size(113, 24);
            rbENG.TabIndex = 1;
            rbENG.Text = "Английский";
            rbENG.UseVisualStyleBackColor = true;
            rbENG.CheckedChanged += rbRU_CheckedChanged;
            // 
            // rbRU
            // 
            rbRU.AutoSize = true;
            rbRU.Checked = true;
            rbRU.Location = new Point(13, 42);
            rbRU.Name = "rbRU";
            rbRU.Size = new Size(84, 24);
            rbRU.TabIndex = 1;
            rbRU.TabStop = true;
            rbRU.Text = "Русский";
            rbRU.UseVisualStyleBackColor = true;
            rbRU.CheckedChanged += rbRU_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 0;
            label2.Text = "Язык раскладки";
            // 
            // cbxNum
            // 
            cbxNum.AutoSize = true;
            cbxNum.Location = new Point(214, 166);
            cbxNum.Name = "cbxNum";
            cbxNum.Size = new Size(93, 24);
            cbxNum.TabIndex = 2;
            cbxNum.Text = "NumLock";
            cbxNum.UseVisualStyleBackColor = true;
            cbxNum.CheckedChanged += cbx_CheckedChanged;
            // 
            // cbxCaps
            // 
            cbxCaps.AutoSize = true;
            cbxCaps.Location = new Point(214, 196);
            cbxCaps.Name = "cbxCaps";
            cbxCaps.Size = new Size(93, 24);
            cbxCaps.TabIndex = 2;
            cbxCaps.Text = "CapsLock";
            cbxCaps.UseVisualStyleBackColor = true;
            cbxCaps.CheckedChanged += cbx_CheckedChanged;
            // 
            // cbxScroll
            // 
            cbxScroll.AutoSize = true;
            cbxScroll.Location = new Point(214, 226);
            cbxScroll.Name = "cbxScroll";
            cbxScroll.Size = new Size(98, 24);
            cbxScroll.TabIndex = 2;
            cbxScroll.Text = "ScrollLock";
            cbxScroll.UseVisualStyleBackColor = true;
            cbxScroll.CheckedChanged += cbx_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 302);
            Controls.Add(cbxScroll);
            Controls.Add(cbxCaps);
            Controls.Add(cbxNum);
            Controls.Add(panel1);
            Controls.Add(btnSwap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSwap;
        private Panel panel1;
        private RadioButton rbENG;
        private RadioButton rbRU;
        private Label label2;
        private CheckBox cbxNum;
        private CheckBox cbxCaps;
        private CheckBox cbxScroll;
    }
}
