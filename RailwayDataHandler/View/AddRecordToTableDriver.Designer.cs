
namespace RailwayDataHandler.View
{
    partial class AddRecordToTableDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.driversCategoryField = new System.Windows.Forms.TextBox();
            this.driversNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление записи в таблицу Driver\r\n";
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonCloseForm.Location = new System.Drawing.Point(760, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(40, 40);
            this.buttonCloseForm.TabIndex = 0;
            this.buttonCloseForm.Text = "☓";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.buttonAddRecord);
            this.panel2.Controls.Add(this.driversCategoryField);
            this.panel2.Controls.Add(this.driversNameField);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 148);
            this.panel2.TabIndex = 2;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonAddRecord.Location = new System.Drawing.Point(280, 91);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(272, 40);
            this.buttonAddRecord.TabIndex = 5;
            this.buttonAddRecord.Text = "Добавить запись";
            this.buttonAddRecord.UseVisualStyleBackColor = false;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // driversCategoryField
            // 
            this.driversCategoryField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.driversCategoryField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driversCategoryField.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.driversCategoryField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.driversCategoryField.Location = new System.Drawing.Point(160, 49);
            this.driversCategoryField.Name = "driversCategoryField";
            this.driversCategoryField.Size = new System.Drawing.Size(628, 29);
            this.driversCategoryField.TabIndex = 4;
            // 
            // driversNameField
            // 
            this.driversNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.driversNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driversNameField.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.driversNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.driversNameField.Location = new System.Drawing.Point(160, 14);
            this.driversNameField.Name = "driversNameField";
            this.driversNameField.Size = new System.Drawing.Size(628, 29);
            this.driversNameField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Класс машиниста:";
            // 
            // AddRecordToTableDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecordToTableDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecordToTableDriver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.TextBox driversCategoryField;
        private System.Windows.Forms.TextBox driversNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}