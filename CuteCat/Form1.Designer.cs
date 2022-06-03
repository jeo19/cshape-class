namespace CuteCat
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPannel = new System.Windows.Forms.Panel();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusNewPannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CusDetailPannel.SuspendLayout();
            this.CusNewPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(191, 327);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(96, 30);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "Create Adoptee";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPannel
            // 
            this.CusDetailPannel.Controls.Add(this.CusIsQualified);
            this.CusDetailPannel.Controls.Add(this.label2);
            this.CusDetailPannel.Controls.Add(this.CusDescription);
            this.CusDetailPannel.Controls.Add(this.label6);
            this.CusDetailPannel.Controls.Add(this.CusAddress);
            this.CusDetailPannel.Controls.Add(this.label5);
            this.CusDetailPannel.Controls.Add(this.CusAge);
            this.CusDetailPannel.Controls.Add(this.label4);
            this.CusDetailPannel.Controls.Add(this.CusFullName);
            this.CusDetailPannel.Controls.Add(this.label3);
            this.CusDetailPannel.Location = new System.Drawing.Point(472, 24);
            this.CusDetailPannel.Name = "CusDetailPannel";
            this.CusDetailPannel.Size = new System.Drawing.Size(303, 381);
            this.CusDetailPannel.TabIndex = 1;
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(80, 148);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(35, 13);
            this.CusDescription.TabIndex = 10;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description:";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(80, 119);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(35, 13);
            this.CusAddress.TabIndex = 8;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(80, 65);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(35, 13);
            this.CusAge.TabIndex = 6;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(80, 37);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(35, 13);
            this.CusFullName.TabIndex = 4;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name:";
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(80, 94);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(35, 13);
            this.CusIsQualified.TabIndex = 12;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adoptable:";
            // 
            // CusNewPannel
            // 
            this.CusNewPannel.Controls.Add(this.CusNewDescription);
            this.CusNewPannel.Controls.Add(this.label10);
            this.CusNewPannel.Controls.Add(this.CreateCustomer);
            this.CusNewPannel.Controls.Add(this.CusNewAddress);
            this.CusNewPannel.Controls.Add(this.label9);
            this.CusNewPannel.Controls.Add(this.CusNewBirthday);
            this.CusNewPannel.Controls.Add(this.label8);
            this.CusNewPannel.Controls.Add(this.CusNewFirstName);
            this.CusNewPannel.Controls.Add(this.label7);
            this.CusNewPannel.Controls.Add(this.CusNewLastName);
            this.CusNewPannel.Controls.Add(this.label1);
            this.CusNewPannel.Location = new System.Drawing.Point(154, 24);
            this.CusNewPannel.Name = "CusNewPannel";
            this.CusNewPannel.Size = new System.Drawing.Size(303, 381);
            this.CusNewPannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(86, 20);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(100, 20);
            this.CusNewLastName.TabIndex = 1;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(86, 46);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(100, 20);
            this.CusNewFirstName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(86, 72);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(100, 20);
            this.CusNewBirthday.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birth Day:";
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(86, 98);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(201, 20);
            this.CusNewAddress.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Address:";
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(86, 127);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(201, 173);
            this.CusNewDescription.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Description:";
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(12, 24);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(126, 212);
            this.CustomerList.TabIndex = 3;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPannel);
            this.Controls.Add(this.CusDetailPannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPannel.ResumeLayout(false);
            this.CusDetailPannel.PerformLayout();
            this.CusNewPannel.ResumeLayout(false);
            this.CusNewPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPannel;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CusNewPannel;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CustomerList;
    }
}

