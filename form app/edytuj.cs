using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class edytuj : Form
    {
        public Form1 f1 = new Form1();

        public edytuj()
        {
            InitializeComponent();
        }

        private void edytuj_Load(object sender, EventArgs e)
        {
            if (f1.dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = (string)f1.dataGridView1.SelectedRows[0].Cells[1].Value;
                textBox2.Text = (string)f1.dataGridView1.SelectedRows[0].Cells[2].Value;
                textBox3.Text = (string)f1.dataGridView1.SelectedRows[0].Cells[3].Value;
                if ((string)f1.dataGridView1.SelectedRows[0].Cells[3].Value == "tak")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (f1.dataGridView1.SelectedRows.Count > 0)
            {
                DataRow dr;
                f1.dataGridView1.SelectedRows[0].Cells[1].Value = textBox1.Text;
                f1.dataGridView1.SelectedRows[0].Cells[2].Value = textBox2.Text;
                f1.dataGridView1.SelectedRows[0].Cells[3].Value = textBox3.Text;
                if (radioButton2.Checked)
                    f1.dataGridView1.SelectedRows[0].Cells[4].Value = "nie";
                else
                    f1.dataGridView1.SelectedRows[0].Cells[4].Value = "tak";

                f1.dataSet1.AcceptChanges();
                //f1.dataGridView1.Update();
                f1.dataGridView1.Refresh();
                f1.dataSet1.WriteXml("dane.xml");

            }
        }
    }
}
