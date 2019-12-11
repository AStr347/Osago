using System;
using System.Data.SqlClient;
using MySqlDB;

namespace MyPassPort
{
    /// <summary>
    /// Класс представляет собой Страховщика и Собственника
    /// </summary>
    class PassPort : ATabRow
    {
        public string FullName;

        public PassPort(int id, string fio) {
            this.id = id.ToString();
            FullName = fio;
        }

        public PassPort(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        override public string ToValues() {
            return string.Format("'{0}', '{1}'", id, FullName);
        }
        
        public override string ToString()
        {
            return string.Format("{0}\t{1}", id, FullName);
        }

        override public void FromSqlDataReader(SqlDataReader reader) {
            id = reader.GetString(0);
            FullName = reader.GetString(1);
        }

    }
}
