namespace WindowsFormsApp2
{
    partial class AddOsago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ser = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.TextBox();
            this.begdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.UrFace = new System.Windows.Forms.CheckBox();
            this.OGRN = new System.Windows.Forms.TextBox();
            this.OPForm = new System.Windows.Forms.ComboBox();
            this.schet = new System.Windows.Forms.TextBox();
            this.URFase = new System.Windows.Forms.Panel();
            this.FizFace = new System.Windows.Forms.Panel();
            this.SerNumVod = new System.Windows.Forms.TextBox();
            this.SerNumPass = new System.Windows.Forms.TextBox();
            this.Who = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.dateTimePicker0 = new System.Windows.Forms.DateTimePicker();
            this.Car = new System.Windows.Forms.Panel();
            this.VEngine = new System.Windows.Forms.TextBox();
            this.EnginePow = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CarV = new System.Windows.Forms.Panel();
            this.FioCar = new System.Windows.Forms.TextBox();
            this.SerNumFaceCar = new System.Windows.Forms.TextBox();
            this.WhoCar = new System.Windows.Forms.TextBox();
            this.AddressCar = new System.Windows.Forms.TextBox();
            this.dateRegCar = new System.Windows.Forms.DateTimePicker();
            this.Vin = new System.Windows.Forms.TextBox();
            this.Gosnum = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Mark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SerNumVodStrahu = new System.Windows.Forms.TextBox();
            this.FullNameStrahu = new System.Windows.Forms.TextBox();
            this.SerNumStrahu = new System.Windows.Forms.TextBox();
            this.WhoStrahu = new System.Windows.Forms.TextBox();
            this.AddressStrahu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.TextBox();
            this.dateCon = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Track = new System.Windows.Forms.CheckBox();
            this.URFase.SuspendLayout();
            this.FizFace.SuspendLayout();
            this.Car.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CarV.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ser
            // 
            this.Ser.Location = new System.Drawing.Point(21, 15);
            this.Ser.Name = "Ser";
            this.Ser.Size = new System.Drawing.Size(100, 20);
            this.Ser.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(151, 15);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(235, 20);
            this.Num.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(21, 80);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(240, 20);
            this.FullName.TabIndex = 3;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(24, 29);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(130, 20);
            this.INN.TabIndex = 14;
            // 
            // begdate
            // 
            this.begdate.Location = new System.Drawing.Point(595, 12);
            this.begdate.Name = "begdate";
            this.begdate.Size = new System.Drawing.Size(139, 20);
            this.begdate.TabIndex = 16;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(595, 38);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(139, 20);
            this.enddate.TabIndex = 17;
            // 
            // UrFace
            // 
            this.UrFace.AutoSize = true;
            this.UrFace.Location = new System.Drawing.Point(375, 80);
            this.UrFace.Name = "UrFace";
            this.UrFace.Size = new System.Drawing.Size(121, 17);
            this.UrFace.TabIndex = 18;
            this.UrFace.Text = "Юридическое лицо";
            this.UrFace.UseVisualStyleBackColor = true;
            this.UrFace.CheckedChanged += new System.EventHandler(this.UrFace_CheckedChanged);
            // 
            // OGRN
            // 
            this.OGRN.Location = new System.Drawing.Point(179, 29);
            this.OGRN.Name = "OGRN";
            this.OGRN.Size = new System.Drawing.Size(123, 20);
            this.OGRN.TabIndex = 19;
            // 
            // OPForm
            // 
            this.OPForm.FormattingEnabled = true;
            this.OPForm.Location = new System.Drawing.Point(378, 29);
            this.OPForm.Name = "OPForm";
            this.OPForm.Size = new System.Drawing.Size(121, 21);
            this.OPForm.TabIndex = 20;
            this.OPForm.Visible = false;
            // 
            // schet
            // 
            this.schet.Location = new System.Drawing.Point(24, 71);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(130, 20);
            this.schet.TabIndex = 21;
            // 
            // URFase
            // 
            this.URFase.Controls.Add(this.schet);
            this.URFase.Controls.Add(this.OPForm);
            this.URFase.Controls.Add(this.INN);
            this.URFase.Controls.Add(this.OGRN);
            this.URFase.Location = new System.Drawing.Point(-3, 120);
            this.URFase.Name = "URFase";
            this.URFase.Size = new System.Drawing.Size(749, 123);
            this.URFase.TabIndex = 22;
            this.URFase.Visible = false;
            // 
            // FizFace
            // 
            this.FizFace.Controls.Add(this.SerNumVod);
            this.FizFace.Controls.Add(this.SerNumPass);
            this.FizFace.Controls.Add(this.Who);
            this.FizFace.Controls.Add(this.Address);
            this.FizFace.Controls.Add(this.dateTimePicker0);
            this.FizFace.Location = new System.Drawing.Point(0, 117);
            this.FizFace.Name = "FizFace";
            this.FizFace.Size = new System.Drawing.Size(749, 123);
            this.FizFace.TabIndex = 28;
            // 
            // SerNumVod
            // 
            this.SerNumVod.Location = new System.Drawing.Point(24, 84);
            this.SerNumVod.Name = "SerNumVod";
            this.SerNumVod.Size = new System.Drawing.Size(167, 20);
            this.SerNumVod.TabIndex = 28;
            // 
            // SerNumPass
            // 
            this.SerNumPass.Location = new System.Drawing.Point(24, 13);
            this.SerNumPass.Name = "SerNumPass";
            this.SerNumPass.Size = new System.Drawing.Size(278, 20);
            this.SerNumPass.TabIndex = 23;
            // 
            // Who
            // 
            this.Who.Location = new System.Drawing.Point(24, 58);
            this.Who.Name = "Who";
            this.Who.Size = new System.Drawing.Size(278, 20);
            this.Who.TabIndex = 27;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(378, 58);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(278, 20);
            this.Address.TabIndex = 25;
            // 
            // dateTimePicker0
            // 
            this.dateTimePicker0.Location = new System.Drawing.Point(378, 13);
            this.dateTimePicker0.Name = "dateTimePicker0";
            this.dateTimePicker0.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker0.TabIndex = 26;
            // 
            // Car
            // 
            this.Car.Controls.Add(this.Track);
            this.Car.Controls.Add(this.VEngine);
            this.Car.Controls.Add(this.EnginePow);
            this.Car.Controls.Add(this.panel2);
            this.Car.Controls.Add(this.CarV);
            this.Car.Controls.Add(this.Vin);
            this.Car.Controls.Add(this.Gosnum);
            this.Car.Controls.Add(this.Model);
            this.Car.Controls.Add(this.Mark);
            this.Car.Location = new System.Drawing.Point(0, 409);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(749, 228);
            this.Car.TabIndex = 29;
            // 
            // VEngine
            // 
            this.VEngine.Location = new System.Drawing.Point(583, 21);
            this.VEngine.Name = "VEngine";
            this.VEngine.Size = new System.Drawing.Size(96, 20);
            this.VEngine.TabIndex = 32;
            // 
            // EnginePow
            // 
            this.EnginePow.Location = new System.Drawing.Point(378, 21);
            this.EnginePow.Name = "EnginePow";
            this.EnginePow.Size = new System.Drawing.Size(100, 20);
            this.EnginePow.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 123);
            this.panel2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(278, 20);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(378, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(278, 20);
            this.textBox6.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(378, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // CarV
            // 
            this.CarV.Controls.Add(this.FioCar);
            this.CarV.Controls.Add(this.SerNumFaceCar);
            this.CarV.Controls.Add(this.WhoCar);
            this.CarV.Controls.Add(this.AddressCar);
            this.CarV.Controls.Add(this.dateRegCar);
            this.CarV.Location = new System.Drawing.Point(0, 103);
            this.CarV.Name = "CarV";
            this.CarV.Size = new System.Drawing.Size(749, 123);
            this.CarV.TabIndex = 30;
            // 
            // FioCar
            // 
            this.FioCar.Location = new System.Drawing.Point(24, 22);
            this.FioCar.Name = "FioCar";
            this.FioCar.Size = new System.Drawing.Size(278, 20);
            this.FioCar.TabIndex = 28;
            // 
            // SerNumFaceCar
            // 
            this.SerNumFaceCar.Location = new System.Drawing.Point(24, 48);
            this.SerNumFaceCar.Name = "SerNumFaceCar";
            this.SerNumFaceCar.Size = new System.Drawing.Size(278, 20);
            this.SerNumFaceCar.TabIndex = 23;
            // 
            // WhoCar
            // 
            this.WhoCar.Location = new System.Drawing.Point(24, 89);
            this.WhoCar.Name = "WhoCar";
            this.WhoCar.Size = new System.Drawing.Size(278, 20);
            this.WhoCar.TabIndex = 27;
            // 
            // AddressCar
            // 
            this.AddressCar.Location = new System.Drawing.Point(378, 89);
            this.AddressCar.Name = "AddressCar";
            this.AddressCar.Size = new System.Drawing.Size(278, 20);
            this.AddressCar.TabIndex = 25;
            // 
            // dateRegCar
            // 
            this.dateRegCar.Location = new System.Drawing.Point(378, 48);
            this.dateRegCar.Name = "dateRegCar";
            this.dateRegCar.Size = new System.Drawing.Size(200, 20);
            this.dateRegCar.TabIndex = 26;
            // 
            // Vin
            // 
            this.Vin.Location = new System.Drawing.Point(378, 61);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(245, 20);
            this.Vin.TabIndex = 3;
            // 
            // Gosnum
            // 
            this.Gosnum.Location = new System.Drawing.Point(202, 21);
            this.Gosnum.Name = "Gosnum";
            this.Gosnum.Size = new System.Drawing.Size(100, 20);
            this.Gosnum.TabIndex = 2;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(24, 61);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(130, 20);
            this.Model.TabIndex = 1;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(24, 21);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(130, 20);
            this.Mark.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SerNumVodStrahu);
            this.panel1.Controls.Add(this.FullNameStrahu);
            this.panel1.Controls.Add(this.SerNumStrahu);
            this.panel1.Controls.Add(this.WhoStrahu);
            this.panel1.Controls.Add(this.AddressStrahu);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-3, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 150);
            this.panel1.TabIndex = 30;
            // 
            // SerNumVodStrahu
            // 
            this.SerNumVodStrahu.Location = new System.Drawing.Point(24, 116);
            this.SerNumVodStrahu.Name = "SerNumVodStrahu";
            this.SerNumVodStrahu.Size = new System.Drawing.Size(170, 20);
            this.SerNumVodStrahu.TabIndex = 29;
            // 
            // FullNameStrahu
            // 
            this.FullNameStrahu.Location = new System.Drawing.Point(24, 3);
            this.FullNameStrahu.Name = "FullNameStrahu";
            this.FullNameStrahu.Size = new System.Drawing.Size(240, 20);
            this.FullNameStrahu.TabIndex = 28;
            // 
            // SerNumStrahu
            // 
            this.SerNumStrahu.Location = new System.Drawing.Point(24, 45);
            this.SerNumStrahu.Name = "SerNumStrahu";
            this.SerNumStrahu.Size = new System.Drawing.Size(278, 20);
            this.SerNumStrahu.TabIndex = 23;
            // 
            // WhoStrahu
            // 
            this.WhoStrahu.Location = new System.Drawing.Point(24, 90);
            this.WhoStrahu.Name = "WhoStrahu";
            this.WhoStrahu.Size = new System.Drawing.Size(278, 20);
            this.WhoStrahu.TabIndex = 27;
            // 
            // AddressStrahu
            // 
            this.AddressStrahu.Location = new System.Drawing.Point(378, 90);
            this.AddressStrahu.Name = "AddressStrahu";
            this.AddressStrahu.Size = new System.Drawing.Size(278, 20);
            this.AddressStrahu.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.YD,
            this.Class});
            this.dataGridView1.Location = new System.Drawing.Point(176, 655);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 86);
            this.dataGridView1.TabIndex = 31;
            // 
            // Fio
            // 
            this.Fio.HeaderText = "Fio";
            this.Fio.Name = "Fio";
            // 
            // YD
            // 
            this.YD.HeaderText = "YD";
            this.YD.Name = "YD";
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(24, 773);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(240, 20);
            this.Price.TabIndex = 32;
            // 
            // dateCon
            // 
            this.dateCon.Location = new System.Drawing.Point(378, 770);
            this.dateCon.Name = "dateCon";
            this.dateCon.Size = new System.Drawing.Size(200, 20);
            this.dateCon.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 773);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add);
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Location = new System.Drawing.Point(641, 61);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(64, 17);
            this.Track.TabIndex = 33;
            this.Track.Text = "Прицеп";
            this.Track.UseVisualStyleBackColor = true;
            // 
            // AddOsago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 910);
            this.Controls.Add(this.FizFace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateCon);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.URFase);
            this.Controls.Add(this.UrFace);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.begdate);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Ser);
            this.Name = "AddOsago";
            this.Text = "AddOsago";
            this.URFase.ResumeLayout(false);
            this.URFase.PerformLayout();
            this.FizFace.ResumeLayout(false);
            this.FizFace.PerformLayout();
            this.Car.ResumeLayout(false);
            this.Car.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CarV.ResumeLayout(false);
            this.CarV.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ser;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.DateTimePicker begdate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.CheckBox UrFace;
        private System.Windows.Forms.TextBox OGRN;
        private System.Windows.Forms.ComboBox OPForm;
        private System.Windows.Forms.TextBox schet;
        private System.Windows.Forms.Panel URFase;
        private System.Windows.Forms.Panel FizFace;
        private System.Windows.Forms.TextBox SerNumPass;
        private System.Windows.Forms.TextBox Who;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker0;
        private System.Windows.Forms.Panel Car;
        private System.Windows.Forms.TextBox VEngine;
        private System.Windows.Forms.TextBox EnginePow;
        private System.Windows.Forms.Panel CarV;
        private System.Windows.Forms.TextBox FioCar;
        private System.Windows.Forms.TextBox SerNumFaceCar;
        private System.Windows.Forms.TextBox WhoCar;
        private System.Windows.Forms.TextBox AddressCar;
        private System.Windows.Forms.DateTimePicker dateRegCar;
        private System.Windows.Forms.TextBox Vin;
        private System.Windows.Forms.TextBox Gosnum;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Mark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SerNumStrahu;
        private System.Windows.Forms.TextBox WhoStrahu;
        private System.Windows.Forms.TextBox AddressStrahu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn YD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.DateTimePicker dateCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SerNumVod;
        private System.Windows.Forms.TextBox FullNameStrahu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox SerNumVodStrahu;
        private System.Windows.Forms.CheckBox Track;
    }
}