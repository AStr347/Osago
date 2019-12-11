using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class ViewOsagoMenu : AbMenu
    {
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new Label(); ;
            this.MainPanel = new Panel();
            this.Prev = new Button();
            this.Next = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.OsagoTop = new Panel();
            this.Ser = new TextBox();
            this.Num = new TextBox();
            this.BegDateTime = new DateTimePicker();
            this.EndDateTime = new DateTimePicker();
            this.OsagoFio = new Panel();
            this.label5 = new Label();
            this.label6 = new Label();
            this.Insurant = new TextBox();
            this.Proprietor = new TextBox();
            this.OsagoBot = new Panel();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.Track = new CheckBox();
            this.Mark = new TextBox();
            this.Model = new TextBox();
            this.IdCar = new TextBox();
            this.CarNum = new TextBox();
            this.label12 = new Label();
            this.Price = new TextBox();
            this.ConDate = new DateTimePicker();
            label11 = new Label();
            this.MainPanel.SuspendLayout();
            this.OsagoTop.SuspendLayout();
            this.OsagoFio.SuspendLayout();
            this.OsagoBot.SuspendLayout();
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(14, 441);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(75, 23);
            this.Prev.TabIndex = 0;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += Dec;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(671, 441);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += Inc;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Серия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок страхования с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "По";
            // 
            // OsagoTop
            // 
            this.OsagoTop.BorderStyle = BorderStyle.FixedSingle;
            this.OsagoTop.Controls.Add(this.EndDateTime);
            this.OsagoTop.Controls.Add(this.BegDateTime);
            this.OsagoTop.Controls.Add(this.Num);
            this.OsagoTop.Controls.Add(this.Ser);
            this.OsagoTop.Controls.Add(this.label1);
            this.OsagoTop.Controls.Add(this.label4);
            this.OsagoTop.Controls.Add(this.label2);
            this.OsagoTop.Controls.Add(this.label3);
            this.OsagoTop.Location = new System.Drawing.Point(14, 18);
            this.OsagoTop.Name = "OsagoTop";
            this.OsagoTop.Size = new System.Drawing.Size(722, 100);
            this.OsagoTop.TabIndex = 6;
            // 
            // Ser
            // 
            this.Ser.Location = new System.Drawing.Point(57, 10);
            this.Ser.Name = "Ser";
            this.Ser.ReadOnly = true;
            this.Ser.Size = new System.Drawing.Size(100, 20);
            this.Ser.TabIndex = 6;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(211, 10);
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Size = new System.Drawing.Size(146, 20);
            this.Num.TabIndex = 7;
            // 
            // BegDateTime
            // 
            this.BegDateTime.Location = new System.Drawing.Point(539, 10);
            this.BegDateTime.Name = "BegDateTime";
            this.BegDateTime.Size = new System.Drawing.Size(156, 20);
            this.BegDateTime.TabIndex = 8;
            // 
            // EndDateTime
            // 
            this.EndDateTime.Location = new System.Drawing.Point(539, 50);
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.Size = new System.Drawing.Size(156, 20);
            this.EndDateTime.TabIndex = 9;
            // 
            // OsagoFio
            // 
            this.OsagoFio.BorderStyle = BorderStyle.FixedSingle;
            this.OsagoFio.Controls.Add(this.Proprietor);
            this.OsagoFio.Controls.Add(this.Insurant);
            this.OsagoFio.Controls.Add(this.label6);
            this.OsagoFio.Controls.Add(this.label5);
            this.OsagoFio.Location = new System.Drawing.Point(14, 124);
            this.OsagoFio.Name = "OsagoFio";
            this.OsagoFio.Size = new System.Drawing.Size(722, 83);
            this.OsagoFio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Страхователь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Собственник";
            // 
            // Insurant
            // 
            this.Insurant.Location = new System.Drawing.Point(105, 13);
            this.Insurant.Name = "Insurant";
            this.Insurant.ReadOnly = true;
            this.Insurant.Size = new System.Drawing.Size(203, 20);
            this.Insurant.TabIndex = 2;
            // 
            // Proprietor
            // 
            this.Proprietor.Location = new System.Drawing.Point(104, 48);
            this.Proprietor.Name = "Proprietor";
            this.Proprietor.ReadOnly = true;
            this.Proprietor.Size = new System.Drawing.Size(203, 20);
            this.Proprietor.TabIndex = 3;
            // 
            // OsagoBot
            // 
            this.OsagoBot.BorderStyle = BorderStyle.FixedSingle;
            this.OsagoBot.Controls.Add(this.CarNum);
            this.OsagoBot.Controls.Add(this.IdCar);
            this.OsagoBot.Controls.Add(this.Model);
            this.OsagoBot.Controls.Add(this.Mark);
            this.OsagoBot.Controls.Add(this.Track);
            this.OsagoBot.Controls.Add(this.label10);
            this.OsagoBot.Controls.Add(this.label9);
            this.OsagoBot.Controls.Add(this.label8);
            this.OsagoBot.Controls.Add(this.label7);
            this.OsagoBot.Location = new System.Drawing.Point(14, 213);
            this.OsagoBot.Name = "OsagoBot";
            this.OsagoBot.Size = new System.Drawing.Size(722, 118);
            this.OsagoBot.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Марка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Модель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "ИН транспорта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Гос. Рег. Знак";
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Location = new System.Drawing.Point(19, 88);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(136, 17);
            this.Track.TabIndex = 4;
            this.Track.Text = "Транспорт с прицеом";
            this.Track.UseVisualStyleBackColor = true;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(105, 9);
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Size = new System.Drawing.Size(203, 20);
            this.Mark.TabIndex = 5;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(418, 12);
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Size = new System.Drawing.Size(203, 20);
            this.Model.TabIndex = 6;
            // 
            // IdCar
            // 
            this.IdCar.Location = new System.Drawing.Point(104, 47);
            this.IdCar.Name = "IdCar";
            this.IdCar.ReadOnly = true;
            this.IdCar.Size = new System.Drawing.Size(203, 20);
            this.IdCar.TabIndex = 7;
            // 
            // CarNum
            // 
            this.CarNum.Location = new System.Drawing.Point(447, 47);
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            this.CarNum.Size = new System.Drawing.Size(203, 20);
            this.CarNum.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(28, 364);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(101, 13);
            label11.TabIndex = 9;
            label11.Text = "Страховая премия";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Дата заключения";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(148, 361);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(135, 20);
            this.Price.TabIndex = 11;
            // 
            // ConDate
            // 
            this.ConDate.Location = new System.Drawing.Point(554, 361);
            this.ConDate.Name = "ConDate";
            this.ConDate.Size = new System.Drawing.Size(156, 20);
            this.ConDate.TabIndex = 12;

            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ConDate);
            this.MainPanel.Controls.Add(this.Price);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(label11);
            this.MainPanel.Controls.Add(this.OsagoBot);
            this.MainPanel.Controls.Add(this.OsagoFio);
            this.MainPanel.Controls.Add(this.OsagoTop);
            this.MainPanel.Controls.Add(this.Next);
            this.MainPanel.Controls.Add(this.Prev);
            this.MainPanel.Location = new System.Drawing.Point(12, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(759, 480);
            this.MainPanel.TabIndex = 1;


            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.OsagoTop.ResumeLayout(false);
            this.OsagoTop.PerformLayout();
            this.OsagoFio.ResumeLayout(false);
            this.OsagoFio.PerformLayout();
            this.OsagoBot.ResumeLayout(false);
            this.OsagoBot.PerformLayout();

        }

        private TextBox Num;
        private TextBox Ser;
        private DateTimePicker EndDateTime;
        private DateTimePicker BegDateTime;

        private TextBox Proprietor;
        private TextBox Insurant;

        private TextBox CarNum;
        private TextBox IdCar;
        private TextBox Model;
        private TextBox Mark;
        private CheckBox Track;

        private Button Next;
        private Button Prev;
        private DateTimePicker ConDate;
        private TextBox Price;


        private Panel OsagoTop;
        private Panel OsagoFio;
        private Panel OsagoBot;

        private Label label2;
        private Label label1;
        private Label label12;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;       
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
