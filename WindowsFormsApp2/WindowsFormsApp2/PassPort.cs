using System;
using System.Data.SqlClient;
using MySqlDB;

namespace MyPassPort
{
    class PassPort : ITabRow
    {
        string Fam, Name, Pat;
        public int id;

        public PassPort(int id, string fam, string name, string pat) {
            this.id = id;
            Fam = fam;
            Name = name;
            Pat = pat;
        }
        public PassPort(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        public string ToValues() {
            return string.Format("'{0}', '{1}', '{2}', '{3}'", id, Fam, Name, Pat);
        }
        
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", id, Fam, Name, Pat);
        }

        public void FromSqlDataReader(SqlDataReader reader) {
            id = Convert.ToInt32(reader.GetValue(0));
            Fam = Convert.ToString(reader.GetValue(1));
            Name = Convert.ToString(reader.GetValue(2));
            Pat = Convert.ToString(reader.GetValue(3));
        }

    }
}
