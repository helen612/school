using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using school.Tables;

namespace school
{
    class workWithDocs
    {
        public bool CreateStatementsChange(string docName, Person person)
        {
            byte[] fileContent;
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {

                var workSheet = package.Workbook.Worksheets.Add("Documet");
                workSheet.Cells["A1:I40"].Style.Font.Size = 14;
                workSheet.Cells["A1:I40"].Style.Font.Name = "Times New Roman";

                #region head

                workSheet.Cells["A1:I1"].Merge = true;
                workSheet.Cells["A1:I1"].Value = "ГУО \"Средняя школа №1 г.Борисова\"";
                workSheet.Cells["A1:I1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                #endregion

                #region Отчет
                workSheet.Cells["A10:I11"].Merge = true;
                workSheet.Cells["A10:I11"].Value = "ОТЧЁТ";
                workSheet.Cells["A10:I11"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A10:I11"].Style.Font.Bold = true;

                workSheet.Cells["A12:I12"].Merge = true;
                workSheet.Cells["A12:I12"].Value = "по учебной работе класса 1А";
                workSheet.Cells["A12:I12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A13:I13"].Merge = true;
                workSheet.Cells["A13:I13"].Value = "за период от 04.11.2022 по 04.12.2022";
                workSheet.Cells["A13:I13"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                #endregion

                #region кол-во
                workSheet.Cells["A17:I17"].Merge = true;
                workSheet.Cells["A17:I17"].Value = "Количество учащихся в классе: 21";
                workSheet.Cells["A17:I17"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                
                workSheet.Cells["A19:I20"].Merge = true;
                workSheet.Cells["A19:I20"].Value = "За установленный период в классе 1А среди учеников можно выделить список отличников:";
                workSheet.Cells["A19:I20"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A19:I20"].Style.WrapText = true;

                workSheet.Cells["A21:I22"].Merge = true;
                workSheet.Cells["A21:I22"].Value = "Отличники";
                workSheet.Cells["A21:I22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A24:I24"].Merge = true;
                workSheet.Cells["A24:I24"].Value = "Среди отстающих:";
                workSheet.Cells["A24:I24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A25:I26"].Merge = true;
                workSheet.Cells["A25:I26"].Value = "отстающие";
                workSheet.Cells["A25:I26"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A28:I28"].Merge = true;
                workSheet.Cells["A28:I28"].Value = "Самый активный участник мероприятий: ";
                workSheet.Cells["A28:I28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A29:I29"].Merge = true;
                workSheet.Cells["A29:I29"].Value = "Активист";
                workSheet.Cells["A29:I29"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                #endregion

                #region подписи
                workSheet.Cells["A34:D34"].Merge = true;
                workSheet.Cells["A34:D34"].Value = "Классный руководитель";
                workSheet.Cells["A34:D34"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["C35:E35"].Merge = true;
                workSheet.Cells["C35:E35"].Value = "Пашкевич Е. Е.";
                workSheet.Cells["C35:E35"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["A35:B35"].Merge = true;
                workSheet.Cells["A35:B35"].Value = "";
                workSheet.Cells["A35:B35"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                
                workSheet.Cells["A37:D37"].Merge = true;
                workSheet.Cells["A37:D37"].Value = "Директор";
                workSheet.Cells["A37:D37"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["C38:E38"].Merge = true;
                workSheet.Cells["C38:E38"].Value = "Ястремский П. Г.";
                workSheet.Cells["C38:E38"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["A38:B38"].Merge = true;
                workSheet.Cells["A38:B38"].Value = "";
                workSheet.Cells["A38:B38"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells["F34:I38"].Merge = true;
                workSheet.Cells["F34:I38"].Value = "Дата формирования отчёта 04.12.2022";
                workSheet.Cells["F34:I38"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["F34:I38"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                workSheet.Cells["F34:I38"].Style.WrapText = true;


                #endregion

                /*
                #region body
                workSheet.Cells["B12:J12"].Merge = true;
                workSheet.Cells["B12:J12"].Value = "Заявление";
                workSheet.Cells["B12:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["B14:J22"].Merge = true;
                workSheet.Cells["B14:J22"].Value = $"Я {person.LastName} {person.Name} {person.FatherName} (id: {person.id})," +
                    $" прошу изменить данные в web-приложении для ораганизации работы " +
                    $"\"Cредней школы №1 г. Полоцка\" " +
                    $"логин  _________________, " +
                    $"должность  ______________________, " +
                    $"пол _________________, " +
                    $"а так же выдать мне соответствующие привелегии. В связи с ________________________________________________________";
                workSheet.Cells["B14:J22"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                workSheet.Cells["B14:J22"].Style.WrapText = true;


                #endregion

                #region footer
                workSheet.Cells["B24:E24"].Merge = true;
                workSheet.Cells["B24:E24"].Value = "Инспектор по кадрам";
                workSheet.Cells["B24:E24"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["B25:E25"].Merge = true;
                workSheet.Cells["B25:E25"].Value = "О. Н. Кочерягина";
                workSheet.Cells["B25:E25"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H25:J25"].Merge = true;
                workSheet.Cells["H25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B27:E27"].Merge = true;
                workSheet.Cells["B27:E27"].Value = "Заявитель";
                workSheet.Cells["B27:E27"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                workSheet.Cells["H28:J28"].Merge = true;
                workSheet.Cells["H28:J28"].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                workSheet.Cells["B28:E28"].Merge = true;
                workSheet.Cells["B28:E28"].Value = $"{person.Name[0]}. {person.FatherName[0]}. {person.LastName}";
                workSheet.Cells["B28:E28"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                #endregion
                //fileContent = package.GetAsByteArray();
                */
                try
                {
                    package.SaveAs(new FileInfo(docName + ".xlsx"));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
            /*File(
                fileContent,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                docName + ".xlsx");*/
            
            //Download Word document in the browser
            return true;
        }

    }
}
