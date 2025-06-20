using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pregatirepawexamsub1
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            chart.Series.Clear();
            var series = new Series("Registrations") { ChartType = SeriesChartType.Column };
            var data = DataStore.Registrations
                .GroupBy(r => r.AccessPackageId)
                .Select(g => new {
                    Name = DataStore.AccessPackages.First(p => p.Id == g.Key).Name,
                    Count = g.Count()
                });
            foreach (var item in data)
            {
                series.Points.AddXY(item.Name, item.Count);
            }
            chart.Series.Add(series);
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea());
        }
    }
}