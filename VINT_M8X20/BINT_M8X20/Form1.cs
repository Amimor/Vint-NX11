using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BINT_M12X40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(8, 13, 5, 20, "1.6", "0.4", 2.5, 2.10);
            dataGridView1.Rows.Add(10, 16, 6, 30, "1.6", "0.4", 3, 2.70);
            dataGridView1.Rows.Add(12, 18, 7, 40, "1.6", "0.6", 3.5, 3.10);
            dataGridView1.Rows.Add(14, 21, 8, 50, "2", "0.6", 3.8, 3.15);
            dataGridView1.Rows.Add(16, 24, 9, 60, "2", "0.6", 4, 4.15);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Item = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < 6; i++)
            {
                string value = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                if (Item == value)
                {
                    /*Program.d = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    Program.D = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    Program.k = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    Program.L = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    Program.F = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    Program.r = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    Program.h = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    Program.b = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);*/
                    
                }
            }
            Close();
        }
    }
}
