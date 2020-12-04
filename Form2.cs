using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Blank_3._0
{
    public partial class Form2 : Form
    {
        int numOfCall = 1;


        public Form2()
        {
            InitializeComponent();
            updateForm();            
        }

        private void updateForm()
        {
            markTB.Text = Info.marks[numOfCall - 1];
            fieldCB.DataSource = Info.allFields;
        }




        private void nextB_Click(object sender, EventArgs e)
        {
            Info.fields.Add(fieldCB.Text);
            if(numOfCall < Info.marks.Count)
            {
                numOfCall++;
            }
            else
            {
                string message = string.Empty;
                for(int i = 0; i < Info.marks.Count; i++)
                {
                    message += Info.marks[i] + " = " + Info.fields[i] + " ||\n ";
                }
                MessageBox.Show(message);
                this.Close();
            }
            updateForm();
        }











    }
}
