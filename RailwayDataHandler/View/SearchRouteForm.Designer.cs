
namespace RailwayDataHandler.View
{
    partial class SearchRouteForm
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
            this.routeNumberField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.routesDate = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер маршрута:";
            // 
            // routeNumberField
            // 
            this.routeNumberField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.routeNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.routeNumberField.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.routeNumberField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.routeNumberField.Location = new System.Drawing.Point(238, 6);
            this.routeNumberField.Name = "routeNumberField";
            this.routeNumberField.Size = new System.Drawing.Size(550, 29);
            this.routeNumberField.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Выберите дату маршрута:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // routesDate
            // 
            this.routesDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.routesDate.Location = new System.Drawing.Point(238, 68);
            this.routesDate.Name = "routesDate";
            this.routesDate.Size = new System.Drawing.Size(550, 29);
            this.routesDate.TabIndex = 33;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.searchButton.Location = new System.Drawing.Point(272, 122);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(272, 40);
            this.searchButton.TabIndex = 34;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 185);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.routesDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.routeNumberField);
            this.Controls.Add(this.label1);
            this.Name = "SearchRouteForm";
            this.Text = "Поиск маршрута";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox routeNumberField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker routesDate;
        private System.Windows.Forms.Button searchButton;
    }
}