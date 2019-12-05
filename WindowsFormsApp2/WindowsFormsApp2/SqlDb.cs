using System.Data.SqlClient;
namespace MySqlDB
{
    interface ITabRow
    {
        /// <summary>
        /// Метод для конвертации даннго класса в строку подходящюю для Sql команды INSERT ... VALUES(...)
        /// </summary>
        /// <returns> Строку подходящую для Sql команды INSERT ... VALUES(...)</returns>
        string ToValues();
        /// <summary>
        /// Метод для чтения значений из SqlDataReader в данный класс
        /// </summary>
        /// <param name="reader"> Аргумент из которого будут получены значения Должен соответствовать SELECT * FROM (таблица соответствующая данному классу)</param>
        void FromSqlDataReader(SqlDataReader reader);
    }

    class SqlDB
    {

        static SqlDB sqlDB = null;
        SqlConnection connection;

        private SqlDB(string con)
        {
            connection = new SqlConnection(con);
            connection.Open();
        }

        static public SqlDB CreRefSqlDB(string con) {
            if (sqlDB == null)
                sqlDB = new SqlDB(con);
            return sqlDB;
        }

        public SqlDataReader SelctAll(string from)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM " + from, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                return reader;
            else
            {
                reader.Close();
                return null;
            }
        }

        public SqlDataReader SelectWhere(string from, string condition)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM " + from +" WHERE ( "+ condition + " )", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                return reader;
            else
            {
                reader.Close();
                return null;
            }
        }

        public bool TryInsert(string into, ITabRow values) {
            string s = values.ToValues().Split(',')[0];
            SqlDataReader reader = SelectWhere(into, "Id = " + s);
            if (reader == null) {
                Insert(into, values.ToValues());
                return true;
            }
            reader.Close();
            return false;
        }

        public int Insert(string into, string values)
        {
            SqlCommand command = new SqlCommand("INSERT INTO " + into + " VALUES(" + values + ")", connection);
            //try
            {
                return command.ExecuteNonQuery();
            }
            /*catch
            {
                return 0;
            }*/
        }

        public void DelWhere(string from, string condition)
        {
            // DELTE from Osago
            SqlCommand command = new SqlCommand("DELETE FROM " + from + " WHERE " + condition, connection);
            command.ExecuteNonQuery();
        }

        public void DelAll(string from)
        {
            // DELTE from Osago
            SqlCommand command = new SqlCommand("DELETE FROM " + from, connection);
            command.ExecuteNonQuery();
        }


        public int CountInTable(string from) {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + from, connection);
            return (int) command.ExecuteScalar();
        }
    }
}
