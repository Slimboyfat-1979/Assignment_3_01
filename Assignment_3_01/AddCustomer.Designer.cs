namespace Assignment_3_01
{
    partial class AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerEntry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eBalanceText = new System.Windows.Forms.TextBox();
            this.IBalanceText = new System.Windows.Forms.TextBox();
            this.OBalanceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Customer";
            // 
            // customerEntry
            // 
            this.customerEntry.Location = new System.Drawing.Point(451, 132);
            this.customerEntry.Name = "customerEntry";
            this.customerEntry.Size = new System.Drawing.Size(292, 20);
            this.customerEntry.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please Enter Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "EveryDay Account Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Investment Account Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Omni Account Balance :";
            // 
            // eBalanceText
            // 
            this.eBalanceText.Location = new System.Drawing.Point(451, 198);
            this.eBalanceText.Name = "eBalanceText";
            this.eBalanceText.Size = new System.Drawing.Size(123, 20);
            this.eBalanceText.TabIndex = 8;
            // 
            // IBalanceText
            // 
            this.IBalanceText.Location = new System.Drawing.Point(451, 264);
            this.IBalanceText.Name = "IBalanceText";
            this.IBalanceText.Size = new System.Drawing.Size(123, 20);
            this.IBalanceText.TabIndex = 9;
            // 
            // OBalanceText
            // 
            this.OBalanceText.Location = new System.Drawing.Point(451, 327);
            this.OBalanceText.Name = "OBalanceText";
            this.OBalanceText.Size = new System.Drawing.Size(123, 20);
            this.OBalanceText.TabIndex = 10;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.OBalanceText);
            this.Controls.Add(this.IBalanceText);
            this.Controls.Add(this.eBalanceText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerEntry);
            this.Controls.Add(this.label2);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.customerEntry, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.eBalanceText, 0);
            this.Controls.SetChildIndex(this.IBalanceText, 0);
            this.Controls.SetChildIndex(this.OBalanceText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerEntry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eBalanceText;
        private System.Windows.Forms.TextBox IBalanceText;
        private System.Windows.Forms.TextBox OBalanceText;
    }
}