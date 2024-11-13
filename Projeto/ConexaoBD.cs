// using Npgsql;
// using System;

// public class ConexaoBD
// {
//     public ConexaoBD() { 

//     }

//     private static string connectionString = @"
//         Host=127.0.0.1;
//         Port=5432;
//         Username=postgres;
//         Password=1234;
//         Database=programa";

//     public NpgsqlConnection GetConnection()
//     {
//         try
//         {
//             var connection = new NpgsqlConnection(connectionString);
//             connection.Open();
//             return connection;
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro ao conectar: {ex.Message}");
//             throw;
//         }
//     }

// }

