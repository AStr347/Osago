using System.Data.SqlClient;
using System;
using MySqlDB;

namespace MyOsago
{

    class Osago : ITabRow
    {
        int IdInsurant, IdOwner, IdFaces, Price;
        DateTime    BegDate, EndDate, ConDate;
        string SerNum, IdCar;

        public Osago(SqlDataReader reader)
        {
            FromSqlDataReader(reader);
        }

        public Osago(string sernum, int idInsurant, int idOwner, string idCar, int idFaces, DateTime idBegDate, DateTime idEndDate, DateTime idConDate, int price)
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
        public string ToValues()
        {
            return string.Format("'{0}' , {1} , {2} , '{3}' , {4} , {5} , {6}",
                            SerNum, IdInsurant, IdOwner, IdCar, IdFaces, DateTimeToSqlDateString(), Price);
        }

        /// <summary>
        /// Метод для чтения значений из SqlDataReader в данный класс
        /// </summary>
        /// <param name="reader"> Аргумент из которого будут получены значения. Должен соответствовать SELECT * FROM (таблица соответствующая данному классу)</param>
        public void FromSqlDataReader(SqlDataReader reader) {
            SerNum = Convert.ToString(reader.GetValue(0));
            IdInsurant = Convert.ToInt32(reader.GetValue(1));
            IdOwner = Convert.ToInt32(reader.GetValue(2));
            IdCar = Convert.ToString(reader.GetValue(3));
            IdFaces = Convert.ToInt32(reader.GetValue(4));
            BegDate = Convert.ToDateTime(reader.GetValue(5));
            EndDate = Convert.ToDateTime(reader.GetValue(6));
            ConDate = Convert.ToDateTime(reader.GetValue(7));
            Price = Convert.ToInt32(reader.GetValue(8));
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                            SerNum, IdInsurant, IdOwner, IdCar, IdFaces, BegDate.ToShortDateString(), EndDate.ToShortDateString(), ConDate.ToShortDateString(), Price);
        }
    }
}
