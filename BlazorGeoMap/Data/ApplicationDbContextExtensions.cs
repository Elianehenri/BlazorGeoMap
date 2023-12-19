//using Microsoft.EntityFrameworkCore;
//using System.IO;
//using System.Threading.Tasks;

//namespace BlazorGeoMap.Data
//{
//    public static class ApplicationDbContextExtensions
//    {
//        public static async Task<int> ExecuteSqlFileAsync(this ApplicationDbContext context, string filePath)
//        {
//            var sql = await File.ReadAllTextAsync(filePath);
//            return await context.Database.ExecuteSqlRawAsync(sql);
//        }
//    }
//}
