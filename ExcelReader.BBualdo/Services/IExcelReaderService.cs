using ExcelReader.BBualdo.Models;

namespace ExcelReader.BBualdo.Services;

internal interface IExcelReaderService
{
  Task<List<Person>> GetFromExcel();
}
