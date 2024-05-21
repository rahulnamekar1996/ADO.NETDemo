namespace ADO.NETDemo
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
            this.txtEmployeeid = new System.Windows.Forms.TextBox();
            this.lblEmployeename = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSallryy = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAllResult = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeid
            // 
            this.txtEmployeeid.Location = new System.Drawing.Point(226, 39);
            this.txtEmployeeid.Name = "txtEmployeeid";
            this.txtEmployeeid.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeid.TabIndex = 0;
            // 
            // lblEmployeename
            // 
            this.lblEmployeename.AutoSize = true;
            this.lblEmployeename.Location = new System.Drawing.Point(85, 42);
            this.lblEmployeename.Name = "lblEmployeename";
            this.lblEmployeename.Size = new System.Drawing.Size(68, 13);
            this.lblEmployeename.TabIndex = 1;
            this.lblEmployeename.Text = "Employee Id ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = " Employee Name";
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Location = new System.Drawing.Point(226, 76);
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeename.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City Of Employee";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(226, 123);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 20);
            this.txtcity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sallary Of Employee";
            // 
            // txtSallryy
            // 
            this.txtSallryy.Location = new System.Drawing.Point(226, 162);
            this.txtSallryy.Name = "txtSallryy";
            this.txtSallryy.Size = new System.Drawing.Size(100, 20);
            this.txtSallryy.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 168);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(12, 227);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAllResult
            // 
            this.btnShowAllResult.Location = new System.Drawing.Point(576, 227);
            this.btnShowAllResult.Name = "btnShowAllResult";
            this.btnShowAllResult.Size = new System.Drawing.Size(144, 23);
            this.btnShowAllResult.TabIndex = 12;
            this.btnShowAllResult.Text = "Show All Results ";
            this.btnShowAllResult.UseVisualStyleBackColor = true;
            this.btnShowAllResult.Click += new System.EventHandler(this.btnShowAllResult_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAllResult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSallryy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmployeename);
            this.Controls.Add(this.lblEmployeename);
            this.Controls.Add(this.txtEmployeeid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeid;
        private System.Windows.Forms.Label lblEmployeename;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSallryy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAllResult;
        private System.Windows.Forms.Button btnSearch;
    }
}

