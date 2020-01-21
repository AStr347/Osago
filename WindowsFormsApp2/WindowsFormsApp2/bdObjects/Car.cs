using System;
using System.Data.SqlClient;
using MySqlDB;
using MyPassPort;
namespace WindowsFormsApp2
{
    /// <summary>
    /// Класс представляет собой машины в моей БД
    /// </summary>
    class Car : ATabRow 
    {
        public string GosNum, Mark, Model, EnginePow, EngineV;
        public bool track;
        public PassPort p;
        public Car(string id, string gosnum, string mark, string model, bool track, string enginepow, string engineV) {
            this.id = id;
            GosNum = gosnum;
            Mark = mark;
            Model = model;
            this.track = track;
            EnginePow = enginepow;
            EngineV = engineV;
        }

        public Car(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        override public string ToValues()
        {
            return string.Format("'{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}", id, GosNum, Mark, Model, track? 1 : 0, EnginePow, EngineV);
        }

        override public void FromSqlDataReader(SqlDataReader reader)
        {
            id = reader.GetString(0);
            GosNum = reader.GetString(1);
            Mark = reader.GetString(2);
            Model = reader.GetString(3);
            track = reader.GetBoolean(4);
            EnginePow = reader.GetString(6);
            EngineV = reader.GetString(7);
        }
    }
}
