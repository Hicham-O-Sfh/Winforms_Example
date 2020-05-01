using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AllowUserToAddRows = false;

            this.dataGridView1.Rows.Add("Saffih", "Hicham", 22);
            this.dataGridView1.Rows.Add("Adam", "Zakaria", 5);
            this.dataGridView1.Rows.Add("Sqat", "Nisrine", 19);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(3)) // si user a clické sur button
            {
                Details detailForm = new Details
                    (
                    this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                    );
                detailForm.Show();
            }
        }
    }
}
