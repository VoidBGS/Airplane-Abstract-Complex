namespace Airplane
{
    partial class AirControl
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFlightInformation = new System.Windows.Forms.Button();
            this.tbSearchAirplane = new System.Windows.Forms.Button();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.btnAddPassengers = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCreatedAriplanes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaneType = new System.Windows.Forms.ComboBox();
            this.btnCreateFlight = new System.Windows.Forms.Button();
            this.btnCreateCustom = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(485, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(199, 57);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDelete);
            this.groupBox7.Controls.Add(this.btnFlightInformation);
            this.groupBox7.Controls.Add(this.tbSearchAirplane);
            this.groupBox7.Controls.Add(this.tbSearchID);
            this.groupBox7.Controls.Add(this.btnAddPassengers);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(448, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 235);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Airplane";
            // 
            // btnFlightInformation
            // 
            this.btnFlightInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFlightInformation.Location = new System.Drawing.Point(5, 104);
            this.btnFlightInformation.Name = "btnFlightInformation";
            this.btnFlightInformation.Size = new System.Drawing.Size(225, 41);
            this.btnFlightInformation.TabIndex = 17;
            this.btnFlightInformation.Text = "Flight Information";
            this.btnFlightInformation.UseVisualStyleBackColor = false;
            this.btnFlightInformation.Click += new System.EventHandler(this.BtnFlightInformation_Click_1);
            // 
            // tbSearchAirplane
            // 
            this.tbSearchAirplane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSearchAirplane.Location = new System.Drawing.Point(5, 57);
            this.tbSearchAirplane.Name = "tbSearchAirplane";
            this.tbSearchAirplane.Size = new System.Drawing.Size(225, 41);
            this.tbSearchAirplane.TabIndex = 16;
            this.tbSearchAirplane.Text = "Search";
            this.tbSearchAirplane.UseVisualStyleBackColor = false;
            this.tbSearchAirplane.Click += new System.EventHandler(this.TbSearchAirplane_Click_1);
            // 
            // tbSearchID
            // 
            this.tbSearchID.Location = new System.Drawing.Point(39, 24);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(159, 25);
            this.tbSearchID.TabIndex = 2;
            // 
            // btnAddPassengers
            // 
            this.btnAddPassengers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPassengers.Location = new System.Drawing.Point(5, 151);
            this.btnAddPassengers.Name = "btnAddPassengers";
            this.btnAddPassengers.Size = new System.Drawing.Size(225, 41);
            this.btnAddPassengers.TabIndex = 16;
            this.btnAddPassengers.Text = "Add Passengers to Selected Plane";
            this.btnAddPassengers.UseVisualStyleBackColor = false;
            this.btnAddPassengers.Click += new System.EventHandler(this.BtnAddPassengers_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Created Planes";
            // 
            // lbCreatedAriplanes
            // 
            this.lbCreatedAriplanes.FormattingEnabled = true;
            this.lbCreatedAriplanes.ItemHeight = 17;
            this.lbCreatedAriplanes.Location = new System.Drawing.Point(12, 260);
            this.lbCreatedAriplanes.Name = "lbCreatedAriplanes";
            this.lbCreatedAriplanes.Size = new System.Drawing.Size(672, 157);
            this.lbCreatedAriplanes.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateCustom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPlaneType);
            this.groupBox1.Controls.Add(this.btnCreateFlight);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 210);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create an Airplane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "*from smallest to largest";
            // 
            // cbPlaneType
            // 
            this.cbPlaneType.FormattingEnabled = true;
            this.cbPlaneType.Items.AddRange(new object[] {
            "Dornier 328",
            "Boeing 737",
            "Boeing 767",
            "Boeing 747-8",
            "Airbus A380"});
            this.cbPlaneType.Location = new System.Drawing.Point(6, 49);
            this.cbPlaneType.Name = "cbPlaneType";
            this.cbPlaneType.Size = new System.Drawing.Size(404, 25);
            this.cbPlaneType.TabIndex = 2;
            this.cbPlaneType.SelectedIndexChanged += new System.EventHandler(this.CbPlaneType_SelectedIndexChanged);
            this.cbPlaneType.SizeChanged += new System.EventHandler(this.CbPlaneType_SizeChanged);
            this.cbPlaneType.Click += new System.EventHandler(this.CbPlaneType_Click);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateFlight.Location = new System.Drawing.Point(6, 80);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(404, 78);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Choose Aircraft";
            this.btnCreateFlight.UseVisualStyleBackColor = false;
            this.btnCreateFlight.Click += new System.EventHandler(this.BtnCreateFlight_Click_1);
            // 
            // btnCreateCustom
            // 
            this.btnCreateCustom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateCustom.Location = new System.Drawing.Point(6, 164);
            this.btnCreateCustom.Name = "btnCreateCustom";
            this.btnCreateCustom.Size = new System.Drawing.Size(404, 36);
            this.btnCreateCustom.TabIndex = 4;
            this.btnCreateCustom.Text = "Create a Custom Aircraft";
            this.btnCreateCustom.UseVisualStyleBackColor = false;
            this.btnCreateCustom.Click += new System.EventHandler(this.BtnCreateCustom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(6, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 41);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Aircraft";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // AirControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 497);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCreatedAriplanes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AirControl";
            this.Text = "Air Control";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnFlightInformation;
        private System.Windows.Forms.Button tbSearchAirplane;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Button btnAddPassengers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbCreatedAriplanes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFlight;
        private System.Windows.Forms.Button btnCreateCustom;
        private System.Windows.Forms.ComboBox cbPlaneType;
        private System.Windows.Forms.Button btnDelete;
    }
}

