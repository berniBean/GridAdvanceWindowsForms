using DataGridViewAutoFilter;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://levelup.gitconnected.com/datagridview-autofilter-621f80f71b63
namespace GridAdvance
{
    public partial class Form1 : Form
    {
        private Person personObject = new Person();
        private List<Person> personList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personObject.PopulateList(personList);

            // Use morelinq ToDataTable extension for converting personList to DataTable.
            // Assign the converted Datatable to BindingSource's DataSource.
            personBindingSource.DataSource = personList.ToDataTable();

            //Finally assign personBindingSource to DataGridView's DataSource.
            dataGridView1.DataSource = personBindingSource;

            //Allow data filtering 
            EnableGridFilter(true);
        }

        private void EnableGridFilter(bool value)
        {
            Rank.FilteringEnabled = value;
            Occupation.FilteringEnabled = value;
            Jobs.FilteringEnabled = value;
            Salary.FilteringEnabled = value;
            Rate.FilteringEnabled = value;
            DateTime.FilteringEnabled = value;
        }

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView1);
            if (string.IsNullOrEmpty(filterStatus))
            {
                ShowAllLabel.Visible = false;
                FilterStatusLabel.Visible = false;
            }
            else
            {
                ShowAllLabel.Visible = true;
                FilterStatusLabel.Visible = true;
                FilterStatusLabel.Text = filterStatus;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
            && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            && dataGridView1.CurrentCell != null
            && dataGridView1.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }
    }
}
