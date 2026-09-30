namespace Electricity_Bill_Calculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(261, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electricity Bill Calculator";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(201, 103);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(252, 25);
            this.lblPrevious.TabIndex = 1;
            this.lblPrevious.Text = "Enter Previous Reading      :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(201, 59);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(251, 25);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Enter Customer Name        :";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(201, 158);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(251, 25);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Enter Current Reading        :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(482, 58);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(173, 26);
            this.txtCustomer.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(482, 204);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(173, 26);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(482, 158);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(173, 26);
            this.txtCurrent.TabIndex = 6;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(482, 104);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(173, 26);
            this.txtPrevious.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(201, 209);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(252, 25);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Enter Price Per Unit ($)       :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(337, 236);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(161, 44);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(344, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total Bill (Including $5 Fixed Charge) :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(6, 50);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(178, 25);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "Tax Amount (7%) :";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(6, 10);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(230, 25);
            this.lblUsage.TabIndex = 12;
            this.lblUsage.Text = "Electricity Usage (Units) :";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(368, 106);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(232, 26);
            this.txtTotal.TabIndex = 13;
            // 
            // txttax
            // 
            this.txttax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttax.ForeColor = System.Drawing.Color.Black;
            this.txttax.Location = new System.Drawing.Point(368, 50);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(232, 26);
            this.txttax.TabIndex = 14;
            // 
            // txtUsage
            // 
            this.txtUsage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsage.Location = new System.Drawing.Point(368, 11);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(232, 26);
            this.txtUsage.TabIndex = 15;
            // 
            // grpResults
            // 
            this.grpResults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpResults.Controls.Add(this.lblUsage);
            this.grpResults.Controls.Add(this.lblTax);
            this.grpResults.Controls.Add(this.txtTotal);
            this.grpResults.Controls.Add(this.txttax);
            this.grpResults.Controls.Add(this.txtUsage);
            this.grpResults.Controls.Add(this.lblTotal);
            this.grpResults.Location = new System.Drawing.Point(67, 288);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(678, 150);
            this.grpResults.TabIndex = 16;
            this.grpResults.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.GroupBox grpResults;
    }
}

