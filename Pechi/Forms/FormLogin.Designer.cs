namespace Pechi.Forms
{
    partial class FormLogin
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
            L3 = new Label();
            TBPass = new TextBox();
            L2 = new Label();
            TBLog = new TextBox();
            L1 = new Label();
            BLog = new Button();
            L4 = new Label();
            SuspendLayout();
            // 
            // L3
            // 
            L3.Anchor = AnchorStyles.None;
            L3.AutoSize = true;
            L3.Location = new Point(85, 9);
            L3.Name = "L3";
            L3.Size = new Size(135, 15);
            L3.TabIndex = 13;
            L3.Text = "Авторизация в системе";
            // 
            // TBPass
            // 
            TBPass.Location = new Point(85, 157);
            TBPass.Name = "TBPass";
            TBPass.Size = new Size(132, 23);
            TBPass.TabIndex = 12;
            // 
            // L2
            // 
            L2.AutoSize = true;
            L2.Location = new Point(135, 139);
            L2.Name = "L2";
            L2.Size = new Size(49, 15);
            L2.TabIndex = 11;
            L2.Text = "Пароль";
            // 
            // TBLog
            // 
            TBLog.Location = new Point(85, 89);
            TBLog.Name = "TBLog";
            TBLog.Size = new Size(132, 23);
            TBLog.TabIndex = 10;
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Location = new Point(130, 71);
            L1.Name = "L1";
            L1.Size = new Size(41, 15);
            L1.TabIndex = 9;
            L1.Text = "Логин";
            // 
            // BLog
            // 
            BLog.Location = new Point(85, 215);
            BLog.Name = "BLog";
            BLog.Size = new Size(132, 31);
            BLog.TabIndex = 8;
            BLog.Text = "Войти";
            BLog.UseVisualStyleBackColor = true;
            BLog.Click += BLog_Click;
            // 
            // L4
            // 
            L4.Anchor = AnchorStyles.None;
            L4.AutoSize = true;
            L4.Location = new Point(30, 24);
            L4.Name = "L4";
            L4.Size = new Size(245, 15);
            L4.TabIndex = 16;
            L4.Text = "учета простоев технологических агрегатов";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 256);
            Controls.Add(L4);
            Controls.Add(L3);
            Controls.Add(TBPass);
            Controls.Add(L2);
            Controls.Add(TBLog);
            Controls.Add(L1);
            Controls.Add(BLog);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L3;
        private TextBox TBPass;
        private Label L2;
        private TextBox TBLog;
        private Label L1;
        private Button BLog;
        private Label L4;
    }
}