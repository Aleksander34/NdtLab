using NdtLab.Dto.Joints;
using NdtLab.Dto.Requests;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Text;

namespace NdtLab.Excel
{
    public static class ExcelParcerUtil
    {
        public static ExcelInputDto ParseRequest(string pathToFile)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var file = new FileInfo(pathToFile);
            var result = new ExcelInputDto()
            {
                Request = new RequestDto() { ReferencesDoc = new ReferencesDocDto(),Piping = new PipingDto(),SteelStructure=new SteelStructureDto(), PipeLine = new PipeLineDto() },
                Joints = new List<JointDto>(), Division = new Dto.EmployeesInfo.DivisionDto()
            };


            using (var excel = new ExcelPackage(file))
            {
                var worksheet = excel.Workbook.Worksheets[1];
                result.Request.Number = worksheet.Cells["F2"].Value.ToString().Trim();
                result.Request.Date = DateTime.Parse(worksheet.Cells["I2"].Value.ToString().Trim());
                result.Request.WeldingCompany = worksheet.Cells["E4"].Value.ToString().Trim();
                result.Division.Name = worksheet.Cells["E5"].Value.ToString().Trim();
                result.Request.Object = worksheet.Cells["E6"].Value.ToString().Trim();
                result.Request.PartObject = worksheet.Cells["E7"]?.Value?.ToString().Trim();
                
                result.Request.Draw = worksheet.Cells["E8"]?.Value?.ToString().Trim();
                result.Request.CategoryGost = worksheet.Cells["E9"].Value.ToString().Trim();
                result.Request.OtherCategory = worksheet.Cells["E10"]?.Value?.ToString().Trim();
                result.Request.Temperature = int.Parse(worksheet.Cells["E11"]?.Value?.ToString().Trim());

                result.Request.Piping.Zone = worksheet.Cells["L4"]?.Value?.ToString().Trim();
                result.Request.Piping.Line = worksheet.Cells["L5"]?.Value?.ToString().Trim();
                result.Request.Piping.Spool = worksheet.Cells["L6"]?.Value?.ToString().Trim(); // если пусто тогда null. Если возможен null тогда ?
                result.Request.SteelStructure.Sector = worksheet.Cells["L7"]?.Value?.ToString().Trim();
                result.Request.SteelStructure.Part = worksheet.Cells["L8"]?.Value?.ToString().Trim();
                result.TankPart = worksheet.Cells["L9"]?.Value?.ToString().Trim(); // потом на сервере сопоставим switch case
                result.Request.PipeLine.Distance = worksheet.Cells["L10"]?.Value?.ToString().Trim();
                result.Request.Rebar = worksheet.Cells["L11"]?.Value?.ToString().Trim() == "Да";  //если в вводимой строке да то выражение == возвращает истину
                result.QualificationType = worksheet.Cells["L12"]?.Value?.ToString().Trim(); // потом на сервере сопоставим switch case

                result.Request.ReferencesDoc.MainDoc = worksheet.Cells["C13"]?.Value?.ToString().Trim();
                result.Request.ReferencesDoc.WeldingDoc = worksheet.Cells["C14"]?.Value?.ToString().Trim();
                result.Request.ReferencesDoc.InspectionDoc = worksheet.Cells["C15"]?.Value?.ToString().Trim();
                result.Request.ReferencesDoc.QualityCriteria = worksheet.Cells["C16"]?.Value?.ToString().Trim();

                result.Request.SubmittedBy = worksheet.Cells["D18"]?.Value?.ToString().Trim(); //TODO: ?
                result.Request.ReceivedByFio = worksheet.Cells["K18"]?.Value?.ToString().Trim();  //TODO: ?

                for (int row = 21; ; row++) // начинаем с 21 строки и каждый раз увеличиваем на 1
                {
                    string end = worksheet.Cells[$"A{row}"].Value.ToString().Trim();
                    if (end == "конец ввода")
                        break;
                    result.Joints.Add(GetJoint(worksheet, row));
                }

            }
            return result;
        }


        static JointDto GetJoint(ExcelWorksheet worksheet, int row)
        {
            var result = new JointDto();
            result.Number = worksheet.Cells[$"A{row}"].Value.ToString().Trim();
            result.WeldingDate = DateTime.Parse(worksheet.Cells[$"B{row}"].Value.ToString().Trim());
            result.WeldingType = worksheet.Cells[$"C{row}"].Value.ToString().Trim();
            result.ConnectionType = worksheet.Cells[$"D{row}"].Value.ToString().Trim();
            result.ElementOne = worksheet.Cells[$"E{row}"].Value.ToString().Trim();
            result.ElementTwo = worksheet.Cells[$"F{row}"].Value.ToString().Trim();
            result.DiameterOne = double.Parse(worksheet.Cells[$"G{row}"].Value.ToString().Trim());
            result.DiameterTwo = double.Parse(worksheet.Cells[$"H{row}"].Value.ToString().Trim());
            result.ThicknessOne = double.Parse(worksheet.Cells[$"I{row}"].Value.ToString().Trim());
            result.ThicknessTwo = double.Parse(worksheet.Cells[$"J{row}"].Value.ToString().Trim());

            result.GradeOne = worksheet.Cells[$"K{row}"].Value.ToString().Trim();
            result.GradeTwo = worksheet.Cells[$"L{row}"].Value.ToString().Trim();
            result.Stamps = worksheet.Cells[$"M{row}"].Value.ToString().Trim();
            result.RequiredInspection = worksheet.Cells[$"N{row}"].Value.ToString().Trim();
            result.WeldLength = double.Parse(worksheet.Cells[$"O{row}"].Value.ToString().Trim());
            result.Note = worksheet.Cells[$"P{row}"].Value.ToString().Trim();
            return result;
        }
    }
}
