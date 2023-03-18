
namespace WindowsFormsApp1
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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButtonSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearButtonSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBottonSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpBottonSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelStatusSplit = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ExitBottonSplit,
            this.HelpBottonSplit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButtonSplit,
            this.ClearButtonSplit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenButtonSplit
            // 
            this.OpenButtonSplit.Name = "OpenButtonSplit";
            this.OpenButtonSplit.Size = new System.Drawing.Size(121, 22);
            this.OpenButtonSplit.Text = "Открыть";
            this.OpenButtonSplit.Click += new System.EventHandler(this.OpenButtonSplit_Click);
            // 
            // ClearButtonSplit
            // 
            this.ClearButtonSplit.Name = "ClearButtonSplit";
            this.ClearButtonSplit.Size = new System.Drawing.Size(121, 22);
            this.ClearButtonSplit.Text = "Закрыть";
            this.ClearButtonSplit.Click += new System.EventHandler(this.ClearButtonSplit_Click);
            // 
            // ExitBottonSplit
            // 
            this.ExitBottonSplit.Name = "ExitBottonSplit";
            this.ExitBottonSplit.Size = new System.Drawing.Size(51, 20);
            this.ExitBottonSplit.Text = "Назад";
            this.ExitBottonSplit.Click += new System.EventHandler(this.ExitBottonSplit_Click);
            // 
            // HelpBottonSplit
            // 
            this.HelpBottonSplit.Name = "HelpBottonSplit";
            this.HelpBottonSplit.Size = new System.Drawing.Size(94, 20);
            this.HelpBottonSplit.Text = "О программе";
            this.HelpBottonSplit.Click += new System.EventHandler(this.HelpBottonSplit_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 27);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1027, 458);
            this.webBrowser.TabIndex = 1;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(87, 494);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(55, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(148, 494);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(55, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(209, 491);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Рассчет";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите X и Y";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatusSplit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusSplit
            // 
            this.LabelStatusSplit.Name = "LabelStatusSplit";
            this.LabelStatusSplit.Size = new System.Drawing.Size(96, 17);
            this.LabelStatusSplit.Text = "Статус решения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизация расчетов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenButtonSplit;
        private System.Windows.Forms.ToolStripMenuItem ClearButtonSplit;
        private System.Windows.Forms.ToolStripMenuItem HelpBottonSplit;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripMenuItem ExitBottonSplit;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatusSplit;
    }
}

