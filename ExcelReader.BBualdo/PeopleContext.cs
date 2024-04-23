using ExcelReader.BBualdo.Models;
using ExcelReader.BBualdo.Services;
using Microsoft.EntityFrameworkCore;

namespace ExcelReader.BBualdo;

public class PeopleContext : DbContext
{
  public DbSet<Person> People { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString")!);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
  }

  public void LoadDataFromExcel()
  {
    var excelReaderService = new ExcelReaderService();
    var people = excelReaderService.GetFromExcel().Result;
    People.AddRange(people);
    SaveChanges();
  }
}
