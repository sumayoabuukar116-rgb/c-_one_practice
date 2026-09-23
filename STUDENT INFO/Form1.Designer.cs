namespace STUDENT_INFO
{
    partial class Form1
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexit.Location = new System.Drawing.Point(524, 366);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 33);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclear.Location = new System.Drawing.Point(339, 366);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 33);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowinfo.Location = new System.Drawing.Point(118, 366);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(175, 33);
            this.btnshowinfo.TabIndex = 3;
            this.btnshowinfo.Text = "Show Information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(161, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(177, 20);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Enter the student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(161, 115);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(154, 20);
            this.lblstudentid.TabIndex = 6;
            this.lblstudentid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(161, 158);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(161, 20);
            this.lbldepartment.TabIndex = 7;
            this.lbldepartment.Text = "Enter the department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(161, 214);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(145, 20);
            this.lblsemester.TabIndex = 8;
            this.lblsemester.Text = "Enter the semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(524, 67);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 26);
            this.txtname.TabIndex = 9;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(524, 214);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(225, 26);
            this.txtsemester.TabIndex = 10;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(524, 158);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(225, 26);
            this.txtdepartment.TabIndex = 11;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(524, 115);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(225, 26);
            this.txtstudentid.TabIndex = 12;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(104, 302);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(622, 41);
            this.lbloutput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Name = "Form1";
            this.Text = "STUDENT INFORMATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label lbloutput;
    }
}

