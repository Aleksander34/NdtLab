// работа с excel
using NdtLab.Dto.Joints;
using NdtLab.Dto.Requests;
using NdtLab.ExcelParser;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
var file = new FileInfo(@"D:\2. Книги\документы книги\программирование\заявка.xlsx");
var result = new ExcelInputDto()
{
    Request = new RequestDto() {ReferencesDoc=new ReferencesDocDto()},
    Joints = new List<JointDto>()
};



using (var excel = new ExcelPackage(file))
{
    var worksheet = excel.Workbook.Worksheets[1];
    result.Request.Number = worksheet.Cells["K1"].Value.ToString().Trim();
    result.Request.Date = DateTime.Parse(worksheet.Cells["N1"].Value.ToString().Trim());
    result.Request.OtherCategory = worksheet.Cells["I8"]?.Value?.ToString().Trim();     // если пусто тогда null. Если возможен null тогда ?
    result.Request.ReferencesDoc.QualityCriteria = worksheet.Cells["I9"].Value.ToString().Trim();
    for (int row = 14; ; row++) // начинаем с 14 строки и каждый раз увеличиваем на 1
    {
        string end = worksheet.Cells[$"D{row}"].Value.ToString().Trim();
        if (end == "конец ввода данных")
            break;

        result.Joints.Add(GetJoint(worksheet, row));
    }

}
Console.WriteLine(JsonConvert.SerializeObject(result));   //превращает объект в Json

static JointDto GetJoint(ExcelWorksheet worksheet, int row)
{
    var result = new JointDto();
    result.Number = worksheet.Cells[$"D{row}"].Value.ToString().Trim();
    result.ConnectionType = worksheet.Cells[$"E{row}"].Value.ToString().Trim();
    result.Stamps = worksheet.Cells[$"F{row}"].Value.ToString().Trim();
    result.WeldingType = worksheet.Cells[$"G{row}"].Value.ToString().Trim();
    result.WeldingDate = DateTime.Parse(worksheet.Cells[$"H{row}"].Value.ToString().Trim());
    return result;
}