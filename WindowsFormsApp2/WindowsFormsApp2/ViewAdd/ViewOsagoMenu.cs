using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOsago;
using MySqlDB;
using System.Data.SqlClient;
using MyPassPort;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class ViewOsagoMenu : AbMenu
    {
        List<Osago> o = new List<Osago>();
        SqlDB Sql = SqlDB.CreRefSqlDB();
        int index = 0;

        public ViewOsagoMenu() {
            InitializeComponent();
        }

        private void Inc(object sender, EventArgs e)
        {
            if (index < o.Count - 1)
            {
                index++;
                SetText(index);
            }
        }

        private void Dec(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                SetText(index);
            }
        }

        private void SetText(int sel) {
            SqlDataReader reader;
            Ser.Text = o[sel].id.Substring(0, 3);
            Num.Text = o[sel].id.Substring(3);
            BegDateTime.Value = o[sel].BegDate;
            EndDateTime.Value = o[sel].EndDate;
            ConDate.Value = o[sel].ConDate;
            Price.Text = o[sel].Price.ToString();

            reader = Sql.SelectById("Passport", o[sel].IdInsurant);
            reader.Read();
            PassPort insurant = new PassPort(reader);
            reader.Close();
            Insurant.Text = insurant.FullName;

            reader = Sql.SelectById("Passport", o[sel].IdOwner);
            reader.Read();
            PassPort owner = new PassPort(reader);
            reader.Close();
            Proprietor.Text = owner.FullName;

            reader = Sql.SelectById("Cars", o[sel].IdCar);
            reader.Read();
            Car car = new Car(reader);
            reader.Close();
            CarNum.Text = car.GosNum;
            IdCar.Text = car.id;
            Model.Text = car.Model;
            Mark.Text = car.Mark;
            Track.Checked = car.track;

            Prev.Visible = index != 0;
            Next.Visible = index != (o.Count - 1);

        }

        override public Control Draw() {
            index = 0;
            o.Clear();
            SqlDataReader reader = Sql.SelctAll("Osago");
            if (reader != null)
            {
                while (reader.Read())
                {
                    o.Add(new Osago(reader));
                }
                reader.Close();

                SetText(index);
            }
            else
                MessageBox.Show("В базе отсутствуют полисы Осаго");

            return MainPanel;
        }

    }
}
