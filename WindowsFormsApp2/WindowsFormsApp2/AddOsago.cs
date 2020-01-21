using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlDB;
using MyPassPort;
using MyOsago;
namespace WindowsFormsApp2
{
    public partial class AddOsago : Form
    {
        SqlDB Sql = SqlDB.CreRefSqlDB();
        PassPort Strah, Strahu, CarMan;
        Car car;
        public AddOsago()
        {
            InitializeComponent();
        }

        private void UrFace_CheckedChanged(object sender, EventArgs e)
        {
            URFase.Visible = UrFace.Checked;
            FizFace.Visible = !UrFace.Checked;
        }

        private void InsertPassPorts() {
            

            int id = Sql.CountInTable("Insurant") + 1;
            string[] s;

            if (true == UrFace.Checked)
            {
                s = new string[] { INN.Text, OGRN.Text, OPForm.SelectedItem.ToString(), schet.Text };
            }
            else
            {
                s = new string[] { SerNumPass.Text, SerNumVod.Text, Who.Text, Address.Text, dateTimePicker0.Value.ToShortDateString() };
            }

            Strah = new PassPort(id, FullName.Text, UrFace.Checked);
            Strah.Init(s);

            id = Sql.CountInTable("Owner") + 1;
            s = new string[] { SerNumStrahu.Text, SerNumVodStrahu.Text, WhoStrahu.Text, AddressStrahu.Text, dateTimePicker1.Value.ToShortDateString() };

            Strahu = new PassPort(id, FullName.Text, false);
            Strahu.Init(s);

            Sql.TryInsert("Insurant", Strah);
            Sql.TryInsert("Owner", Strahu);
        }

        private void InsertCar() {
            car = new Car(Vin.Text, Gosnum.Text, Mark.Text, Model.Text, Track.Checked, EnginePow.Text, VEngine.Text);
            Sql.TryInsert("Cars", car);
        }

        private void InsertOsago() {
            Osago osago = new Osago(Ser.Text + Num.Text, Strah.id, Strahu.id, car.id, "0", begdate.Value, enddate.Value, dateCon.Value, Convert.ToInt32(Price.Text));
            Sql.TryInsert("Osago", osago);
        }


        private void Add(object sender, EventArgs e) {
            InsertPassPorts();
            InsertCar();
            InsertOsago();
            this.Close();
        }
    }
}
