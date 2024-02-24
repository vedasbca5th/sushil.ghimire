using MySql.Data.MySqlClient;

public class WorkingWithDb
{
    public static void CreateDatabase(string masterConnectionString, string databaseName)
    {
        using (MySqlConnection masterConnection = new MySqlConnection(masterConnectionString))
        {
            try
            {
                masterConnection.Open();

                // Create the database if it doesn't exist
                string createDatabaseQuery = $"CREATE DATABASE IF NOT EXISTS {databaseName}";
                using (MySqlCommand command = new MySqlCommand(createDatabaseQuery, masterConnection))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine($"Database '{databaseName}' created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB_error error while create database:{ex}");

            }
        }
    }

    public static void CreateTable(string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create table
                string createTableQuery = "CREATE TABLE IF NOT EXISTS student (Id INT PRIMARY KEY, Name NVARCHAR(100))";
                using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Table 'student' created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB_error error while create table:{ex}");
            }
        }
    }

    public static void InsertData(string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            Console.WriteLine("Enter ID for insertion:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name for insertion:");
            string name = Console.ReadLine();

            string insertQuery = "INSERT INTO student (Id, Name) VALUES (@Id, @Name)";
            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to insert data.");
                }
            }
        }
    }

    public static void SelectData(string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM student";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Data from database:");

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        Console.WriteLine($"ID: {id}, Name: {name}");
                    }
                }
            }
        }
    }

    public static void UpdateData(string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            Console.WriteLine("Enter ID for update:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter new name for update:");
            string newName = Console.ReadLine();

            string updateQuery = "UPDATE student SET Name = @NewName WHERE Id = @Id";
            using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NewName", newName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update data.");
                }
            }
        }
    }

    public static void DeleteData(string connectionString)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            Console.WriteLine("Enter ID for deletion:");
            int id = Convert.ToInt32(Console.ReadLine());

            string deleteQuery = "DELETE FROM student WHERE Id = @Id";
            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to delete data.");
                }
            }
        }
    }
}
