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
    public partial class dodaj : Form
    {
        public Form1 f1 = new Form1();
        //public DataSet dataSet1;

        public dodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr;

            dr = f1.dataSet1.Tables["Table1"].NewRow();
            dr["imie"] = textBox1.Text;
            dr["nazwisko"] = textBox2.Text;
            dr["indeks"] = textBox3.Text;
            if (radioButton2.Checked)
                dr["Zgoda"] = "nie";
            else
                dr["Zgoda"] = "tak";
            
            f1.dataSet1.Tables["Table1"].Rows.Add(dr);

            f1.dataSet1.AcceptChanges();
            //f1.dataGridView1.Update();
            f1.dataGridView1.Refresh();
            f1.dataSet1.WriteXml("dane.xml");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
    }
}
