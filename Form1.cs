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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        OpenFileDialog ofd = new OpenFileDialog();
        WordFile wordFile;
        ExcelFile excelFile;
        Form2 form2;

        string wdOriginalPath = string.Empty;
        string wdCatalog = string.Empty;
        string wdBackupPath = string.Empty;
        int wdNumberOfDocs = 0;









        private void wdPathB_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wdPathTB.Text = ofd.FileName;
            }
        }

        private void xlPathB_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                xlPathTB.Text = ofd.FileName;
            }
        }

        private void nextB_Click(object sender, EventArgs e)
        {
            if(canBeOpened(wdPathTB.Text) && canBeOpened(xlPathTB.Text))
            {
                wdOriginalPath = wdPathTB.Text;
                
                wordFile = new WordFile(wdPathTB.Text);
                excelFile = new ExcelFile(xlPathTB.Text);

                wdCatalog = wordFile.getCatalog();

                Info.marks = wordFile.getMarks();
                Info.allFields = excelFile.getFields();
                                
                form2 = new Form2();
                form2.ShowDialog();

                for(int i = 2; i <= excelFile.getTotalRows(); i++)
                {
                    //wordFile.closeFile();
                    proccessNewCopy(i);
                }
                MessageBox.Show(@"Успішно опрацьовано!");
            }




        }



        private void updateBackupPath()
        {
            this.wdNumberOfDocs++;
            wdBackupPath = wdCatalog + @"\doc" + Convert.ToString(wdNumberOfDocs) + @".docx";
        }

        private void cloneFile()
        {
            //wordFile.closeFile();
            //wordFile = null;
            updateBackupPath();
            System.IO.File.Copy(wdOriginalPath, wdBackupPath);
        }

        private void proccessNewCopy(int numOfCopy)
        {
            cloneFile();
            if (canBeOpened(wdBackupPath))
            {
                wordFile.openDoc(wdBackupPath);
                fillRecords(numOfCopy);
                for (int i = 0; i < Info.marks.Count; i++)
                {
                    wordFile.replaceMark(Info.marks[i], Info.records[i]);
                }
                wordFile.saveFile();
                wordFile.closeFile();
                Info.records.Clear();
            }
        }

        private void fillRecords(int numOfRow)
        {
            for(int i = 0; i < Info.fields.Count; i++)
            {
                Info.records.Add(excelFile.getRecord(Info.fields[i],numOfRow));
            }
        }

        private bool canBeOpened(string path)
        {
            System.IO.FileStream a = null;

            try
            {
                a = System.IO.File.Open(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.None);
                return true;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show(@"Файл пошкоджений або вже використовується! Закрийте файл, перш ніж використовувати його у програмі.", @"Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show(@"Оберіть шлях до файлу!", @"Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                if (a != null)
                {
                    a.Close();
                    a.Dispose();
                }
            }
        }

        
    }
}
