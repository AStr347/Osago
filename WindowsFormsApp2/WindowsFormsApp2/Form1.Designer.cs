﻿namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьПолисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСерииИНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПолисToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьПолисToolStripMenuItem
            // 
            this.создатьПолисToolStripMenuItem.Name = "создатьПолисToolStripMenuItem";
            this.создатьПолисToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.создатьПолисToolStripMenuItem.Text = "Создать полис";
            this.создатьПолисToolStripMenuItem.Click += new System.EventHandler(this.AddClick);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всехToolStripMenuItem,
            this.поСерииИНомеруToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // всехToolStripMenuItem
            // 
            this.всехToolStripMenuItem.Name = "всехToolStripMenuItem";
            this.всехToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.всехToolStripMenuItem.Text = "Всех";
            // 
            // поСерииИНомеруToolStripMenuItem
            // 
            this.поСерииИНомеруToolStripMenuItem.Name = "поСерииИНомеруToolStripMenuItem";
            this.поСерииИНомеруToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.поСерииИНомеруToolStripMenuItem.Text = "По серии и номеру";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 519);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьПолисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всехToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСерииИНомеруToolStripMenuItem;
    }
}
