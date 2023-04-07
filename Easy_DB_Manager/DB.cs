using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

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

        public static async Task ReadAllTablesFromDB(string dataSource, string nameDB)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES", connection);

                    await command.ExecuteNonQueryAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        int columnCount = reader.FieldCount;

                        List<string> columnName = new List<string>();

                        for (int i = 0; i < columnCount; i++)
                        {
                            columnName.Add(reader.GetName(i));
                        }

                        List<List<string>> rowsValues = new List<List<string>>();

                        while (reader.Read())
                        {
                            var tempList = new List<string>();
                            for (int i = 0; i < columnCount; i++)
                            {
                                tempList.Add(reader.GetValue(i).ToString() ?? "NULL");
                            }

                            rowsValues.Add(tempList);
                        }

                        await connection.CloseAsync();

                        PrintReport(columnName, rowsValues, columnCount, nameDB);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static async Task ReadDataOfTable(string dataSource, string nameDB, string tableName, string columns, bool isAllColumns)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand();

                    if (isAllColumns)
                        command.CommandText = $"SELECT * FROM {tableName}";
                    else
                        command.CommandText = $"SELECT {columns} FROM {tableName}";

                    command.Connection = connection;

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        int columnCount = reader.FieldCount;

                        List<string> columnName = new List<string>();

                        for (int i = 0; i < columnCount; i++)
                        {
                            columnName.Add(reader.GetName(i));
                        }

                        List<List<string>> rowsValues = new List<List<string>>();

                        while (reader.Read())
                        {
                            var tempList = new List<string>();
                            for (int i = 0; i < columnCount; i++)
                            {
                                tempList.Add(reader.GetValue(i).ToString() ?? "NULL");
                            }

                            rowsValues.Add(tempList);
                        }

                        await connection.CloseAsync();

                        PrintReport(columnName, rowsValues, columnCount, nameDB);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public static async Task AddDataInTable(string dataSource, string nameDB, string tableName, string columnsName, string columnsValue)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"INSERT INTO {tableName} ({columnsName}) VALUES ({columnsValue})";

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();

                    await connection.CloseAsync();

                    MessageBox.Show("Данные добавлены в таблицу", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        public static async Task UpdateValue(string dataSource, string nameDB, string tableName, string columnName, string newValue, string filterColumnName, string filterColumnValue)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"UPDATE {tableName} SET {columnName} = '{newValue}' WHERE {filterColumnName} = '{filterColumnValue}';";

                    command.Connection = connection;

                    await command.ExecuteNonQueryAsync();

                    await connection.CloseAsync();

                    MessageBox.Show("Данные обновлены", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        public static async Task DropDB(string dataSource, string nameDB)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, "master")))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand($"DROP DATABASE {nameDB}", connection);

                    await command.ExecuteNonQueryAsync();

                    await connection.CloseAsync();
                    MessageBox.Show($"База данных {nameDB} удалена", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static async Task DropTable(string dataSource, string nameDB, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand($"DROP TABLE {tableName}", connection);

                    await command.ExecuteNonQueryAsync();

                    await connection.CloseAsync();

                    MessageBox.Show($"Таблица {tableName} удалена из базы данных {nameDB}", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static async Task DeleteFromTable(string dataSource, string nameDB, string tableName, string columnName, string rowsValue)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString(dataSource, nameDB)))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand($"DELETE FROM {tableName} WHERE {columnName} = '{rowsValue}'", connection);

                    await command.ExecuteNonQueryAsync();

                    await connection.CloseAsync();

                    MessageBox.Show($"Данные удалены из таблицы {tableName}", "Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static void PrintReport(List<string> columnName, List<List<string>> rowsValues, int columnCount, string reportName)
        {

            ReportForm report = new ReportForm() { AutoSize = true, Text = reportName };

            var table = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                RowCount = 0,
                ColumnCount = columnCount,
                AutoSize = true,
                Dock = DockStyle.Fill
            };

            for (int i = 0; i < rowsValues.Count; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < columnName.Count; i++)
            {
                table.Controls.Add(new Label() { AutoSize = true, Text = columnName[i], Dock = DockStyle.Fill, Font = new Font(FontFamily.GenericSansSerif, 11f, FontStyle.Bold) }, i, 0);
            }

            for (int i = 0; i < rowsValues.Count; i++)
            {
                for (int j = 0; j < rowsValues[i].Count; j++)
                {
                    table.Controls.Add(new Label() { AutoSize = true, Text = rowsValues[i][j], Dock = DockStyle.Fill }, j, i + 1);
                }
            }

            report.Controls.Add(table);
            report.Show();
        }
         
    }
}
