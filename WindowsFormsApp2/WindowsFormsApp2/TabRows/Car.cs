using System;
using System.Data.SqlClient;
using MySqlDB;
namespace WindowsFormsApp2
{
    /// <summary>
    /// Класс представляет собой машины в моей БД
    /// </summary>
    class Car : ATabRow 
    {
        public string GosNum, Mark, Model;
        public bool track;
        public Car(string id, string gosnum, string mark, string model, bool track) {
            this.id = id;
            GosNum = gosnum;
            Mark = mark;
            Model = model;
            this.track = track;
        }

        public Car(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        override public string ToValues()
        {
            return string.Format("'{0}', '{1}', '{2}', '{3}', {4}", id, GosNum, Mark, Model, track? 1 : 0);
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", id, GosNum, Mark, Model, track);
        }

        override public void FromSqlDataReader(SqlDataReader reader)
        {
            id = reader.GetString(0);
            GosNum = reader.GetString(1);
            Mark = reader.GetString(2);
            Model = reader.GetString(3);
            track = reader.GetBoolean(4);
        }
    }
}
