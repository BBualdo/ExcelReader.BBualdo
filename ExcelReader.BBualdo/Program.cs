using ExcelReader.BBualdo.Models;
using ExcelReader.BBualdo.Services;

ExcelReaderService excelReaderService = new();
List<Person> people = await excelReaderService.GetFromExcel();

if (people.Count == 0)
{
  Console.WriteLine("No people found.");
}
else
{
  foreach (Person person in people)
  {
    Console.WriteLine($"\n{person.FirstName} - {person.LastName} - {person.Age} - {person.Country}\n");
  }
}