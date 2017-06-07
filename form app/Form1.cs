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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1.ReadXml("dane.xml"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml("dane.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj df = new dodaj();
            df.f1 = this;
            df.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edytuj ef = new edytuj();
                ef.f1 = this;
                ef.ShowDialog();
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    dataSet1.Tables[0].Rows[dataGridView1.SelectedRows[i].Index].Delete();
                    dataSet1.AcceptChanges();
                    dataGridView1.Update();
                }
                dataSet1.WriteXml("dane.xml");
            }
        }
    }
}
