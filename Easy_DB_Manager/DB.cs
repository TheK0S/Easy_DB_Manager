using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_DB_Manager
{
    internal class DB
    {
        public static Form1 form = new Form1();
        static string GetConnectionString(string dataSource, string initialCatalog)
        {
            return @"Data Source = " + dataSource + "; Initial Catalog = " + initialCatalog + "; Trusted_Connection=True; Encrypt = False";
        }

        public static async Task CreateDB(string dataSource, string nameDB)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, "master")))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand($"CREATE DATABASE {nameDB}", connection);
                    await command.ExecuteNonQueryAsync();
                    await connection.CloseAsync();

                    MessageBox.Show($"База данных {nameDB} успешно добавлена", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static async Task CreateTable(string tableName, string strCommand, string dataSource, string nameDB)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand(
                        $"CREATE TABLE {tableName} ({strCommand});", connection);

                    await command.ExecuteNonQueryAsync();
                    await connection.CloseAsync();

                    MessageBox.Show($"Таблица {tableName} успешно добавлена", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
