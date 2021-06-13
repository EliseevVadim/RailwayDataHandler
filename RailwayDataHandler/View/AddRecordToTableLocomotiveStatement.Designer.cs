
namespace RailwayDataHandler.View
{
    partial class AddRecordToTableLocomotiveStatement
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
            this.arrivalStationBox = new System.Windows.Forms.ComboBox();
            this.depotBox = new System.Windows.Forms.ComboBox();
            this.depertureStationBox = new System.Windows.Forms.ComboBox();
            this.locomotiveIdBox = new System.Windows.Forms.ComboBox();
            this.routeNumberBox = new System.Windows.Forms.ComboBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.routeIdLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.batchAndNumLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.depotIdLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.departureIdLabel = new System.Windows.Forms.Label();
            this.arrivalIdLabel = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(388, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление записи в таблицу Locomotive_statement";
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
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.arrivalIdLabel);
            this.panel2.Controls.Add(this.departureIdLabel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.depotIdLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.batchAndNumLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.routeIdLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.arrivalStationBox);
            this.panel2.Controls.Add(this.depotBox);
            this.panel2.Controls.Add(this.depertureStationBox);
            this.panel2.Controls.Add(this.locomotiveIdBox);
            this.panel2.Controls.Add(this.routeNumberBox);
            this.panel2.Controls.Add(this.buttonAddRecord);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 299);
            this.panel2.TabIndex = 5;
            // 
            // arrivalStationBox
            // 
            this.arrivalStationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.arrivalStationBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.arrivalStationBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.arrivalStationBox.FormattingEnabled = true;
            this.arrivalStationBox.Location = new System.Drawing.Point(192, 196);
            this.arrivalStationBox.Name = "arrivalStationBox";
            this.arrivalStationBox.Size = new System.Drawing.Size(196, 31);
            this.arrivalStationBox.TabIndex = 7;
            // 
            // depotBox
            // 
            this.depotBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.depotBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.depotBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.depotBox.FormattingEnabled = true;
            this.depotBox.Location = new System.Drawing.Point(160, 122);
            this.depotBox.Name = "depotBox";
            this.depotBox.Size = new System.Drawing.Size(230, 31);
            this.depotBox.TabIndex = 7;
            // 
            // depertureStationBox
            // 
            this.depertureStationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.depertureStationBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.depertureStationBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.depertureStationBox.FormattingEnabled = true;
            this.depertureStationBox.Location = new System.Drawing.Point(192, 159);
            this.depertureStationBox.Name = "depertureStationBox";
            this.depertureStationBox.Size = new System.Drawing.Size(196, 31);
            this.depertureStationBox.TabIndex = 7;
            // 
            // locomotiveIdBox
            // 
            this.locomotiveIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.locomotiveIdBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.locomotiveIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.locomotiveIdBox.FormattingEnabled = true;
            this.locomotiveIdBox.Location = new System.Drawing.Point(160, 85);
            this.locomotiveIdBox.Name = "locomotiveIdBox";
            this.locomotiveIdBox.Size = new System.Drawing.Size(230, 31);
            this.locomotiveIdBox.TabIndex = 7;
            // 
            // routeNumberBox
            // 
            this.routeNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.routeNumberBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.routeNumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.routeNumberBox.FormattingEnabled = true;
            this.routeNumberBox.Location = new System.Drawing.Point(160, 11);
            this.routeNumberBox.Name = "routeNumberBox";
            this.routeNumberBox.Size = new System.Drawing.Size(228, 31);
            this.routeNumberBox.TabIndex = 7;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.buttonAddRecord.Location = new System.Drawing.Point(280, 242);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(272, 40);
            this.buttonAddRecord.TabIndex = 5;
            this.buttonAddRecord.Text = "Добавить запись";
            this.buttonAddRecord.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Станция прибытия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label9.Location = new System.Drawing.Point(12, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Депо прописки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Станция отправления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "№ маршрута:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "id локомотива:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(394, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "id:";
            // 
            // routeIdLabel
            // 
            this.routeIdLabel.AutoSize = true;
            this.routeIdLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.routeIdLabel.Location = new System.Drawing.Point(426, 14);
            this.routeIdLabel.Name = "routeIdLabel";
            this.routeIdLabel.Size = new System.Drawing.Size(0, 23);
            this.routeIdLabel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(396, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Серия и номер локомотива:";
            // 
            // batchAndNumLabel
            // 
            this.batchAndNumLabel.AutoSize = true;
            this.batchAndNumLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batchAndNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.batchAndNumLabel.Location = new System.Drawing.Point(617, 88);
            this.batchAndNumLabel.Name = "batchAndNumLabel";
            this.batchAndNumLabel.Size = new System.Drawing.Size(0, 23);
            this.batchAndNumLabel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(396, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "id:";
            // 
            // depotIdLabel
            // 
            this.depotIdLabel.AutoSize = true;
            this.depotIdLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depotIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.depotIdLabel.Location = new System.Drawing.Point(426, 125);
            this.depotIdLabel.Name = "depotIdLabel";
            this.depotIdLabel.Size = new System.Drawing.Size(0, 23);
            this.depotIdLabel.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label10.Location = new System.Drawing.Point(394, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(387, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "id:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label12.Location = new System.Drawing.Point(394, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "id:";
            // 
            // departureIdLabel
            // 
            this.departureIdLabel.AutoSize = true;
            this.departureIdLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.departureIdLabel.Location = new System.Drawing.Point(426, 162);
            this.departureIdLabel.Name = "departureIdLabel";
            this.departureIdLabel.Size = new System.Drawing.Size(0, 23);
            this.departureIdLabel.TabIndex = 16;
            // 
            // arrivalIdLabel
            // 
            this.arrivalIdLabel.AutoSize = true;
            this.arrivalIdLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.arrivalIdLabel.Location = new System.Drawing.Point(426, 199);
            this.arrivalIdLabel.Name = "arrivalIdLabel";
            this.arrivalIdLabel.Size = new System.Drawing.Size(0, 23);
            this.arrivalIdLabel.TabIndex = 17;
            // 
            // AddRecordToTableLocomotiveStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecordToTableLocomotiveStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecordToTableLocomotiveStatement";
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
        private System.Windows.Forms.ComboBox arrivalStationBox;
        private System.Windows.Forms.ComboBox depotBox;
        private System.Windows.Forms.ComboBox depertureStationBox;
        private System.Windows.Forms.ComboBox locomotiveIdBox;
        private System.Windows.Forms.ComboBox routeNumberBox;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label routeIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batchAndNumLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label depotIdLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label arrivalIdLabel;
        private System.Windows.Forms.Label departureIdLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}