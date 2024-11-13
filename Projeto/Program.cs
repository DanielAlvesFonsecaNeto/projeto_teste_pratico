using Npgsql;
using System;

class Program{
    static void Main(){

        string connectionString = @"
        Host=127.0.0.1;
        Port=5432;
        Username=postgres;
        Password=1234;
        Database=programa";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();


        //ConexaoBD BD =  new ConexaoBD();

        //using (NpgsqlConnection connection = BD.GetConnection())

        using NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM nota_fiscal", connection);
        using NpgsqlDataReader reader = cmd.ExecuteReader();

        // teste pra ver se tem algo no banco
        while(reader.Read()){
            Console.WriteLine(reader["emissor"]);
        }


        Inserir Inse = new Inserir();

        Inse.inserir("algoo");
        //connection.close();
    }


}