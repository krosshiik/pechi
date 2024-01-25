namespace Pechi.Forms
{
    partial class Chart
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
            label4 = new Label();
            pieChart1 = new LiveCharts.WinForms.PieChart();
            BClose = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(10, 572);
            label4.Name = "label4";
            label4.Size = new Size(604, 25);
            label4.TabIndex = 16;
            label4.Text = "Взаимные отношения всех видов простоев за учитываемый период";
            // 
            // pieChart1
            // 
            pieChart1.Location = new Point(101, 16);
            pieChart1.Margin = new Padding(3, 4, 3, 4);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(608, 541);
            pieChart1.TabIndex = 0;
            pieChart1.Text = "pieChart1";
            // 
            // BClose
            // 
            BClose.Location = new Point(620, 564);
            BClose.Margin = new Padding(3, 4, 3, 4);
            BClose.Name = "BClose";
            BClose.Size = new Size(120, 45);
            BClose.TabIndex = 15;
            BClose.Text = "Закрыть";
            BClose.UseVisualStyleBackColor = true;
            BClose.Click += BClose_Click;
            // 
            // Chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 627);
            Controls.Add(pieChart1);
            Controls.Add(BClose);
            Controls.Add(label4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chart";
            Text = "Chart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private Button BClose;
        private Label label4;
        private GroupBox groupBox1;
    }
}