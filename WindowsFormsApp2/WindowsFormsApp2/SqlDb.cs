using System.Data.SqlClient;


namespace MySqlDB
{
    abstract class ATabRow
    {
        public string id;
        /// <summary>
        /// Метод для конвертации даннго класса в строку подходящюю для Sql команды INSERT ... VALUES(...)
        /// </summary>
        /// <returns> Строку подходящую для Sql команды INSERT ... VALUES(...)</returns>
        public abstract string ToValues();
        /// <summary>
        /// Метод для чтения значений из SqlDataReader в данный класс
        /// </summary>
        /// <param name="reader"> Аргумент из которого будут получены значения Должен соответствовать SELECT * FROM (таблица соответствующая данному классу)</param>
        public abstract void FromSqlDataReader(SqlDataReader reader);
    }
    ///<summary>
    /// Класс для взаимодействий с базой данных SQL Server 
    /// Представляет собой Singleton
    /// </summary>
    class SqlDB
    {

        static SqlDB sqlDB = null;
        SqlConnection connection;

        private SqlDB(string con)
        {
            connection = new SqlConnection(con);
            connection.Open();
        }

        ///<summary>
        /// Метод для возвращения ссылки на единственный экземпляр класса
        /// </summary>
        static public SqlDB CreRefSqlDB() {
            if (sqlDB == null)
                //172.16.0.12
                sqlDB = new SqlDB(@"Data Source=TCP:172.16.0.12\SQLEXPRESS;Initial Catalog=MyOsago;Persist Security Info=True;User ID=AStr347;Password=212212qwe");
                //sqlDB = new SqlDB(@"Data Source=.\SQLEXPRESS;Initial Catalog=MyOsago;Persist Security Info=True;User ID=sa;Password=212212qwe");
            return sqlDB;
        }

        ///<summary>
        /// Метод для операции SELECT
        /// </summary>
        /// <returns> SqlDataReader для чтения всей таблицы (со всеми столбцами)</returns>
        public SqlDataReader SelctAll(string from)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM " + from, connection);
            SqlDataReader reader = command.ExecuteReader();
            command.Dispose();
            if (reader.HasRows)
                return reader;
            else
            {
                reader.Close();
                return null;
            }
        }

        ///<summary>
        /// Метод для операции SELECT с условием
        /// </summary>
        /// <returns> SqlDataReader для чтения отфильтрованных строк таблицы (со всеми столбцами)</returns>
        public SqlDataReader SelectById(string from, string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM " + from + " WHERE ( Id = '" + id + "' )", connection);
            SqlDataReader reader = command.ExecuteReader();
            command.Dispose();
            if (reader.HasRows)
                return reader;
            else
            {
                reader.Close();
                return null;
            }
        }

        ///<summary>
        /// Метод для операции SELECT с условием
        /// </summary>
        /// <returns> SqlDataReader для чтения отфильтрованных строк таблицы (со всеми столбцами)</returns>
        public SqlDataReader SelectWhere(string from, string condition)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM " + from +" WHERE ( "+ condition + " )", connection);
            SqlDataReader reader = command.ExecuteReader();
            command.Dispose();
            if (reader.HasRows)
                return reader;
            else
            {
                reader.Close();
                return null;
            }
        }


        ///<summary>
        /// Метод для безопасной операции INSERT
        /// </summary>
        /// <returns> True если все прошло удачно</returns>
        public bool TryInsert(string into, ATabRow values) {
            SqlDataReader reader = SelectWhere(into, "id = '" + values.id + "'");
            if (reader == null) {
                Insert(into, values.ToValues());
                return true;
            }
            reader.Close();
            return false;
        }
        ///<summary>
        /// Метод для INSERT могут быть Exception
        ///</summary>
        /// <returns> число добавленных записей</returns>
        public int Insert(string into, string values)
        {
            SqlCommand command = new SqlCommand("INSERT INTO " + into + " VALUES(" + values + ")", connection);
            {
                int count = command.ExecuteNonQuery();
                command.Dispose();
                return count;
            }
        }
        ///<summary>
        /// Метод для удаления строк таблицы по условию
        ///</summary>
        public void DelWhere(string from, string condition)
        {
            // DELTE from Osago
            SqlCommand command = new SqlCommand("DELETE FROM " + from + " WHERE " + condition, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        ///<summary>
        /// Метод для удаления всех строк таблицы
        ///</summary>
        public void DelAll(string from)
        {
            // DELTE from Osago
            SqlCommand command = new SqlCommand("DELETE FROM " + from, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        ///<summary>
        /// Метод для удаления всех строк таблицы
        ///</summary>
        public int CountInTable(string from) {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + from, connection);
            int count = (int)command.ExecuteScalar();
            command.Dispose();
            return count;
        }
    }
}
