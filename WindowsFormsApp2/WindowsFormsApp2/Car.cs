using System;
using System.Data.SqlClient;
using MySqlDB;
namespace WindowsFormsApp2
{
    class Car : ITabRow 
    {
        public string id, GosNum, Mark, Model;
        bool track;
        public Car(string id, string gosnum, string mark, string model, bool track) {
            this.id = id;
            GosNum = gosnum;
            Mark = mark;
            Model = model;
            this.track = track;
        }

        public string ToValues()
        {
            return string.Format("'{0}', '{1}', '{2}', '{3}', {4}", id, GosNum, Mark, Model, track? 1 : 0);
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", id, GosNum, Mark, Model, track);
        }

        public void FromSqlDataReader(SqlDataReader reader)
        {
            id = reader.GetString(0);
            GosNum = reader.GetString(0);
            Mark = reader.GetString(0);
            Model = reader.GetString(0);
            track = reader.GetBoolean(0);
        }
    }
}
