namespace Airplane
{
    partial class AddPassangers
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchFName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.boxSenior = new System.Windows.Forms.CheckBox();
            this.boxJunior = new System.Windows.Forms.CheckBox();
            this.boxPilot = new System.Windows.Forms.CheckBox();
            this.boxAttendant = new System.Windows.Forms.CheckBox();
            this.lbCreatedPassangers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBusinessAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPassanger = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJunior = new System.Windows.Forms.RadioButton();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlane = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(315, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 237);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find Person";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRemove);
            this.groupBox6.Controls.Add(this.btnSearch);
            this.groupBox6.Controls.Add(this.tbSearchLName);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.tbSearchFName);
            this.groupBox6.Location = new System.Drawing.Point(13, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 127);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Find by Name";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(22, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(272, 29);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name:";
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
            // lbCreatedPassangers
            // 
            this.lbCreatedPassangers.FormattingEnabled = true;
            this.lbCreatedPassangers.ItemHeight = 17;
            this.lbCreatedPassangers.Location = new System.Drawing.Point(315, 62);
            this.lbCreatedPassangers.Name = "lbCreatedPassangers";
            this.lbCreatedPassangers.Size = new System.Drawing.Size(333, 208);
            this.lbCreatedPassangers.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbBusinessAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnAddPassanger);
            this.groupBox3.Controls.Add(this.tbAmount);
            this.groupBox3.Location = new System.Drawing.Point(26, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 183);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Passangers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Business:";
            // 
            // tbBusinessAmount
            // 
            this.tbBusinessAmount.Location = new System.Drawing.Point(97, 82);
            this.tbBusinessAmount.Name = "tbBusinessAmount";
            this.tbBusinessAmount.Size = new System.Drawing.Size(150, 25);
            this.tbBusinessAmount.TabIndex = 18;
            this.tbBusinessAmount.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Economy:";
            // 
            // btnAddPassanger
            // 
            this.btnAddPassanger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPassanger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPassanger.Location = new System.Drawing.Point(24, 113);
            this.btnAddPassanger.Name = "btnAddPassanger";
            this.btnAddPassanger.Size = new System.Drawing.Size(243, 60);
            this.btnAddPassanger.TabIndex = 16;
            this.btnAddPassanger.Text = "Add Passangers and start flying!";
            this.btnAddPassanger.UseVisualStyleBackColor = false;
            this.btnAddPassanger.Click += new System.EventHandler(this.BtnAddPassanger_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(97, 41);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(150, 25);
            this.tbAmount.TabIndex = 10;
            this.tbAmount.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJunior);
            this.groupBox2.Controls.Add(this.rbSenior);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbPosition);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAddMember);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Controls.Add(this.tbAge);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 260);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Pilots/Attendants";
            // 
            // rbJunior
            // 
            this.rbJunior.AutoSize = true;
            this.rbJunior.Location = new System.Drawing.Point(131, 156);
            this.rbJunior.Name = "rbJunior";
            this.rbJunior.Size = new System.Drawing.Size(63, 21);
            this.rbJunior.TabIndex = 22;
            this.rbJunior.TabStop = true;
            this.rbJunior.Text = "Junior";
            this.rbJunior.UseVisualStyleBackColor = true;
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(44, 156);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(64, 21);
            this.rbSenior.TabIndex = 21;
            this.rbSenior.TabStop = true;
            this.rbSenior.Text = "Senior";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(88, 59);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(159, 25);
            this.tbLastName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Last Name:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "PILOT",
            "ATTENDANT"});
            this.cbPosition.Location = new System.Drawing.Point(88, 121);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(159, 25);
            this.cbPosition.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "First Name:";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddMember.Location = new System.Drawing.Point(44, 183);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(203, 61);
            this.btnAddMember.TabIndex = 9;
            this.btnAddMember.Text = "Add Crew Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(88, 24);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(159, 25);
            this.tbFirstName.TabIndex = 18;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(88, 90);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(159, 25);
            this.tbAge.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age:";
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlane.Location = new System.Drawing.Point(19, 9);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(72, 40);
            this.lblPlane.TabIndex = 17;
            this.lblPlane.Text = "info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(315, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoback.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoback.Location = new System.Drawing.Point(26, 507);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(273, 48);
            this.btnGoback.TabIndex = 17;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.BtnGoback_Click);
            // 
            // AddPassangers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 563);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlane);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbCreatedPassangers);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPassangers";
            this.Text = "AddPassangers";
            this.Load += new System.EventHandler(this.AddPassangers_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchFName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox boxSenior;
        private System.Windows.Forms.CheckBox boxJunior;
        private System.Windows.Forms.CheckBox boxPilot;
        private System.Windows.Forms.CheckBox boxAttendant;
        private System.Windows.Forms.ListBox lbCreatedPassangers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPassanger;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJunior;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBusinessAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}