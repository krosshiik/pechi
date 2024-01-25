using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace Pechi.Forms
{
    public partial class Chart : Form
    {
        Context context = new();

        public Chart()
        {
            InitializeComponent();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            int count = context.Типы_простоев.Count();
            pieChart1.Series = new SeriesCollection();
            for (int i = 1; i <= count; i++)
            {
                var a = new PieSeries
                {
                    Title = context.Типы_простоев.
                    FirstOrDefault(x => x.ID == i).Название_простоя,
                    Values = new ChartValues<int> {
                        context.Простои.Where(x => x.ID_Типа == i).Count()
                    },
                    PushOut = 1,
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                pieChart1.Series.Add(a);
            }

            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}