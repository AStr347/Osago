using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class OsagoAddMenu : AbMenu
    {
        private void Clear()
        {
            Insertcar = false;
            Insertosago = false;
            InsertInsurant = false;
            Insertowner = false;
            this.Ser.Text = "";
            this.Num.Text = "";
            Ser.BackColor = Color.White;
            Num.BackColor = Color.White;
            this.BegDate.Text = "";
            this.EndDate.Text = "";
            this.Insurant.Text = "";
            this.Proprietor.Text = "";
            this.CarMake.Text = "";
            this.Model.Text = "";
            this.IdCar.Text = "";
            IdCar.BackColor = Color.White;
            this.newOsagoTop.Text = "";
            this.newOsagoFIO.Text = "";
            this.GosNum.Text = "";
            this.checkBox1.Checked = false;
            this.newOsagoCar.Text = "";
            this.Price.Text = "";
            this.ConDate.Text = "";
        }

        public void Dispose()
        {
            this.Ser.Dispose();
            this.Num.Dispose();
            this.BegDate.Dispose();
            this.EndDate.Dispose();
            this.Insurant.Dispose();
            this.Proprietor.Dispose();
            this.CarMake.Dispose();
            this.Model.Dispose();
            this.IdCar.Dispose();
            this.label1.Dispose();
            this.label2.Dispose();
            this.label3.Dispose();
            this.label4.Dispose();
            this.label5.Dispose();
            this.label6.Dispose();
            this.label7.Dispose();
            this.newOsagoTop.Dispose();
            this.newOsagoFIO.Dispose();
            this.label8.Dispose();
            this.label9.Dispose();
            this.label10.Dispose();
            this.GosNum.Dispose();
            this.checkBox1.Dispose();
            this.newOsagoCar.Dispose();
            this.label11.Dispose();
            this.Price.Dispose();
            this.ConDate.Dispose();
            this.label12.Dispose();
            this.newOsagoBot.Dispose();
            this.MainPanel.Dispose();
            this.button.Dispose();
            this.newOsagoTop.Dispose();
            this.newOsagoFIO.Dispose();
            this.newOsagoCar.Dispose();
            this.newOsagoBot.Dispose();
            this.MainPanel.Dispose();
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ser = new TextBox();
            this.Num = new TextBox();
            this.BegDate = new DateTimePicker();
            this.EndDate = new DateTimePicker();
            this.Insurant = new TextBox();
            this.Proprietor = new TextBox();
            this.CarMake = new TextBox();
            this.Model = new TextBox();
            this.IdCar = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.newOsagoTop = new Panel();
            this.newOsagoFIO = new Panel();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.GosNum = new TextBox();
            this.checkBox1 = new CheckBox();
            this.newOsagoCar = new Panel();
            this.label11 = new Label();
            this.Price = new TextBox();
            this.ConDate = new DateTimePicker();
            this.label12 = new Label();
            this.newOsagoBot = new Panel();
            this.MainPanel = new Panel();
            this.button = new Button();
            this.newOsagoTop.SuspendLayout();
            this.newOsagoFIO.SuspendLayout();
            this.newOsagoCar.SuspendLayout();
            this.newOsagoBot.SuspendLayout();
            this.MainPanel.SuspendLayout();
            //this.SuspendLayout();

            // 
            // Ser
            // 
            this.Ser.Location = new Point(48, 14);
            this.Ser.MaxLength = 3;
            this.Ser.Name = "Ser";
            this.Ser.Size = new Size(47, 20);
            this.Ser.TabIndex = 1;
            // 
            // Num
            // 
            this.Num.Location = new Point(150, 14);
            this.Num.MaxLength = 10;
            this.Num.Name = "Num";
            this.Num.Size = new Size(100, 20);
            this.Num.TabIndex = 2;
            // 
            // BegDate
            // 
            this.BegDate.Location = new Point(419, 14);
            this.BegDate.Name = "BegDate";
            this.BegDate.Size = new Size(140, 20);
            this.BegDate.TabIndex = 3;
            // 
            // EndDate
            // 
            this.EndDate.Location = new Point(419, 47);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new Size(140, 20);
            this.EndDate.TabIndex = 4;
            // 
            // Insurant
            // 
            this.Insurant.Location = new Point(95, 14);
            this.Insurant.MaxLength = 60;
            this.Insurant.Name = "Insurant";
            this.Insurant.Size = new Size(231, 20);
            this.Insurant.TabIndex = 5;
            // 
            // Proprietor
            // 
            this.Proprietor.Location = new Point(95, 50);
            this.Proprietor.MaxLength = 60;
            this.Proprietor.Name = "Proprietor";
            this.Proprietor.Size = new Size(231, 20);
            this.Proprietor.TabIndex = 6;
            // 
            // CarMake
            // 
            this.CarMake.Location = new Point(59, 17);
            this.CarMake.Name = "CarMake";
            this.CarMake.Size = new Size(169, 20);
            this.CarMake.TabIndex = 7;
            // 
            // Model
            // 
            this.Model.Location = new Point(292, 17);
            this.Model.Name = "Model";
            this.Model.Size = new Size(169, 20);
            this.Model.TabIndex = 8;
            // 
            // IdCar
            // 
            this.IdCar.Location = new Point(103, 50);
            this.IdCar.Name = "IdCar";
            this.IdCar.Size = new Size(169, 20);
            this.IdCar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Серия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(103, 18);
            this.label2.Name = "label2";
            this.label2.Size = new Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(306, 18);
            this.label3.Name = "label3";
            this.label3.Size = new Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "срок страхования с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(394, 53);
            this.label4.Name = "label4";
            this.label4.Size = new Size(19, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "по";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Страхователь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Собственник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Марка";
            // 
            // newOsagoTop
            // 
            this.newOsagoTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newOsagoTop.Controls.Add(this.Ser);
            this.newOsagoTop.Controls.Add(this.label1);
            this.newOsagoTop.Controls.Add(this.Num);
            this.newOsagoTop.Controls.Add(this.label2);
            this.newOsagoTop.Controls.Add(this.label4);
            this.newOsagoTop.Controls.Add(this.label3);
            this.newOsagoTop.Controls.Add(this.BegDate);
            this.newOsagoTop.Controls.Add(this.EndDate);
            this.newOsagoTop.Location = new Point(26, 21);
            this.newOsagoTop.Name = "newOsagoTop";
            this.newOsagoTop.Size = new Size(573, 81);
            this.newOsagoTop.TabIndex = 17;
            // 
            // newOsagoFIO
            // 
            this.newOsagoFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newOsagoFIO.Controls.Add(this.label5);
            this.newOsagoFIO.Controls.Add(this.Insurant);
            this.newOsagoFIO.Controls.Add(this.Proprietor);
            this.newOsagoFIO.Controls.Add(this.label6);
            this.newOsagoFIO.Location = new Point(26, 118);
            this.newOsagoFIO.Name = "newOsagoFIO";
            this.newOsagoFIO.Size = new Size(573, 89);
            this.newOsagoFIO.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(246, 20);
            this.label8.Name = "label8";
            this.label8.Size = new Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Модель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new Size(84, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ИН транспорта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new Point(297, 53);
            this.label10.Name = "label10";
            this.label10.Size = new Size(79, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Гос. Рег. знак";
            // 
            // GosNum
            // 
            this.GosNum.Location = new Point(382, 50);
            this.GosNum.Name = "GosNum";
            this.GosNum.Size = new Size(169, 20);
            this.GosNum.TabIndex = 22;
            // 
            // Track
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(16, 85);
            this.checkBox1.Name = "Track";
            this.checkBox1.Size = new Size(142, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Транспорт с прицепом";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // newOsagoCar
            // 
            this.newOsagoCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newOsagoCar.Controls.Add(this.CarMake);
            this.newOsagoCar.Controls.Add(this.checkBox1);
            this.newOsagoCar.Controls.Add(this.Model);
            this.newOsagoCar.Controls.Add(this.GosNum);
            this.newOsagoCar.Controls.Add(this.IdCar);
            this.newOsagoCar.Controls.Add(this.label10);
            this.newOsagoCar.Controls.Add(this.label7);
            this.newOsagoCar.Controls.Add(this.label9);
            this.newOsagoCar.Controls.Add(this.label8);
            this.newOsagoCar.Location = new Point(26, 219);
            this.newOsagoCar.Name = "newOsagoCar";
            this.newOsagoCar.Size = new Size(573, 117);
            this.newOsagoCar.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new Point(10, 21);
            this.label11.Name = "label11";
            this.label11.Size = new Size(101, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Страховая премия";
            // 
            // Price
            // 
            this.Price.Location = new Point(129, 18);
            this.Price.Name = "Price";
            this.Price.Size = new Size(144, 20);
            this.Price.TabIndex = 26;
            // 
            // ConDate
            // 
            this.ConDate.Location = new Point(420, 18);
            this.ConDate.Name = "ConDate";
            this.ConDate.Size = new Size(140, 20);
            this.ConDate.TabIndex = 27;
            //
            // button
            //
            this.button.Location = new Point(420, 45);
            this.button.Name = "Button";
            this.button.Text = "Добавить";
            this.button.Size = new Size(100, 25);
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.AddClick);
            this.button.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new Point(317, 21);
            this.label12.Name = "label12";
            this.label12.Size = new Size(97, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Дата заключения";
            // 
            // newOsagoBot
            // 
            this.newOsagoBot.Controls.Add(this.label11);
            this.newOsagoBot.Controls.Add(this.label12);
            this.newOsagoBot.Controls.Add(this.Price);
            this.newOsagoBot.Controls.Add(this.ConDate);
            this.newOsagoBot.Controls.Add(this.button);
            this.newOsagoBot.Location = new Point(26, 351);
            this.newOsagoBot.Name = "newOsagoBot";
            this.newOsagoBot.Size = new Size(573, 85);
            this.newOsagoBot.TabIndex = 29;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.newOsagoBot);
            this.MainPanel.Controls.Add(this.newOsagoTop);
            this.MainPanel.Controls.Add(this.newOsagoCar);
            this.MainPanel.Controls.Add(this.newOsagoFIO);
            this.MainPanel.Location = new Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new Size(624, 440);
            this.MainPanel.TabIndex = 30;

            //this.Controls.Add(this.MainPanel);


            this.newOsagoTop.ResumeLayout(false);
            this.newOsagoTop.PerformLayout();
            this.newOsagoFIO.ResumeLayout(false);
            this.newOsagoFIO.PerformLayout();
            this.newOsagoCar.ResumeLayout(false);
            this.newOsagoCar.PerformLayout();
            this.newOsagoBot.ResumeLayout(false);
            this.newOsagoBot.PerformLayout();
            this.MainPanel.ResumeLayout(false);
        }


        private TextBox Ser;
        private TextBox Num;
        private DateTimePicker BegDate;
        private DateTimePicker EndDate;

        private TextBox Insurant;
        private TextBox Proprietor;

        private TextBox CarMake;
        private TextBox Model;
        private TextBox IdCar;
        private TextBox GosNum;
        private CheckBox checkBox1;

        private TextBox Price;
        private DateTimePicker ConDate;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;

        private Button button;

        private Panel newOsagoTop;
        private Panel newOsagoFIO;
        private Panel newOsagoCar;
        private Panel newOsagoBot;
        

    }
}
