namespace HOTEL_ROOM_BOOKING
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
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestsnum = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.grpAditionalOptions = new System.Windows.Forms.GroupBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BookingDetails = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPersonalInfo.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.grpAditionalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.lblGuestsnum);
            this.grpPersonalInfo.Controls.Add(this.lblNights);
            this.grpPersonalInfo.Controls.Add(this.lblGuestAge);
            this.grpPersonalInfo.Controls.Add(this.txtGuests);
            this.grpPersonalInfo.Controls.Add(this.txtNights);
            this.grpPersonalInfo.Controls.Add(this.txtGuestAge);
            this.grpPersonalInfo.Controls.Add(this.lblGuestName);
            this.grpPersonalInfo.Controls.Add(this.txtGuestName);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 42);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(461, 218);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(223, 29);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(223, 30);
            this.txtGuestName.TabIndex = 1;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(223, 175);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(223, 30);
            this.txtGuests.TabIndex = 2;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(223, 125);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(223, 30);
            this.txtNights.TabIndex = 3;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(223, 78);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(223, 30);
            this.txtGuestAge.TabIndex = 4;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(59, 43);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(127, 25);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest Name:";
            // 
            // lblGuestsnum
            // 
            this.lblGuestsnum.AutoSize = true;
            this.lblGuestsnum.Location = new System.Drawing.Point(11, 175);
            this.lblGuestsnum.Name = "lblGuestsnum";
            this.lblGuestsnum.Size = new System.Drawing.Size(175, 25);
            this.lblGuestsnum.TabIndex = 2;
            this.lblGuestsnum.Text = "Number of Guests:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(18, 130);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(168, 25);
            this.lblNights.TabIndex = 3;
            this.lblNights.Text = "Number of Nights:";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Location = new System.Drawing.Point(75, 83);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(111, 25);
            this.lblGuestAge.TabIndex = 4;
            this.lblGuestAge.Text = "Guest Age:";
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rdoHight);
            this.grpRoomType.Controls.Add(this.rdoNormal);
            this.grpRoomType.Controls.Add(this.rdoStandard);
            this.grpRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoomType.Location = new System.Drawing.Point(12, 275);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(511, 80);
            this.grpRoomType.TabIndex = 1;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room Type";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(6, 41);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(117, 29);
            this.rdoStandard.TabIndex = 2;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Location = new System.Drawing.Point(358, 41);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(82, 29);
            this.rdoHight.TabIndex = 3;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "Hight";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(185, 41);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(99, 29);
            this.rdoNormal.TabIndex = 4;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // grpAditionalOptions
            // 
            this.grpAditionalOptions.Controls.Add(this.chkBreakfast);
            this.grpAditionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAditionalOptions.Location = new System.Drawing.Point(12, 373);
            this.grpAditionalOptions.Name = "grpAditionalOptions";
            this.grpAditionalOptions.Size = new System.Drawing.Size(511, 72);
            this.grpAditionalOptions.TabIndex = 2;
            this.grpAditionalOptions.TabStop = false;
            this.grpAditionalOptions.Text = "Aditional Options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(6, 37);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(326, 29);
            this.chkBreakfast.TabIndex = 3;
            this.chkBreakfast.Text = "Breakfast(10 per Guest per night)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(28, 466);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(458, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(245, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BookingDetails
            // 
            this.BookingDetails.FormattingEnabled = true;
            this.BookingDetails.ItemHeight = 20;
            this.BookingDetails.Location = new System.Drawing.Point(541, 12);
            this.BookingDetails.Name = "BookingDetails";
            this.BookingDetails.Size = new System.Drawing.Size(341, 304);
            this.BookingDetails.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Blue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(97, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Hotel Room Booking System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(894, 513);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BookingDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAditionalOptions);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.grpPersonalInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.grpAditionalOptions.ResumeLayout(false);
            this.grpAditionalOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lblGuestsnum;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.GroupBox grpAditionalOptions;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox BookingDetails;
        private System.Windows.Forms.Label lblTitle;
    }
}

