namespace TICKET_BOOKING
{
    partial class frmAirlineBooking
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
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.lblBaggageWeight = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.grpTravelClass = new System.Windows.Forms.GroupBox();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.grpAdditionalOptions = new System.Windows.Forms.GroupBox();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.LBLfrmAirlineBooking = new System.Windows.Forms.Label();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.grpPersonalInfo.SuspendLayout();
            this.grpTravelClass.SuspendLayout();
            this.grpAdditionalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.grpPersonalInfo.Controls.Add(this.lblBaggageWeight);
            this.grpPersonalInfo.Controls.Add(this.lblNumberOfTickets);
            this.grpPersonalInfo.Controls.Add(this.lblPassengerAge);
            this.grpPersonalInfo.Controls.Add(this.txtBaggageWeight);
            this.grpPersonalInfo.Controls.Add(this.txtNumberOfTickets);
            this.grpPersonalInfo.Controls.Add(this.txtPassengerAge);
            this.grpPersonalInfo.Controls.Add(this.txtPassengerName);
            this.grpPersonalInfo.Controls.Add(this.lblPassengerName);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 48);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(519, 234);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(50, 37);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(169, 25);
            this.lblPassengerName.TabIndex = 1;
            this.lblPassengerName.Text = "Passenger Name:";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(239, 29);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(261, 30);
            this.txtPassengerName.TabIndex = 2;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(239, 187);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(261, 30);
            this.txtBaggageWeight.TabIndex = 3;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(239, 136);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(261, 30);
            this.txtNumberOfTickets.TabIndex = 4;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(239, 78);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(261, 30);
            this.txtPassengerAge.TabIndex = 5;
            // 
            // lblBaggageWeight
            // 
            this.lblBaggageWeight.AutoSize = true;
            this.lblBaggageWeight.Location = new System.Drawing.Point(15, 190);
            this.lblBaggageWeight.Name = "lblBaggageWeight";
            this.lblBaggageWeight.Size = new System.Drawing.Size(204, 25);
            this.lblBaggageWeight.TabIndex = 4;
            this.lblBaggageWeight.Text = "Baggage Weight (kg):";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(43, 139);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(176, 25);
            this.lblNumberOfTickets.TabIndex = 5;
            this.lblNumberOfTickets.Text = "Number of Tickets:";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Location = new System.Drawing.Point(66, 86);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(153, 25);
            this.lblPassengerAge.TabIndex = 6;
            this.lblPassengerAge.Text = "Passenger Age:";
            // 
            // grpTravelClass
            // 
            this.grpTravelClass.Controls.Add(this.rdoBusinessClass);
            this.grpTravelClass.Controls.Add(this.rdoNormalClass);
            this.grpTravelClass.Controls.Add(this.rdoFirstClass);
            this.grpTravelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTravelClass.Location = new System.Drawing.Point(12, 299);
            this.grpTravelClass.Name = "grpTravelClass";
            this.grpTravelClass.Size = new System.Drawing.Size(557, 94);
            this.grpTravelClass.TabIndex = 1;
            this.grpTravelClass.TabStop = false;
            this.grpTravelClass.Text = "Travel Class";
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Location = new System.Drawing.Point(6, 50);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(129, 29);
            this.rdoFirstClass.TabIndex = 2;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "First Class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Location = new System.Drawing.Point(374, 50);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(172, 29);
            this.rdoBusinessClass.TabIndex = 3;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Location = new System.Drawing.Point(183, 50);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(154, 29);
            this.rdoNormalClass.TabIndex = 4;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // grpAdditionalOptions
            // 
            this.grpAdditionalOptions.Controls.Add(this.chkTravelInsurance);
            this.grpAdditionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdditionalOptions.Location = new System.Drawing.Point(12, 408);
            this.grpAdditionalOptions.Name = "grpAdditionalOptions";
            this.grpAdditionalOptions.Size = new System.Drawing.Size(425, 114);
            this.grpAdditionalOptions.TabIndex = 2;
            this.grpAdditionalOptions.TabStop = false;
            this.grpAdditionalOptions.Text = "Additional Options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(6, 52);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(370, 29);
            this.chkTravelInsurance.TabIndex = 3;
            this.chkTravelInsurance.Text = "Add Travel Insurance ($25 Per Ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 538);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 45);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(386, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(206, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LBLfrmAirlineBooking
            // 
            this.LBLfrmAirlineBooking.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLfrmAirlineBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLfrmAirlineBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLfrmAirlineBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLfrmAirlineBooking.Location = new System.Drawing.Point(293, 9);
            this.LBLfrmAirlineBooking.Name = "LBLfrmAirlineBooking";
            this.LBLfrmAirlineBooking.Size = new System.Drawing.Size(341, 36);
            this.LBLfrmAirlineBooking.TabIndex = 6;
            this.LBLfrmAirlineBooking.Text = "Airline Ticket Booking System";
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(662, 29);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(397, 364);
            this.lstBookingDetails.TabIndex = 7;
            // 
            // frmAirlineBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.LBLfrmAirlineBooking);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAdditionalOptions);
            this.Controls.Add(this.grpTravelClass);
            this.Controls.Add(this.grpPersonalInfo);
            this.Name = "frmAirlineBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Ticket Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpTravelClass.ResumeLayout(false);
            this.grpTravelClass.PerformLayout();
            this.grpAdditionalOptions.ResumeLayout(false);
            this.grpAdditionalOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblBaggageWeight;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.GroupBox grpTravelClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.GroupBox grpAdditionalOptions;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label LBLfrmAirlineBooking;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

