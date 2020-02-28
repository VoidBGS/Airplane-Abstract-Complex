namespace Airplane
{
    partial class FlightInformationForm
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
            this.lblPlane = new System.Windows.Forms.Label();
            this.lblFlight = new System.Windows.Forms.Label();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.lbCreatedPassengers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEconomy = new System.Windows.Forms.Button();
            this.lbEconomy = new System.Windows.Forms.ListBox();
            this.lblEconomy = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.lbBusiness = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAttendants = new System.Windows.Forms.Label();
            this.lblPilots = new System.Windows.Forms.Label();
            this.lblPassengerSeats = new System.Windows.Forms.Label();
            this.lblEconomySeats = new System.Windows.Forms.Label();
            this.lblBusinessSeat = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchLName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSearchFName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.boxSenior = new System.Windows.Forms.CheckBox();
            this.boxJunior = new System.Windows.Forms.CheckBox();
            this.boxPilot = new System.Windows.Forms.CheckBox();
            this.boxAttendant = new System.Windows.Forms.CheckBox();
            this.btnGoback = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBusinessPassangers = new System.Windows.Forms.Label();
            this.lblEconomyPassangers = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlane.Location = new System.Drawing.Point(12, 9);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(288, 40);
            this.lblPlane.TabIndex = 18;
            this.lblPlane.Text = "Information about: ";
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFlight.Location = new System.Drawing.Point(285, 9);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(72, 40);
            this.lblFlight.TabIndex = 19;
            this.lblFlight.Text = "info";
            // 
            // btnPassengers
            // 
            this.btnPassengers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPassengers.Location = new System.Drawing.Point(46, 379);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(238, 29);
            this.btnPassengers.TabIndex = 22;
            this.btnPassengers.Text = "Refresh";
            this.btnPassengers.UseVisualStyleBackColor = false;
            this.btnPassengers.Click += new System.EventHandler(this.BtnPassengers_Click);
            // 
            // lbCreatedPassengers
            // 
            this.lbCreatedPassengers.FormattingEnabled = true;
            this.lbCreatedPassengers.ItemHeight = 17;
            this.lbCreatedPassengers.Location = new System.Drawing.Point(46, 114);
            this.lbCreatedPassengers.Name = "lbCreatedPassengers";
            this.lbCreatedPassengers.Size = new System.Drawing.Size(238, 259);
            this.lbCreatedPassengers.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Passengers";
            // 
            // btnEconomy
            // 
            this.btnEconomy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEconomy.Location = new System.Drawing.Point(319, 379);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(238, 29);
            this.btnEconomy.TabIndex = 25;
            this.btnEconomy.Text = "Refresh";
            this.btnEconomy.UseVisualStyleBackColor = false;
            this.btnEconomy.Click += new System.EventHandler(this.BtnEconomy_Click);
            // 
            // lbEconomy
            // 
            this.lbEconomy.FormattingEnabled = true;
            this.lbEconomy.ItemHeight = 17;
            this.lbEconomy.Location = new System.Drawing.Point(319, 114);
            this.lbEconomy.Name = "lbEconomy";
            this.lbEconomy.Size = new System.Drawing.Size(238, 259);
            this.lbEconomy.TabIndex = 26;
            // 
            // lblEconomy
            // 
            this.lblEconomy.AutoSize = true;
            this.lblEconomy.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEconomy.Location = new System.Drawing.Point(360, 81);
            this.lblEconomy.Name = "lblEconomy";
            this.lblEconomy.Size = new System.Drawing.Size(158, 30);
            this.lblEconomy.TabIndex = 27;
            this.lblEconomy.Text = "Economy Seats";
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBusiness.Location = new System.Drawing.Point(640, 81);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(149, 30);
            this.lblBusiness.TabIndex = 30;
            this.lblBusiness.Text = "Business Seats";
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBusiness.Location = new System.Drawing.Point(592, 379);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(238, 29);
            this.btnBusiness.TabIndex = 28;
            this.btnBusiness.Text = "Refresh";
            this.btnBusiness.UseVisualStyleBackColor = false;
            this.btnBusiness.Click += new System.EventHandler(this.BtnBusiness_Click);
            // 
            // lbBusiness
            // 
            this.lbBusiness.FormattingEnabled = true;
            this.lbBusiness.ItemHeight = 17;
            this.lbBusiness.Location = new System.Drawing.Point(592, 114);
            this.lbBusiness.Name = "lbBusiness";
            this.lbBusiness.Size = new System.Drawing.Size(238, 259);
            this.lbBusiness.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEconomyPassangers);
            this.groupBox1.Controls.Add(this.lblBusinessPassangers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAttendants);
            this.groupBox1.Controls.Add(this.lblPilots);
            this.groupBox1.Controls.Add(this.lblPassengerSeats);
            this.groupBox1.Controls.Add(this.lblEconomySeats);
            this.groupBox1.Controls.Add(this.lblBusinessSeat);
            this.groupBox1.Controls.Add(this.lblSeat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Location = new System.Drawing.Point(34, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 179);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Details";
            // 
            // lblAttendants
            // 
            this.lblAttendants.AutoSize = true;
            this.lblAttendants.Location = new System.Drawing.Point(351, 155);
            this.lblAttendants.Name = "lblAttendants";
            this.lblAttendants.Size = new System.Drawing.Size(30, 17);
            this.lblAttendants.TabIndex = 43;
            this.lblAttendants.Text = "info";
            // 
            // lblPilots
            // 
            this.lblPilots.AutoSize = true;
            this.lblPilots.Location = new System.Drawing.Point(351, 126);
            this.lblPilots.Name = "lblPilots";
            this.lblPilots.Size = new System.Drawing.Size(30, 17);
            this.lblPilots.TabIndex = 42;
            this.lblPilots.Text = "info";
            // 
            // lblPassengerSeats
            // 
            this.lblPassengerSeats.AutoSize = true;
            this.lblPassengerSeats.Location = new System.Drawing.Point(351, 28);
            this.lblPassengerSeats.Name = "lblPassengerSeats";
            this.lblPassengerSeats.Size = new System.Drawing.Size(30, 17);
            this.lblPassengerSeats.TabIndex = 41;
            this.lblPassengerSeats.Text = "info";
            // 
            // lblEconomySeats
            // 
            this.lblEconomySeats.AutoSize = true;
            this.lblEconomySeats.Location = new System.Drawing.Point(135, 93);
            this.lblEconomySeats.Name = "lblEconomySeats";
            this.lblEconomySeats.Size = new System.Drawing.Size(30, 17);
            this.lblEconomySeats.TabIndex = 40;
            this.lblEconomySeats.Text = "info";
            // 
            // lblBusinessSeat
            // 
            this.lblBusinessSeat.AutoSize = true;
            this.lblBusinessSeat.Location = new System.Drawing.Point(135, 60);
            this.lblBusinessSeat.Name = "lblBusinessSeat";
            this.lblBusinessSeat.Size = new System.Drawing.Size(30, 17);
            this.lblBusinessSeat.TabIndex = 39;
            this.lblBusinessSeat.Text = "info";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(135, 29);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(30, 17);
            this.lblSeat.TabIndex = 38;
            this.lblSeat.Text = "info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(257, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Attendants:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(294, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Pilots:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(219, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Total Passengers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Economy Seats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Business Seats:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapacity.Location = new System.Drawing.Point(23, 25);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(106, 21);
            this.lblCapacity.TabIndex = 32;
            this.lblCapacity.Text = "Seat Capacity:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(420, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 198);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find Person";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSearch);
            this.groupBox6.Controls.Add(this.tbSearchLName);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tbSearchFName);
            this.groupBox6.Location = new System.Drawing.Point(13, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(314, 98);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Find by Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(249, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 61);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbSearchLName
            // 
            this.tbSearchLName.Location = new System.Drawing.Point(84, 59);
            this.tbSearchLName.Name = "tbSearchLName";
            this.tbSearchLName.Size = new System.Drawing.Size(159, 25);
            this.tbSearchLName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "First Name:";
            // 
            // tbSearchFName
            // 
            this.tbSearchFName.Location = new System.Drawing.Point(84, 24);
            this.tbSearchFName.Name = "tbSearchFName";
            this.tbSearchFName.Size = new System.Drawing.Size(159, 25);
            this.tbSearchFName.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.boxSenior);
            this.groupBox5.Controls.Add(this.boxJunior);
            this.groupBox5.Controls.Add(this.boxPilot);
            this.groupBox5.Controls.Add(this.boxAttendant);
            this.groupBox5.Location = new System.Drawing.Point(13, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 65);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter by Role";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.Location = new System.Drawing.Point(189, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(105, 40);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // boxSenior
            // 
            this.boxSenior.AutoSize = true;
            this.boxSenior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxSenior.Location = new System.Drawing.Point(124, 45);
            this.boxSenior.Name = "boxSenior";
            this.boxSenior.Size = new System.Drawing.Size(59, 17);
            this.boxSenior.TabIndex = 3;
            this.boxSenior.Text = "Senior";
            this.boxSenior.UseVisualStyleBackColor = true;
            // 
            // boxJunior
            // 
            this.boxJunior.AutoSize = true;
            this.boxJunior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxJunior.Location = new System.Drawing.Point(6, 45);
            this.boxJunior.Name = "boxJunior";
            this.boxJunior.Size = new System.Drawing.Size(59, 17);
            this.boxJunior.TabIndex = 2;
            this.boxJunior.Text = "Junior";
            this.boxJunior.UseVisualStyleBackColor = true;
            // 
            // boxPilot
            // 
            this.boxPilot.AutoSize = true;
            this.boxPilot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPilot.Location = new System.Drawing.Point(124, 24);
            this.boxPilot.Name = "boxPilot";
            this.boxPilot.Size = new System.Drawing.Size(50, 17);
            this.boxPilot.TabIndex = 1;
            this.boxPilot.Text = "Pilot";
            this.boxPilot.UseVisualStyleBackColor = true;
            // 
            // boxAttendant
            // 
            this.boxAttendant.AutoSize = true;
            this.boxAttendant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxAttendant.Location = new System.Drawing.Point(6, 24);
            this.boxAttendant.Name = "boxAttendant";
            this.boxAttendant.Size = new System.Drawing.Size(112, 17);
            this.boxAttendant.TabIndex = 0;
            this.boxAttendant.Text = "Flight Attendant";
            this.boxAttendant.UseVisualStyleBackColor = true;
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoback.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoback.Location = new System.Drawing.Point(34, 601);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(380, 66);
            this.btnGoback.TabIndex = 34;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.BtnGoback_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(191, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Business Passengers:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(187, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Economy Passengers:";
            // 
            // lblBusinessPassangers
            // 
            this.lblBusinessPassangers.AutoSize = true;
            this.lblBusinessPassangers.Location = new System.Drawing.Point(351, 59);
            this.lblBusinessPassangers.Name = "lblBusinessPassangers";
            this.lblBusinessPassangers.Size = new System.Drawing.Size(30, 17);
            this.lblBusinessPassangers.TabIndex = 46;
            this.lblBusinessPassangers.Text = "info";
            // 
            // lblEconomyPassangers
            // 
            this.lblEconomyPassangers.AutoSize = true;
            this.lblEconomyPassangers.Location = new System.Drawing.Point(351, 92);
            this.lblEconomyPassangers.Name = "lblEconomyPassangers";
            this.lblEconomyPassangers.Size = new System.Drawing.Size(30, 17);
            this.lblEconomyPassangers.TabIndex = 47;
            this.lblEconomyPassangers.Text = "info";
            // 
            // FlightInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 700);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.lbBusiness);
            this.Controls.Add(this.lblEconomy);
            this.Controls.Add(this.btnEconomy);
            this.Controls.Add(this.lbEconomy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.lbCreatedPassengers);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.lblPlane);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FlightInformationForm";
            this.Text = "Flight Information";
            this.Load += new System.EventHandler(this.FlightInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.ListBox lbCreatedPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEconomy;
        private System.Windows.Forms.ListBox lbEconomy;
        private System.Windows.Forms.Label lblEconomy;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.ListBox lbBusiness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAttendants;
        private System.Windows.Forms.Label lblPilots;
        private System.Windows.Forms.Label lblPassengerSeats;
        private System.Windows.Forms.Label lblEconomySeats;
        private System.Windows.Forms.Label lblBusinessSeat;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchLName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSearchFName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox boxSenior;
        private System.Windows.Forms.CheckBox boxJunior;
        private System.Windows.Forms.CheckBox boxPilot;
        private System.Windows.Forms.CheckBox boxAttendant;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Label lblEconomyPassangers;
        private System.Windows.Forms.Label lblBusinessPassangers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}