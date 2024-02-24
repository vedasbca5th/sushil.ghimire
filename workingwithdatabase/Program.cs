class Program
{
    public static void Main()
    {
        // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        // {
        //     DataSource = "(local)",
        //     InitialCatalog = "bca_6th_sem",
        //     IntegratedSecurity = true,
        //     Password = "root",
        //     UserID = "root"
        // };
       string masterConnectionString = "Server=localhost;User Id=root;Password=root;";

        // Ensure the database exists
        WorkingWithDb.CreateDatabase(masterConnectionString, "bca_6th_sem");

        string connectionString = "Server=localhost;Database=bca_6th_sem;User Id=root;Password=root;";

        // Use the database and create the table
        // WorkingWithDb.CreateTable(connectionString);

        // // Insert operation
        // WorkingWithDb.InsertData(connectionString);

        // // Select operation
        WorkingWithDb.SelectData(connectionString);

        // // Update operation
        // WorkingWithDb.UpdateData(connectionString);

        // // Delete operation
        WorkingWithDb.DeleteData(connectionString);

        Console.ReadLine();
    }
}
