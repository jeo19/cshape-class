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
            this.label1 = new System.Windows.Forms.Label();
            this.CusLastName = new System.Windows.Forms.Label();
            this.CusFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusDetailPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(51, 51);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(96, 30);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "Create Adoptee";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPannel
            // 
            this.CusDetailPannel.Controls.Add(this.CusDescription);
            this.CusDetailPannel.Controls.Add(this.label6);
            this.CusDetailPannel.Controls.Add(this.CusAddress);
            this.CusDetailPannel.Controls.Add(this.label5);
            this.CusDetailPannel.Controls.Add(this.CusAge);
            this.CusDetailPannel.Controls.Add(this.label4);
            this.CusDetailPannel.Controls.Add(this.CusFirstName);
            this.CusDetailPannel.Controls.Add(this.label3);
            this.CusDetailPannel.Controls.Add(this.CusLastName);
            this.CusDetailPannel.Controls.Add(this.label1);
            this.CusDetailPannel.Location = new System.Drawing.Point(472, 24);
            this.CusDetailPannel.Name = "CusDetailPannel";
            this.CusDetailPannel.Size = new System.Drawing.Size(303, 405);
            this.CusDetailPannel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CusLastName
            // 
            this.CusLastName.AutoSize = true;
            this.CusLastName.Location = new System.Drawing.Point(80, 9);
            this.CusLastName.Name = "CusLastName";
            this.CusLastName.Size = new System.Drawing.Size(35, 13);
            this.CusLastName.TabIndex = 2;
            this.CusLastName.Text = "label2";
            // 
            // CusFirstName
            // 
            this.CusFirstName.AutoSize = true;
            this.CusFirstName.Location = new System.Drawing.Point(80, 37);
            this.CusFirstName.Name = "CusFirstName";
            this.CusFirstName.Size = new System.Drawing.Size(35, 13);
            this.CusFirstName.TabIndex = 4;
            this.CusFirstName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
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
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(80, 95);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(35, 13);
            this.CusAddress.TabIndex = 8;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(80, 124);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(35, 13);
            this.CusDescription.TabIndex = 10;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CusDetailPannel);
            this.Controls.Add(this.CreateCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPannel.ResumeLayout(false);
            this.CusDetailPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusLastName;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label6;
    }
}

