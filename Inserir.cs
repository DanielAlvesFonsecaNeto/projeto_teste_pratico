using Npgsql;
using System;

class Inserir{

public void inserir(string palavra){
    string connectionString = @"
        Host=127.0.0.1;
        Port=5432;
        Username=postgres;
        Password=1234;
        Database=programa";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();

        using NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO nota_fiscal (columna) VALUES (valor)", connection);
        cmd.Parameters.AddWithValue("valor", palavra);

        // int rowsAffected = cmd.ExecuteNonQuery();
    }

}