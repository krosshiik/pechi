namespace Pechi.Forms
{
    partial class FormProstoi
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
            dataGridViewProstoi = new DataGridView();
            CAgregati = new DataGridViewComboBoxColumn();
            agregatiBindingSource = new BindingSource(components);
            времяпростояпланDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            времяпростояфактDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CLitsa = new DataGridViewComboBoxColumn();
            litsaBindingSource = new BindingSource(components);
            CTipi = new DataGridViewComboBoxColumn();
            tipiBindingSource = new BindingSource(components);
            BDelete = new DataGridViewButtonColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDТипаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDАгрегатаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDЛицаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prostoiBindingSource = new BindingSource(components);
            BAddWorker = new Button();
            BExit = new Button();
            BAdd = new Button();
            BGraph = new Button();
            BReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProstoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agregatiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)litsaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prostoiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProstoi
            // 
            dataGridViewProstoi.AutoGenerateColumns = false;
            dataGridViewProstoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProstoi.Columns.AddRange(new DataGridViewColumn[] { CAgregati, времяпростояпланDataGridViewTextBoxColumn, времяпростояфактDataGridViewTextBoxColumn, CLitsa, CTipi, BDelete, iDDataGridViewTextBoxColumn, iDТипаDataGridViewTextBoxColumn, iDАгрегатаDataGridViewTextBoxColumn, iDЛицаDataGridViewTextBoxColumn });
            dataGridViewProstoi.DataSource = prostoiBindingSource;
            dataGridViewProstoi.Location = new Point(14, 16);
            dataGridViewProstoi.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProstoi.Name = "dataGridViewProstoi";
            dataGridViewProstoi.RowHeadersWidth = 51;
            dataGridViewProstoi.Size = new Size(706, 449);
            dataGridViewProstoi.TabIndex = 0;
            dataGridViewProstoi.CellContentClick += dataGridViewProstoi_CellContentClick;
            dataGridViewProstoi.DataError += dataGridViewProstoi_DataError_1;
            // 
            // CAgregati
            // 
            CAgregati.DataPropertyName = "ID_Агрегата";
            CAgregati.DataSource = agregatiBindingSource;
            CAgregati.DisplayMember = "Название_агрегата";
            CAgregati.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            CAgregati.HeaderText = "Агрегат";
            CAgregati.MinimumWidth = 6;
            CAgregati.Name = "CAgregati";
            CAgregati.ValueMember = "ID";
            CAgregati.Width = 125;
            // 
            // agregatiBindingSource
            // 
            agregatiBindingSource.DataSource = typeof(DataBase.Agregati);
            // 
            // времяпростояпланDataGridViewTextBoxColumn
            // 
            времяпростояпланDataGridViewTextBoxColumn.DataPropertyName = "Время_простоя_план";
            времяпростояпланDataGridViewTextBoxColumn.HeaderText = "Время_простоя_план";
            времяпростояпланDataGridViewTextBoxColumn.MinimumWidth = 6;
            времяпростояпланDataGridViewTextBoxColumn.Name = "времяпростояпланDataGridViewTextBoxColumn";
            времяпростояпланDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяпростояфактDataGridViewTextBoxColumn
            // 
            времяпростояфактDataGridViewTextBoxColumn.DataPropertyName = "Время_простоя_факт";
            времяпростояфактDataGridViewTextBoxColumn.HeaderText = "Время_простоя_факт";
            времяпростояфактDataGridViewTextBoxColumn.MinimumWidth = 6;
            времяпростояфактDataGridViewTextBoxColumn.Name = "времяпростояфактDataGridViewTextBoxColumn";
            времяпростояфактDataGridViewTextBoxColumn.Width = 125;
            // 
            // CLitsa
            // 
            CLitsa.DataPropertyName = "ID_Лица";
            CLitsa.DataSource = litsaBindingSource;
            CLitsa.DisplayMember = "Фамилия";
            CLitsa.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            CLitsa.HeaderText = "Ответственное лицо";
            CLitsa.MinimumWidth = 6;
            CLitsa.Name = "CLitsa";
            CLitsa.ValueMember = "ID";
            CLitsa.Width = 125;
            // 
            // litsaBindingSource
            // 
            litsaBindingSource.DataSource = typeof(DataBase.Litsa);
            // 
            // CTipi
            // 
            CTipi.DataPropertyName = "ID_Типа";
            CTipi.DataSource = tipiBindingSource;
            CTipi.DisplayMember = "Название_простоя";
            CTipi.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            CTipi.HeaderText = "Тип простоя";
            CTipi.MinimumWidth = 6;
            CTipi.Name = "CTipi";
            CTipi.ValueMember = "ID";
            CTipi.Width = 125;
            // 
            // tipiBindingSource
            // 
            tipiBindingSource.DataSource = typeof(DataBase.Tipi);
            // 
            // BDelete
            // 
            BDelete.DataPropertyName = "ID";
            BDelete.HeaderText = "Удалить запись";
            BDelete.MinimumWidth = 6;
            BDelete.Name = "BDelete";
            BDelete.Text = "Удалить";
            BDelete.Width = 75;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Visible = false;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDТипаDataGridViewTextBoxColumn
            // 
            iDТипаDataGridViewTextBoxColumn.DataPropertyName = "ID_Типа";
            iDТипаDataGridViewTextBoxColumn.HeaderText = "ID_Типа";
            iDТипаDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDТипаDataGridViewTextBoxColumn.Name = "iDТипаDataGridViewTextBoxColumn";
            iDТипаDataGridViewTextBoxColumn.Visible = false;
            iDТипаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDАгрегатаDataGridViewTextBoxColumn
            // 
            iDАгрегатаDataGridViewTextBoxColumn.DataPropertyName = "ID_Агрегата";
            iDАгрегатаDataGridViewTextBoxColumn.HeaderText = "ID_Агрегата";
            iDАгрегатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDАгрегатаDataGridViewTextBoxColumn.Name = "iDАгрегатаDataGridViewTextBoxColumn";
            iDАгрегатаDataGridViewTextBoxColumn.Visible = false;
            iDАгрегатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDЛицаDataGridViewTextBoxColumn
            // 
            iDЛицаDataGridViewTextBoxColumn.DataPropertyName = "ID_Лица";
            iDЛицаDataGridViewTextBoxColumn.HeaderText = "ID_Лица";
            iDЛицаDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDЛицаDataGridViewTextBoxColumn.Name = "iDЛицаDataGridViewTextBoxColumn";
            iDЛицаDataGridViewTextBoxColumn.Visible = false;
            iDЛицаDataGridViewTextBoxColumn.Width = 125;
            // 
            // prostoiBindingSource
            // 
            prostoiBindingSource.DataSource = typeof(DataBase.Prostoi);
            // 
            // BAddWorker
            // 
            BAddWorker.Location = new Point(727, 16);
            BAddWorker.Margin = new Padding(3, 4, 3, 4);
            BAddWorker.Name = "BAddWorker";
            BAddWorker.Size = new Size(150, 55);
            BAddWorker.TabIndex = 1;
            BAddWorker.Text = "Добавить работника";
            BAddWorker.UseVisualStyleBackColor = true;
            BAddWorker.Click += BAddWorker_Click;
            // 
            // BExit
            // 
            BExit.Location = new Point(727, 419);
            BExit.Margin = new Padding(3, 4, 3, 4);
            BExit.Name = "BExit";
            BExit.Size = new Size(150, 47);
            BExit.TabIndex = 2;
            BExit.Text = "Выход";
            BExit.UseVisualStyleBackColor = true;
            BExit.Click += BExit_Click;
            // 
            // BAdd
            // 
            BAdd.Location = new Point(727, 79);
            BAdd.Margin = new Padding(3, 4, 3, 4);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(150, 55);
            BAdd.TabIndex = 3;
            BAdd.Text = "Добавить простой";
            BAdd.UseVisualStyleBackColor = true;
            BAdd.Click += BAdd_Click;
            // 
            // BGraph
            // 
            BGraph.Location = new Point(727, 142);
            BGraph.Margin = new Padding(3, 4, 3, 4);
            BGraph.Name = "BGraph";
            BGraph.Size = new Size(150, 55);
            BGraph.TabIndex = 4;
            BGraph.Text = "График";
            BGraph.UseVisualStyleBackColor = true;
            BGraph.Click += BGraph_Click;
            // 
            // BReport
            // 
            BReport.Location = new Point(727, 205);
            BReport.Margin = new Padding(3, 4, 3, 4);
            BReport.Name = "BReport";
            BReport.Size = new Size(150, 55);
            BReport.TabIndex = 5;
            BReport.Text = "Создать отчёт";
            BReport.UseVisualStyleBackColor = true;
            BReport.Click += BReport_Click_1;
            // 
            // FormProstoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 480);
            Controls.Add(BReport);
            Controls.Add(BGraph);
            Controls.Add(BAdd);
            Controls.Add(BExit);
            Controls.Add(BAddWorker);
            Controls.Add(dataGridViewProstoi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProstoi";
            Text = "FormProstoi";
            FormClosed += FormProstoi_FormClosed;
            Load += FormProstoi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProstoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)agregatiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)litsaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)prostoiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProstoi;
        private Button BAddWorker;
        private Button BExit;
        private DataGridViewTextBoxColumn датаокончанияпростояDataGridViewTextBoxColumn;
        private Button BAdd;
        private Button BGraph;
        private Button BReport;
        private BindingSource litsaBindingSource;
        private BindingSource prostoiBindingSource;
        private BindingSource agregatiBindingSource;
        private BindingSource tipiBindingSource;
        private DataGridViewComboBoxColumn CAgregati;
        private DataGridViewTextBoxColumn времяпростояпланDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn времяпростояфактDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn CLitsa;
        private DataGridViewComboBoxColumn CTipi;
        private DataGridViewButtonColumn BDelete;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDТипаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDАгрегатаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDЛицаDataGridViewTextBoxColumn;
    }
}