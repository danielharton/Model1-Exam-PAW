using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace pregatirepawexamsub1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbSort.SelectedIndex = 0;
            RefreshListView();
            UpdateTotalCost();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new RegistrationForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStore.Registrations.Add(form.Registration);
                ApplySort();
                RefreshListView();
                UpdateTotalCost();
                DataStore.SaveRegistrations();
            }
        }

        private void RefreshListView()
        {
            listView.Items.Clear();
            foreach (var reg in DataStore.Registrations)
            {
                var pkg = DataStore.AccessPackages.Find(p => p.Id == reg.AccessPackageId);
                var cost = (double)reg;
                var item = new ListViewItem(new[] {
                    reg.CompanyName,
                    pkg?.Name ?? "",
                    reg.NoOfPasses.ToString(),
                    cost.ToString("F2")
                })
                { Tag = reg };
                listView.Items.Add(item);
            }
        }

        private void UpdateTotalCost()
        {
            double total = DataStore.Registrations.Sum(r => (double)r);
            toolStripStatusLabel.Text = $"Total: {total:F2}";
        }

        private void miModify_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;
            var reg = (Registration)listView.SelectedItems[0].Tag;
            var form = new RegistrationForm(reg);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplySort();
                RefreshListView();
                UpdateTotalCost();
                DataStore.SaveRegistrations();
            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;
            var reg = (Registration)listView.SelectedItems[0].Tag;
            if (MessageBox.Show("Delete this registration?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataStore.Registrations.Remove(reg);
                RefreshListView();
                UpdateTotalCost();
                DataStore.SaveRegistrations();
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySort();
            RefreshListView();
        }

        private void ApplySort()
        {
            IComparer<Registration> comparer = cmbSort.SelectedIndex == 0
                ? new CompanyComparer() as IComparer<Registration>
                : new PackageComparer() as IComparer<Registration>;
            DataStore.Registrations.Sort(comparer);  
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            var chartForm = new ChartForm();
            chartForm.ShowDialog();
        }
    }

    class CompanyComparer : IComparer<Registration>
    {
        public int Compare(Registration x, Registration y)
            => string.Compare(x.CompanyName, y.CompanyName, StringComparison.Ordinal);
    }

    class PackageComparer : IComparer<Registration>
    {
        public int Compare(Registration x, Registration y)
        {
            var px = DataStore.AccessPackages.Find(p => p.Id == x.AccessPackageId)?.Name;
            var py = DataStore.AccessPackages.Find(p => p.Id == y.AccessPackageId)?.Name;
            return string.Compare(px, py, StringComparison.Ordinal);
        }
    }
}