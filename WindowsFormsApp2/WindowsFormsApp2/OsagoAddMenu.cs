using MyOsago;
using MyPassPort;
using MySqlDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class OsagoAddMenu : IDisposable
    {

        private Osago osago = null;
        private PassPort insurant = null;
        private PassPort owner = null;
        private Car car = null;

        private SqlDB Sql = SqlDB.CreRefSqlDB(@"Data Source=.\SQLEXPRESS;Initial Catalog=MyOsago;Integrated Security=True");
        bool Insertcar = false;
        bool Insertosago = false;
        bool InsertInsurant = false;
        bool Insertowner = false;

        public OsagoAddMenu() {
            InitializeComponent();
        }



        private void AddClick(object sender, EventArgs e) {

            if (InsertInsurant == false)
            {
                int idinsurant = 1 + Sql.CountInTable("Passport");
                string insurantFio = Insurant.Text;
                insurant = new PassPort(idinsurant, insurantFio);
                if (Sql.TryInsert("Passport", insurant)) {
                    InsertInsurant = true;
                }
            }

            if (Insertowner == false)
            {
                int idowner = 1 + Sql.CountInTable("Passport");
                string ownerFio = Proprietor.Text;
                owner = new PassPort(idowner, ownerFio);
                if (Sql.TryInsert("Passport", owner)) {
                    Insertowner = true;
                }
            }

            if (Insertcar == false)
            {
                string carMake = CarMake.Text;
                string model = Model.Text;
                string idCar = IdCar.Text;
                string gosNum = GosNum.Text;
                bool track = checkBox1.Checked;
                car = new Car(idCar, gosNum, carMake, model, track);
                if (Sql.TryInsert("Cars", car))
                {
                    Insertcar = true;
                    IdCar.BackColor = Color.White;
                }
                else
                {
                    IdCar.BackColor = Color.OrangeRed;
                    MessageBox.Show("Неверная ИН транспорта\n транспорт уже присутствует в базе");
                }
            }

            if (Insertosago == false && Insertcar == true)
            {
                string SerNum = Ser.Text + Num.Text;
                DateTime Begdate = BegDate.Value;
                DateTime Enddate = EndDate.Value;

                Int32.TryParse(Price.Text, out int price);
                DateTime conDate = ConDate.Value;

                osago = new Osago(SerNum, insurant.id, owner.id, car.id, 0, Begdate, Enddate, conDate, price);
                if (Sql.TryInsert("Osago", osago))
                {
                    Insertosago = true;
                    Ser.BackColor = Color.White;
                    Num.BackColor = Color.White;
                }
                else
                {
                    Ser.BackColor = Color.OrangeRed;
                    Num.BackColor = Color.OrangeRed;
                    MessageBox.Show("Неверная Серия или Номер Полиса ОСАГО\nТребуется изменить");
                }
            }

            if (Insertcar && Insertosago)
                Clear();
        }

    }
}
