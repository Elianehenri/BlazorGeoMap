// DataPopulator.cs

using BlazorGeoMap.Data;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorGeoMap.Services
{
    public class DataPopulator
    {
        private readonly ApplicationDbContext _context;

        public DataPopulator(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task PopulateDataAsync()
        {
            try
            {
                var schemaFilePath = Path.Combine("Files", "Schema.sql");
                Console.WriteLine($"Caminho do Schema.sql: {schemaFilePath}");
                var schemaSql = File.ReadAllText(schemaFilePath);

                var dataFilePath = Path.Combine("Files", "Data.sql");
                Console.WriteLine($"Caminho do Data.sql: {dataFilePath}");
                var dataSql = File.ReadAllText(dataFilePath);

                // Separar comandos pelo padrão "GO"
                var schemaCommands = schemaSql.Split("GO", StringSplitOptions.RemoveEmptyEntries);
                var dataCommands = dataSql.Split("GO", StringSplitOptions.RemoveEmptyEntries);

                // Execute os comandos do Schema um por um
                foreach (var command in schemaCommands)
                {
                    await _context.Database.ExecuteSqlRawAsync(command);
                }

                // Verificar se a tabela Localities (ou IBGE) existe antes de executar os comandos de dados
                var tableExists = await _context.Database.CanConnectAsync();
                if (tableExists)
                {
                    // Execute os comandos de dados um por um
                    foreach (var command in dataCommands)
                    {
                        await _context.Database.ExecuteSqlRawAsync(command);
                    }

                    Console.WriteLine("Dados populados com sucesso!");
                }
                else
                {
                    Console.WriteLine("A tabela não existe no banco de dados. Certifique-se de que as migrações foram aplicadas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao popular o banco com dados do SQL: {ex.Message}");
                throw;
            }
        }

    }
}
