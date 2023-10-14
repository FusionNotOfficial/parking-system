using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMS
{
    public partial class Sections : Form
    {
        Functions Con;
        int Key = 0;
        public Sections()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSections();
        }
        private void ShowSections()
        {
            string Query = "SELECT * FROM SectionTbl";
            SectionList.DataSource = Con.GetData(Query);
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            var window = new Sections();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (sNameTb.Texts == "" || CostTb.Texts == "" || CapacityTb.Texts == "" || DescTb.Texts == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = sNameTb.Texts;
                    string Cap = CapacityTb.Texts;
                    string Cost = CostTb.Texts;
                    string Desc = DescTb.Texts;
                    string Query = "INSERT INTO SectionTbl values('{0}', {1}, {2}, '{3}')";
                    Query = string.Format(Query, Name, Cap, Cost, Desc);
                    Con.SetData(Query);
                    MessageBox.Show("Section Added");
                    ShowSections();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SectionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sNameTb.Texts = SectionList.SelectedRows[0].Cells[1].Value.ToString();
            CapacityTb.Texts = SectionList.SelectedRows[0].Cells[2].Value.ToString();
            CostTb.Texts = SectionList.SelectedRows[0].Cells[3].Value.ToString();
            DescTb.Texts = SectionList.SelectedRows[0].Cells[4].Value.ToString();
            if (sNameTb.Texts == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SectionList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Section!");
            }
            else
            {
                try
                {
                    string Name = sNameTb.Texts;
                    string Cap = CapacityTb.Texts;
                    string Cost = CostTb.Texts;
                    string Desc = DescTb.Texts;
                    string Query = "DELETE FROM SectionTbl WHERE SCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Section Deleted!");
                    ShowSections();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (sNameTb.Texts == "" || CostTb.Texts == "" || CapacityTb.Texts == "" || DescTb.Texts == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Name = sNameTb.Texts;
                    string Cap = CapacityTb.Texts;
                    string Cost = CostTb.Texts;
                    string Desc = DescTb.Texts;
                    string Query = "UPDATE SectionTbl SET SName = '{0}', Capacity = '{1}', Cost = {2}, Description = '{3}' WHERE SCode = {4}";
                    Query = string.Format(Query, Name, Cap, Cost, Desc, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Section Updated");
                    ShowSections();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
