using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class ViewOsagoDB : AbMenu
    {

        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInsurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Location = new System.Drawing.Point(12, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(759, 480);
            this.MainPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Num,
            this.IdInsurant,
            this.IdOwner,
            this.IdCar,
            this.BegDate,
            this.EndDate,
            this.ConDate,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ser";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 48;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 54;
            // 
            // IdInsurant
            // 
            this.IdInsurant.HeaderText = "IdInsurant";
            this.IdInsurant.Name = "IdInsurant";
            this.IdInsurant.ReadOnly = true;
            this.IdInsurant.Width = 79;
            // 
            // IdOwner
            // 
            this.IdOwner.HeaderText = "IdOwner";
            this.IdOwner.Name = "IdOwner";
            this.IdOwner.ReadOnly = true;
            this.IdOwner.Width = 72;
            // 
            // IdCar
            // 
            this.IdCar.HeaderText = "IdCar";
            this.IdCar.Name = "IdCar";
            this.IdCar.ReadOnly = true;
            this.IdCar.Width = 57;
            // 
            // BegDate
            // 
            this.BegDate.HeaderText = "BegDate";
            this.BegDate.Name = "BegDate";
            this.BegDate.ReadOnly = true;
            this.BegDate.Width = 74;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 74;
            // 
            // ConDate
            // 
            this.ConDate.HeaderText = "ConDate";
            this.ConDate.Name = "ConDate";
            this.ConDate.ReadOnly = true;
            this.ConDate.Width = 74;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 56;

            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

        }


        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsurant;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
