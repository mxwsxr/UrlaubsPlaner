namespace UrlaubsPlaner
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gp_calendar = new System.Windows.Forms.GroupBox();
            this.gp_input = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_employeeId = new System.Windows.Forms.Label();
            this.listview_event = new System.Windows.Forms.ListView();
            this.absenceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.gp_calendar.SuspendLayout();
            this.gp_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_calendar
            // 
            this.gp_calendar.Controls.Add(this.listView1);
            this.gp_calendar.Controls.Add(this.listview_event);
            this.gp_calendar.Location = new System.Drawing.Point(26, 27);
            this.gp_calendar.Name = "gp_calendar";
            this.gp_calendar.Size = new System.Drawing.Size(1187, 880);
            this.gp_calendar.TabIndex = 0;
            this.gp_calendar.TabStop = false;
            this.gp_calendar.Text = "Kalender";
            this.gp_calendar.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // gp_input
            // 
            this.gp_input.Controls.Add(this.label_employeeId);
            this.gp_input.Controls.Add(this.label_lastname);
            this.gp_input.Controls.Add(this.label_firstname);
            this.gp_input.Controls.Add(this.textBox3);
            this.gp_input.Controls.Add(this.textBox2);
            this.gp_input.Controls.Add(this.textBox1);
            this.gp_input.Controls.Add(this.button_cancel);
            this.gp_input.Controls.Add(this.button_save);
            this.gp_input.Controls.Add(this.monthCalendar);
            this.gp_input.Location = new System.Drawing.Point(1219, 27);
            this.gp_input.Name = "gp_input";
            this.gp_input.Size = new System.Drawing.Size(404, 189);
            this.gp_input.TabIndex = 1;
            this.gp_input.TabStop = false;
            this.gp_input.Text = "Eingabe";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 15);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(208, 154);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(306, 154);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(203, 18);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(52, 13);
            this.label_firstname.TabIndex = 6;
            this.label_firstname.Text = "Vorname:";
            this.label_firstname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(203, 44);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(62, 13);
            this.label_lastname.TabIndex = 7;
            this.label_lastname.Text = "Nachname:";
            // 
            // label_employeeId
            // 
            this.label_employeeId.AutoSize = true;
            this.label_employeeId.Location = new System.Drawing.Point(203, 70);
            this.label_employeeId.Name = "label_employeeId";
            this.label_employeeId.Size = new System.Drawing.Size(73, 13);
            this.label_employeeId.TabIndex = 8;
            this.label_employeeId.Text = "Mitarbeiter-ID:";
            // 
            // listview_event
            // 
            this.listview_event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employee,
            this.absence,
            this.absenceType});
            this.listview_event.FullRowSelect = true;
            this.listview_event.GridLines = true;
            this.listview_event.Location = new System.Drawing.Point(6, 15);
            this.listview_event.Name = "listview_event";
            this.listview_event.Size = new System.Drawing.Size(260, 420);
            this.listview_event.TabIndex = 0;
            this.listview_event.UseCompatibleStateImageBehavior = false;
            // 
            // absenceType
            // 
            this.absenceType.DisplayIndex = 0;
            this.absenceType.Text = "Abwesenheitstyp";
            // 
            // employee
            // 
            this.employee.DisplayIndex = 1;
            this.employee.Text = "Mitarbeiter";
            // 
            // absence
            // 
            this.absence.DisplayIndex = 2;
            this.absence.Text = "Abwesenheit";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 454);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 420);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 937);
            this.Controls.Add(this.gp_input);
            this.Controls.Add(this.gp_calendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Urlaubsplaner";
            this.Load += new System.EventHandler(this.Form_MainLoad);
            this.gp_calendar.ResumeLayout(false);
            this.gp_input.ResumeLayout(false);
            this.gp_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_calendar;
        private System.Windows.Forms.GroupBox gp_input;
        private System.Windows.Forms.Label label_employeeId;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView listview_event;
        private System.Windows.Forms.ColumnHeader employee;
        private System.Windows.Forms.ColumnHeader absence;
        private System.Windows.Forms.ColumnHeader absenceType;
        private System.Windows.Forms.ListView listView1;
    }
}

