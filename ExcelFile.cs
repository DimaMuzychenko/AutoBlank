using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Auto_Blank_3._0
{
    class ExcelFile
    {
        readonly string path = string.Empty;     //обЪявление основных обЪектов и переменных для работы с Excel
        readonly int totalRows;
        readonly int totalColumns;

        List<string> allFields;

        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlRange;

        public ExcelFile(string path)       //конструктор, выполняет базовую инициализацию основных 
                                            //классов, компонентов и переменных для роботы с Excel
        {
            try
            {
                this.path = path;

                xlApp = new Excel.Application();

                xlWorkbook = xlApp.Workbooks.Open(path, 0, false);
            }
            catch
            {
                closeFile();
                this.path = string.Empty;
            }
            finally
            {
                xlWorksheet = xlWorkbook.ActiveSheet;
                xlRange = xlWorksheet.UsedRange;

                totalRows = xlRange.Rows.Count;
                totalColumns = xlRange.Columns.Count;

                allFields = getFields();
            }
        }

        ~ExcelFile()        //деструктор, очищает весь мусор и закрывает процесс
        {
            closeFile();
        }


        public void noIni()
        {
            xlWorkbook.Close();
            xlApp.Quit();
            xlWorkbook = null;
            xlApp = null;
        }

        public List<string> getRecords(int numberOfRow)      //вернуть все записи строки из экселя, номер которой передается в функцию
        {
            List<string> Records = new List<string>();
            for (int colCount = 1; colCount <= totalColumns; colCount++)
            {
                Records.Add(Convert.ToString((xlRange.Cells[numberOfRow, colCount] as Excel.Range).Text));
            }
            return Records;
        }

        public string getRecord(string nameOfField, int numOfRow)         //получить конкретную запись по имени поля и номеру строки
        {
            return Convert.ToString((xlRange.Cells[numOfRow, allFields.IndexOf(nameOfField) + 1] as Excel.Range).Text);
        }




        public List<string> getFields()     //вернуть список полей базы данных
        {
            List<string> fields = new List<string>();
            for (int colCount = 1; colCount <= totalColumns; colCount++)
            {
                fields.Add(Convert.ToString((xlRange.Cells[1, colCount] as Excel.Range).Text));
            }
            return fields;
        }

        public void closeFile()
        {
            xlWorkbook.Close();
            xlApp.Quit();
            GC.Collect();
        }

        public int getTotalRows()
        {
            return totalRows;
        }
    }
}
