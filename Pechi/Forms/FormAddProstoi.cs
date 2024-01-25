using Microsoft.EntityFrameworkCore;
using Pechi.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pechi.Forms
{
    public partial class FormAddProstoi : Form
    {
        Context DBcontext = new();
        public FormAddProstoi()
        {
            InitializeComponent();

            DBcontext = new Context();
            DBcontext.Технологические_агрегаты.Load();
            DBcontext.Типы_простоев.Load();

            var persons = DBcontext.Ответственные_лица.ToList();
            List<Tuple<int,string>> datasource = new();
            foreach ( var person in persons)
            {
                var tuple = Tuple.Create(person.ID, $"{person.Фамилия.Trim(' ')} {person.Имя[0]}.{person.Отчество[0]}.");
                datasource.Add(tuple);
            }

            CBAgregati.DataSource = DBcontext.Технологические_агрегаты.Local.ToBindingList();
            CBAgregati.DisplayMember = "Название_агрегата";
            CBAgregati.ValueMember = "ID";

            CBLitsa.DataSource = datasource;
            CBLitsa.DisplayMember = "Item2";
            CBLitsa.ValueMember = "Item1";

            CBTipi.DataSource = DBcontext.Типы_простоев.Local.ToBindingList();
            CBTipi.DisplayMember = "Название_простоя";
            CBTipi.ValueMember = "ID";
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            if (CBAgregati.SelectedValue != null
                && CBLitsa.SelectedValue != null
                && CBTipi.SelectedValue != null)
            {
                Prostoi toadd = new Prostoi
                {
                    ID_Агрегата = (int)CBAgregati.SelectedValue,
                    ID_Лица = (int)CBLitsa.SelectedValue,
                    ID_Типа = (int)CBTipi.SelectedValue,
                    Дата_начала_простоя = DTPNachalo.Value,
                    Дата_окончания_простоя_план = DTPKonecPl.Value,
                    Дата_окончания_простоя_факт = DTPKonecFact.Value,
                    Время_простоя_план = null,
                    Время_простоя_факт = null
                };
                if (TBopis.Text.Length > 0)
                {
                    toadd.Описание = TBopis.Text;
                }
                DBcontext.Add(toadd);
                DBcontext.SaveChanges();

                MessageBox.Show("Запись успешно добавлена", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.formProstoi.UpdateGataGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Рано",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
