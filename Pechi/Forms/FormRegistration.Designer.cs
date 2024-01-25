namespace Pechi.Forms
{
    partial class FormRegistration
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
            BReg = new Button();
            L1 = new Label();
            TBLog = new TextBox();
            TBPass1 = new TextBox();
            L2 = new Label();
            L4 = new Label();
            TBPass2 = new TextBox();
            L3 = new Label();
            SuspendLayout();
            // 
            // BReg
            // 
            BReg.Location = new Point(83, 213);
            BReg.Name = "BReg";
            BReg.Size = new Size(132, 31);
            BReg.TabIndex = 0;
            BReg.Text = "Зарегистрироваться";
            BReg.UseVisualStyleBackColor = true;
            BReg.Click += BReg_Click;
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Location = new Point(128, 69);
            L1.Name = "L1";
            L1.Size = new Size(41, 15);
            L1.TabIndex = 1;
            L1.Text = "Логин";
            // 
            // TBLog
            // 
            TBLog.Location = new Point(83, 87);
            TBLog.Name = "TBLog";
            TBLog.Size = new Size(132, 23);
            TBLog.TabIndex = 2;
            // 
            // TBPass1
            // 
            TBPass1.Location = new Point(12, 155);
            TBPass1.Name = "TBPass1";
            TBPass1.Size = new Size(137, 23);
            TBPass1.TabIndex = 4;
            // 
            // L2
            // 
            L2.AutoSize = true;
            L2.Location = new Point(62, 137);
            L2.Name = "L2";
            L2.Size = new Size(49, 15);
            L2.TabIndex = 3;
            L2.Text = "Пароль";
            // 
            // L4
            // 
            L4.Anchor = AnchorStyles.None;
            L4.AutoSize = true;
            L4.Location = new Point(62, 9);
            L4.Name = "L4";
            L4.Size = new Size(179, 15);
            L4.TabIndex = 5;
            L4.Text = "Регистрация нового работника";
            // 
            // TBPass2
            // 
            TBPass2.Location = new Point(160, 155);
            TBPass2.Name = "TBPass2";
            TBPass2.Size = new Size(137, 23);
            TBPass2.TabIndex = 7;
            // 
            // L3
            // 
            L3.AutoSize = true;
            L3.Location = new Point(160, 137);
            L3.Name = "L3";
            L3.Size = new Size(137, 15);
            L3.TabIndex = 6;
            L3.Text = "Подтверждение пароля";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 256);
            Controls.Add(TBPass2);
            Controls.Add(L3);
            Controls.Add(L4);
            Controls.Add(TBPass1);
            Controls.Add(L2);
            Controls.Add(TBLog);
            Controls.Add(L1);
            Controls.Add(BReg);
            Name = "FormRegistration";
            Text = "FormRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BReg;
        private Label L1;
        private TextBox TBLog;
        private TextBox TBPass1;
        private Label L2;
        private Label L4;
        private TextBox TBPass2;
        private Label L3;
    }
}