namespace Pechi.Forms
{
    partial class FormAddProstoi
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
            components = new System.ComponentModel.Container();
            CBAgregati = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CBLitsa = new ComboBox();
            DTPNachalo = new DateTimePicker();
            DTPKonecPl = new DateTimePicker();
            DTPKonecFact = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBopis = new RichTextBox();
            label7 = new Label();
            agregatiBindingSource = new BindingSource(components);
            BApply = new Button();
            CBTipi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)agregatiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CBAgregati
            // 
            CBAgregati.FormattingEnabled = true;
            CBAgregati.Location = new Point(10, 30);
            CBAgregati.Name = "CBAgregati";
            CBAgregati.Size = new Size(121, 23);
            CBAgregati.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Агрегат";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Тип простоя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "Ответственное лицо";
            // 
            // CBLitsa
            // 
            CBLitsa.FormattingEnabled = true;
            CBLitsa.Location = new Point(12, 152);
            CBLitsa.Name = "CBLitsa";
            CBLitsa.Size = new Size(121, 23);
            CBLitsa.TabIndex = 4;
            // 
            // DTPNachalo
            // 
            DTPNachalo.Location = new Point(154, 30);
            DTPNachalo.Name = "DTPNachalo";
            DTPNachalo.Size = new Size(200, 23);
            DTPNachalo.TabIndex = 6;
            // 
            // DTPKonecPl
            // 
            DTPKonecPl.Location = new Point(154, 88);
            DTPKonecPl.Name = "DTPKonecPl";
            DTPKonecPl.Size = new Size(200, 23);
            DTPKonecPl.TabIndex = 7;
            // 
            // DTPKonecFact
            // 
            DTPKonecFact.Location = new Point(154, 152);
            DTPKonecFact.Name = "DTPKonecFact";
            DTPKonecFact.Size = new Size(200, 23);
            DTPKonecFact.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 9);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 9;
            label4.Text = "Дата начала простоя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 67);
            label5.Name = "label5";
            label5.Size = new Size(173, 15);
            label5.TabIndex = 10;
            label5.Text = "Плановое окончание простоя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 131);
            label6.Name = "label6";
            label6.Size = new Size(189, 15);
            label6.TabIndex = 11;
            label6.Text = "Фактическое окончание простоя";
            // 
            // TBopis
            // 
            TBopis.Location = new Point(372, 30);
            TBopis.Name = "TBopis";
            TBopis.Size = new Size(276, 182);
            TBopis.TabIndex = 12;
            TBopis.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 9);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 13;
            label7.Text = "Описание";
            // 
            // agregatiBindingSource
            // 
            agregatiBindingSource.DataSource = typeof(DataBase.Agregati);
            // 
            // BApply
            // 
            BApply.Location = new Point(249, 178);
            BApply.Name = "BApply";
            BApply.Size = new Size(105, 34);
            BApply.TabIndex = 14;
            BApply.Text = "Записать";
            BApply.UseVisualStyleBackColor = true;
            BApply.Click += BApply_Click;
            // 
            // CBTipi
            // 
            CBTipi.FormattingEnabled = true;
            CBTipi.Location = new Point(12, 88);
            CBTipi.Name = "CBTipi";
            CBTipi.Size = new Size(121, 23);
            CBTipi.TabIndex = 15;
            // 
            // FormAddProstoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 224);
            Controls.Add(CBTipi);
            Controls.Add(BApply);
            Controls.Add(label7);
            Controls.Add(TBopis);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DTPKonecFact);
            Controls.Add(DTPKonecPl);
            Controls.Add(DTPNachalo);
            Controls.Add(label3);
            Controls.Add(CBLitsa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CBAgregati);
            Name = "FormAddProstoi";
            Text = "FormAddProstoi";
            ((System.ComponentModel.ISupportInitialize)agregatiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBAgregati;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CBLitsa;
        private BindingSource agregatiBindingSource;
        private DateTimePicker DTPNachalo;
        private DateTimePicker DTPKonecPl;
        private DateTimePicker DTPKonecFact;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox TBopis;
        private Label label7;
        private Button BApply;
        private ComboBox CBTipi;
    }
}