using System;
using System.Data.SqlClient;
using MySqlDB;

namespace MyPassPort
{
    class PassPort : ITabRow
    {
        string Fio;
        public int id;

        public PassPort(int id, string fio) {
            this.id = id;
            Fio = fio;
        }
        public PassPort(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        public string ToValues() {
            return string.Format("'{0}', '{1}'", id, Fio);
        }
        
        public override string ToString()
        {
            return string.Format("{0}\t{1}", id, Fio);
        }

        public void FromSqlDataReader(SqlDataReader reader) {
            id = reader.GetInt32(0);
            Fio = reader.GetString(1);
        }

    }
}
