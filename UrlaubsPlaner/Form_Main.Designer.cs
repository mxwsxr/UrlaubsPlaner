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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Krankmeldung");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Urlaub");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Hochschule/BS");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gp_calendar = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listview_event = new System.Windows.Forms.ListView();
            this.employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absenceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gp_input = new System.Windows.Forms.GroupBox();
            this.combobox_absencetype = new System.Windows.Forms.ComboBox();
            this.label_absencetype = new System.Windows.Forms.Label();
            this.richtextbox_reason = new System.Windows.Forms.RichTextBox();
            this.label_reason = new System.Windows.Forms.Label();
            this.label_employeeNumber = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.textbox_employeeNumber = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_firstname = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
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
            this.gp_calendar.Size = new System.Drawing.Size(433, 880);
            this.gp_calendar.TabIndex = 0;
            this.gp_calendar.TabStop = false;
            this.gp_calendar.Text = "Kalender";
            this.gp_calendar.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 454);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 420);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listview_event
            // 
            this.listview_event.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employee,
            this.absence,
            this.absenceType});
            this.listview_event.FullRowSelect = true;
            this.listview_event.GridLines = true;
            this.listview_event.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listview_event.Location = new System.Drawing.Point(6, 15);
            this.listview_event.Name = "listview_event";
            this.listview_event.Size = new System.Drawing.Size(420, 420);
            this.listview_event.TabIndex = 0;
            this.listview_event.UseCompatibleStateImageBehavior = false;
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
            // absenceType
            // 
            this.absenceType.DisplayIndex = 0;
            this.absenceType.Text = "Abwesenheitstyp";
            // 
            // gp_input
            // 
            this.gp_input.Controls.Add(this.combobox_absencetype);
            this.gp_input.Controls.Add(this.label_absencetype);
            this.gp_input.Controls.Add(this.richtextbox_reason);
            this.gp_input.Controls.Add(this.label_reason);
            this.gp_input.Controls.Add(this.label_employeeNumber);
            this.gp_input.Controls.Add(this.label_lastname);
            this.gp_input.Controls.Add(this.label_firstname);
            this.gp_input.Controls.Add(this.textbox_employeeNumber);
            this.gp_input.Controls.Add(this.textbox_lastname);
            this.gp_input.Controls.Add(this.textbox_firstname);
            this.gp_input.Controls.Add(this.button_cancel);
            this.gp_input.Controls.Add(this.button_save);
            this.gp_input.Controls.Add(this.monthCalendar);
            this.gp_input.Location = new System.Drawing.Point(465, 27);
            this.gp_input.Name = "gp_input";
            this.gp_input.Size = new System.Drawing.Size(410, 880);
            this.gp_input.TabIndex = 1;
            this.gp_input.TabStop = false;
            this.gp_input.Text = "Eingabe";
            // 
            // combobox_absencetype
            // 
            this.combobox_absencetype.FormattingEnabled = true;
            this.combobox_absencetype.Items.AddRange(new object[] {
            "Urlaub",
            "Krank",
            "Hochschule/BS/Weiterbildung"});
            this.combobox_absencetype.Location = new System.Drawing.Point(282, 96);
            this.combobox_absencetype.Name = "combobox_absencetype";
            this.combobox_absencetype.Size = new System.Drawing.Size(116, 21);
            this.combobox_absencetype.TabIndex = 13;
            this.combobox_absencetype.SelectedIndexChanged += new System.EventHandler(this.Combobox_absencetype_SelectedIndexChanged);
            // 
            // label_absencetype
            // 
            this.label_absencetype.AutoSize = true;
            this.label_absencetype.Location = new System.Drawing.Point(203, 99);
            this.label_absencetype.Name = "label_absencetype";
            this.label_absencetype.Size = new System.Drawing.Size(28, 13);
            this.label_absencetype.TabIndex = 12;
            this.label_absencetype.Text = "Typ:";
            // 
            // richtextbox_reason
            // 
            this.richtextbox_reason.Location = new System.Drawing.Point(206, 189);
            this.richtextbox_reason.Name = "richtextbox_reason";
            this.richtextbox_reason.Size = new System.Drawing.Size(192, 118);
            this.richtextbox_reason.TabIndex = 11;
            this.richtextbox_reason.Text = "";
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.Location = new System.Drawing.Point(203, 173);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(39, 13);
            this.label_reason.TabIndex = 9;
            this.label_reason.Text = "Grund:";
            this.label_reason.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label_employeeNumber
            // 
            this.label_employeeNumber.AutoSize = true;
            this.label_employeeNumber.Location = new System.Drawing.Point(203, 70);
            this.label_employeeNumber.Name = "label_employeeNumber";
            this.label_employeeNumber.Size = new System.Drawing.Size(73, 13);
            this.label_employeeNumber.TabIndex = 8;
            this.label_employeeNumber.Text = "Mitarbeiter-Nr:";
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
            // textbox_employeeNumber
            // 
            this.textbox_employeeNumber.Location = new System.Drawing.Point(282, 67);
            this.textbox_employeeNumber.Name = "textbox_employeeNumber";
            this.textbox_employeeNumber.Size = new System.Drawing.Size(116, 20);
            this.textbox_employeeNumber.TabIndex = 5;
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Location = new System.Drawing.Point(282, 41);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(116, 20);
            this.textbox_lastname.TabIndex = 4;
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.Location = new System.Drawing.Point(282, 15);
            this.textbox_firstname.Name = "textbox_firstname";
            this.textbox_firstname.Size = new System.Drawing.Size(116, 20);
            this.textbox_firstname.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 218);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 189);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 15);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 937);
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
        private System.Windows.Forms.Label label_employeeNumber;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.TextBox textbox_employeeNumber;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_firstname;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView listview_event;
        private System.Windows.Forms.ColumnHeader employee;
        private System.Windows.Forms.ColumnHeader absence;
        private System.Windows.Forms.ColumnHeader absenceType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.RichTextBox richtextbox_reason;
        private System.Windows.Forms.ComboBox combobox_absencetype;
        private System.Windows.Forms.Label label_absencetype;
    }
}

