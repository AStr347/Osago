using System.Data.SqlClient;
using System;
using MySqlDB;

namespace MyOsago
{
    /// <summary>
    /// Класс представляет собой Полис Осаго из моей БД
    /// </summary>
    class Osago : ATabRow
    {
        public string IdInsurant, IdOwner, IdFaces;
        public int Price;
        public DateTime    BegDate, EndDate, ConDate;
        public string SerNum, IdCar;

        public Osago(SqlDataReader reader)
        {
            FromSqlDataReader(reader);
        }

        public Osago(string sernum, string idInsurant, string idOwner, string idCar, string idFaces, DateTime idBegDate, DateTime idEndDate, DateTime idConDate, int price)
        {
            SerNum = sernum;
            IdInsurant = idInsurant;
            IdOwner = idOwner;
            IdCar = idCar;
            IdFaces = idFaces;
            BegDate = idBegDate;
            EndDate = idEndDate;
            ConDate = idConDate;
            Price = price;
            id = SerNum;
        }

        private string DateTimeToSqlDateString() {
            return string.Format("'{0}/{1}/{2}' , '{3}/{4}/{5}', '{6}/{7}/{8}'",    BegDate.Day, BegDate.Month, BegDate.Year, 
                                                                                    EndDate.Day, EndDate.Month, EndDate.Year, 
                                                                                    ConDate.Day, ConDate.Month, ConDate.Year);
        }

        /// <summary>
        /// Метод для конвертации даннго класса в строку подходящюю для Sql команды INSERT ... VALUES(...)
        /// </summary>
        /// <returns> Строку подходящую для Sql команды INSERT ... VALUES(id, IdInsurant, IdOwner, IdCar, IdFaces, BegDate, EndDate, ConDate, Price)</returns>
        override public string ToValues()
        {
            return string.Format("'{0}' , {1} , {2} , '{3}' , {4} , {5} , {6}",
                            SerNum, IdInsurant, IdOwner, IdCar, IdFaces, DateTimeToSqlDateString(), Price);
        }

        /// <summary>
        /// Метод для чтения значений из SqlDataReader в данный класс
        /// </summary>
        /// <param name="reader"> Аргумент из которого будут получены значения. Должен соответствовать SELECT * FROM (таблица соответствующая данному классу)</param>
        override public void FromSqlDataReader(SqlDataReader reader) {
            SerNum = reader.GetString(0);
            IdInsurant = reader.GetString(1);
            IdOwner = reader.GetString(2);
            IdCar = reader.GetString(3);
            IdFaces = reader.GetString(4);
            BegDate = reader.GetDateTime(5);
            EndDate = reader.GetDateTime(6);
            ConDate = reader.GetDateTime(7);
            Price = reader.GetInt32(8);
            id = SerNum;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                            SerNum, IdInsurant, IdOwner, IdCar, IdFaces, BegDate.ToShortDateString(), EndDate.ToShortDateString(), ConDate.ToShortDateString(), Price);
        }

    }
}
