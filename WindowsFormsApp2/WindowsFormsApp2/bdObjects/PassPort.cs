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

        public bool type;
        //Юр лицо
        public string INN, OGRN, OPForm, RSchet;
        //Физ лицо
        public string SerNumPass, Who, Address, SerNumVod;
        public DateTime When;

        public PassPort(int id, string fio, bool type) {
            this.id = id.ToString();
            FullName = fio;
            this.type = type;
        }

        public void Init(string[] s) {
            if (type == true)
            {
                INN = s[0];
                OGRN = s[1];
                OPForm = s[2];
                RSchet = s[3];
            }
            else {
                SerNumPass = s[0];
                SerNumVod = s[1];
                Who = s[2];
                Address = s[3];
                When = Convert.ToDateTime(s[4]);
            }
        }

        public PassPort(SqlDataReader reader) {
            FromSqlDataReader(reader);
        }

        override public string ToValues() {
            return string.Format("'{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}'",
                                id, FullName, type ? 1 : 0, SerNumPass, SerNumVod, Who, Address, When, INN, OGRN, OPForm, RSchet);
        }
        

        override public void FromSqlDataReader(SqlDataReader reader) {
            id = reader.GetString(0);
            FullName = reader.GetString(1);
            type = reader.GetBoolean(2);
            
            SerNumPass = reader.GetString(3);
            SerNumVod = reader.GetString(4);
            Who = reader.GetString(5);
            Address = reader.GetString(6);
            When = reader.GetDateTime(7);
            
            INN = reader.GetString(8);
            OGRN = reader.GetString(9);
            OPForm = reader.GetString(10);
            RSchet = reader.GetString(11);

        }

    }
}
