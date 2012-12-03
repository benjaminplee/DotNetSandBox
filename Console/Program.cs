using System.Data.SQLite;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connString = "Data Source=db\\database.sqlite";

            using (var conn = new SQLiteConnection(connString))
            {
                using (var cmd = new SQLiteCommand("SELECT * FROM CUSTOMER", conn))
                {
                    conn.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            System.Console.WriteLine(dr.GetValue(0) + " " + dr.GetValue(1));
                        }
                    }
                }
            }
        }
    }
}
