using FastReport;
using FastReport.Export.Image;
using FastReport.Export.PdfSimple;
using Microsoft.EntityFrameworkCore;
using Pechi.DataBase;
using Pechi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pechi.Forms
{
    public partial class FormProstoi : Form
    {
        public Context context = new();

        public FormProstoi()
        {
            InitializeComponent();
            context.Ответственные_лица.Load();
            context.Типы_простоев.Load();
            context.Технологические_агрегаты.Load();
            context.Простои.Load();
        }

        private void BAddWorker_Click(object sender, EventArgs e)
        {
            var formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formLogin.Show();
        }

        private void FormProstoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formLogin.Close();
        }
        private void Delete(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var c = (int)dataGridViewProstoi.Rows[index].Cells[6].Value;

            var toDelete = context.Простои.FirstOrDefault(x => x.ID == c);
            if (toDelete != null)
            {
                context.Remove(toDelete);
                context.SaveChanges();
                MessageBox.Show($"Успешно удалена запись номер {c}");
            }
            else
            {
                MessageBox.Show("Ошибка удаления, выбрана пустая строка",
                    "не-а", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridViewProstoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                Delete(e);
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            var formAddProstoi = new FormAddProstoi();
            formAddProstoi.Show();
        }

        public void UpdateGataGrid()
        {
            context = new Context();

            context.Ответственные_лица.Load();
            context.Типы_простоев.Load();
            context.Технологические_агрегаты.Load();
            context.Простои.Load();

            CAgregati.DataSource = context.Технологические_агрегаты.Local.ToBindingList();
            CTipi.DataSource = context.Типы_простоев.Local.ToBindingList();
            CLitsa.DataSource = context.Ответственные_лица.Local.ToBindingList();
            var ds = context.Простои.Local.ToBindingList;
            dataGridViewProstoi.DataSource = ds();
        }

        private void FormProstoi_Load(object sender, EventArgs e)
        {
            CAgregati.DataSource = context.Технологические_агрегаты.Local.ToBindingList();
            CTipi.DataSource = context.Типы_простоев.Local.ToBindingList();
            CLitsa.DataSource = context.Ответственные_лица.Local.ToBindingList();
            var ds = context.Простои.Local.ToBindingList;
            dataGridViewProstoi.DataSource = ds();
        }

        private void dataGridViewProstoi_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void BGraph_Click(object sender, EventArgs e)
        {
            var chartForm = new Chart();
            chartForm.Show();
        }

        private void BReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                using Report report = new Report();

                report.Load("report.frx");

                var prostoi = context.Простои.ToList();
                var tipi = context.Типы_простоев.ToList();
                var litsa = context.Ответственные_лица.ToList();
                var agregati = context.Технологические_агрегаты.ToList();

                List<ReportImportModel> toimports = new();

                foreach (var item in prostoi)
                {
                    var litso = litsa.FirstOrDefault(x => x.ID == item.ID_Лица);

                    string fio;
                    if (litso.Отчество != null)
                    {
                        fio = litso.Фамилия.Trim(' ')+ " " + litso.Имя[0] + "." + litso.Отчество[0] + ".";
                    }
                    else
                    {
                        fio = fio = litso.Фамилия + litso.Имя[0];
                    }

                    ReportImportModel zapis = new ReportImportModel
                    {
                        AgregatID = item.ID_Агрегата,
                        AgregatName = agregati.FirstOrDefault(x => x.ID == item.ID_Агрегата).Название_агрегата,
                        ProstoiName = tipi.FirstOrDefault(x => x.ID == item.ID_Типа).Название_простоя,
                        Litso = fio,
                        ProstoiPlan = item.Время_простоя_план,
                        ProstoiFact = item.Время_простоя_факт
                    };
                    toimports.Add(zapis);
                }

                report.RegisterData(toimports, "toimports");
                report.Prepare();
                report.SavePrepared("Prepared_report.frx");

                if (!Directory.Exists("reports"))
                {
                    Directory.CreateDirectory("reports");
                }

                ImageExport image = new ImageExport();
                image.ImageFormat = ImageExportFormat.Jpeg;
                report.Export(image, $"reports\\{DateTime.Now.ToString("yyyy-MM-dd HH-mm ")}report.jpg");
                //
                PDFSimpleExport pdfExport = new PDFSimpleExport();
                pdfExport.Export(report, $"reports\\{DateTime.Now.ToString("yyyy-MM-dd HH-mm ")}report.pdf");
                //
                report.Dispose();

                var reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reports");
                var startInfo = new ProcessStartInfo();
                startInfo.FileName = "explorer.exe";
                startInfo.Arguments = $"{reportDirectory}";

                Process exeProcess = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
