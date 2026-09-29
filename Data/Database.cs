using MySql.Data.MySqlClient;

namespace SistemaVotacao.Data
{
    public static class Database
    {
        public static string ConnectionString = "Server=localhost;Port=3306;Database=votacao;User ID=root;Password=root;";
        
        public static MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
