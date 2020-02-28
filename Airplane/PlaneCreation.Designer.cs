namespace Airplane
{
    partial class PlaneCreation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoback = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nmEconomy = new System.Windows.Forms.NumericUpDown();
            this.nmBusiness = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEconomy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlane.Location = new System.Drawing.Point(36, 9);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(317, 40);
            this.lblPlane.TabIndex = 18;
            this.lblPlane.Text = "Custom Plane Creator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoback);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.nmEconomy);
            this.groupBox1.Controls.Add(this.nmBusiness);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Location = new System.Drawing.Point(43, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 231);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoback.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoback.Location = new System.Drawing.Point(15, 32);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(76, 188);
            this.btnGoback.TabIndex = 23;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.BtnGoback_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(97, 172);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(169, 48);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // nmEconomy
            // 
            this.nmEconomy.Location = new System.Drawing.Point(97, 135);
            this.nmEconomy.Name = "nmEconomy";
            this.nmEconomy.ReadOnly = true;
            this.nmEconomy.Size = new System.Drawing.Size(169, 25);
            this.nmEconomy.TabIndex = 21;
            // 
            // nmBusiness
            // 
            this.nmBusiness.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmBusiness.Location = new System.Drawing.Point(97, 83);
            this.nmBusiness.Name = "nmBusiness";
            this.nmBusiness.ReadOnly = true;
            this.nmBusiness.Size = new System.Drawing.Size(169, 25);
            this.nmBusiness.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount of Economy Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of Business Seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(97, 32);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(169, 25);
            this.tbType.TabIndex = 1;
            // 
            // PlaneCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPlane);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlaneCreation";
            this.Text = "Custom Plane Creater";
            this.Load += new System.EventHandler(this.PlaneCreation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmEconomy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmEconomy;
        private System.Windows.Forms.NumericUpDown nmBusiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnCreate;
    }
}