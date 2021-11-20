namespace _3C1LUCAS26.dal
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection conexaoBanco;

        public MySqlCommand(string sql, MySqlConnection conexaoBanco)
        {
            this.sql = sql;
            this.conexaoBanco = conexaoBanco;
        }
    }
}