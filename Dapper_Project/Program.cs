using Dapper;
using Dapper_Project;
using Microsoft.Data.SqlClient;
using System.Data;

var qeury = "SELECT * FROM [DARBUOTOJAS]";
var cs = "Server=.;Database=MyFirstDB;Trusted_Connection=True;TrustServerCertificate=True;";

using var connection = new SqlConnection(cs);
var data = connection.Query<Darbuotojas>(qeury);
var spQeury = "EXECUTE [GetDarbuotojasByAsmensKodas] @AsmensKodas";
var spName = "[GetDarbuotojasByAsmensKodas]";
var spParams = new { AsmensKodas = "38101122335" };

var spResult = connection.QueryFirst<Darbuotojas>(spQeury, spParams);
var spResult2 = connection.QueryFirst<Darbuotojas>(spName, spParams, commandType: CommandType.StoredProcedure);

var columnName = "Vardas";
var searchParam = "Jonas";
var query2 = $"SELECT * FROM [DARBUOTOJAS] WHERE {columnName} = @x";
var queryResult = connection.Query<Darbuotojas>(query2, new { x = $"{}" });

Console.WriteLine();







//protected override void OnConfiguring(DbContextOptionsBuilder options)
//{
//    options.UseSqlServer("Data Source=.;Initial Catalog=EF_Core_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//}