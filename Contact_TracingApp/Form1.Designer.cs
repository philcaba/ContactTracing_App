
namespace Contact_TracingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txBxName = new System.Windows.Forms.TextBox();
            this.txBoxAddress = new System.Windows.Forms.TextBox();
            this.txBxAge = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.lstBoxOutput = new System.Windows.Forms.ListBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnAddAge = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(21, 53);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(164, 23);
            this.txBxName.TabIndex = 0;
            this.txBxName.TextChanged += new System.EventHandler(this.txBxName_TextChanged);
            // 
            // txBoxAddress
            // 
            this.txBoxAddress.Location = new System.Drawing.Point(21, 163);
            this.txBoxAddress.Name = "txBoxAddress";
            this.txBoxAddress.Size = new System.Drawing.Size(163, 23);
            this.txBoxAddress.TabIndex = 1;
            // 
            // txBxAge
            // 
            this.txBxAge.Location = new System.Drawing.Point(22, 276);
            this.txBxAge.Name = "txBxAge";
            this.txBxAge.Size = new System.Drawing.Size(163, 23);
            this.txBxAge.TabIndex = 2;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(58, 106);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(83, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Add name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lstBoxOutput
            // 
            this.lstBoxOutput.FormattingEnabled = true;
            this.lstBoxOutput.ItemHeight = 15;
            this.lstBoxOutput.Location = new System.Drawing.Point(274, 27);
            this.lstBoxOutput.Name = "lstBoxOutput";
            this.lstBoxOutput.Size = new System.Drawing.Size(251, 349);
            this.lstBoxOutput.TabIndex = 4;
            this.lstBoxOutput.SelectedIndexChanged += new System.EventHandler(this.lstBoxOutput_SelectedIndexChanged);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(58, 218);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(83, 23);
            this.btnAddAddress.TabIndex = 5;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnAddAge
            // 
            this.btnAddAge.Location = new System.Drawing.Point(58, 335);
            this.btnAddAge.Name = "btnAddAge";
            this.btnAddAge.Size = new System.Drawing.Size(83, 23);
            this.btnAddAge.TabIndex = 6;
            this.btnAddAge.Text = "Add Age";
            this.btnAddAge.UseVisualStyleBackColor = true;
            this.btnAddAge.Click += new System.EventHandler(this.btnAddAge_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(355, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "AGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddAge);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lstBoxOutput);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txBxAge);
            this.Controls.Add(this.txBoxAddress);
            this.Controls.Add(this.txBxName);
            this.Name = "Form1";
            this.Text = "Contact Tracer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBxName;
        private System.Windows.Forms.TextBox txBoxAddress;
        private System.Windows.Forms.TextBox txBxAge;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.ListBox lstBoxOutput;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

