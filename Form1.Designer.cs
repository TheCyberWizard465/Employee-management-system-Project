namespace Employee_management_system
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
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.GBEmpinfo = new System.Windows.Forms.GroupBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.GBEmpinfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(6, 235);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.ForeColor = System.Drawing.Color.Black;
            this.updatebtn.Location = new System.Drawing.Point(156, 235);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.ForeColor = System.Drawing.Color.Black;
            this.viewbtn.Location = new System.Drawing.Point(87, 235);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(63, 23);
            this.viewbtn.TabIndex = 2;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(533, 274);
            this.DGV.TabIndex = 3;
            // 
            // GBEmpinfo
            // 
            this.GBEmpinfo.Controls.Add(this.lblSalary);
            this.GBEmpinfo.Controls.Add(this.lblId);
            this.GBEmpinfo.Controls.Add(this.lblDep);
            this.GBEmpinfo.Controls.Add(this.lblName);
            this.GBEmpinfo.Controls.Add(this.label9);
            this.GBEmpinfo.Controls.Add(this.label8);
            this.GBEmpinfo.Controls.Add(this.label7);
            this.GBEmpinfo.Controls.Add(this.label6);
            this.GBEmpinfo.ForeColor = System.Drawing.Color.GreenYellow;
            this.GBEmpinfo.Location = new System.Drawing.Point(12, 292);
            this.GBEmpinfo.Name = "GBEmpinfo";
            this.GBEmpinfo.Size = new System.Drawing.Size(533, 137);
            this.GBEmpinfo.TabIndex = 4;
            this.GBEmpinfo.TabStop = false;
            this.GBEmpinfo.Text = "Display Employee Info";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(415, 77);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(34, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "salary";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(299, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "id";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.ForeColor = System.Drawing.Color.White;
            this.lblDep.Location = new System.Drawing.Point(139, 77);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(60, 13);
            this.lblDep.TabIndex = 5;
            this.lblDep.Text = "department";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(7, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(415, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(280, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Student ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(139, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(98, 19);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(133, 20);
            this.txtname.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.viewbtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.updatebtn);
            this.groupBox2.Controls.Add(this.txtSalary);
            this.groupBox2.Controls.Add(this.addbtn);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtDep);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox2.Location = new System.Drawing.Point(551, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 274);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(98, 97);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(133, 20);
            this.txtSalary.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(98, 45);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(133, 20);
            this.txtDep.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchbtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox3.Location = new System.Drawing.Point(557, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 137);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchbtn.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.Location = new System.Drawing.Point(81, 117);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 20);
            this.searchbtn.TabIndex = 14;
            this.searchbtn.Text = "Find";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(66, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Employee ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(4, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBEmpinfo);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Employee Management System";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.GBEmpinfo.ResumeLayout(false);
            this.GBEmpinfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox GBEmpinfo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchbtn;
    }
}

