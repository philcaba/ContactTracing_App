
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
            this.SuspendLayout();
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(12, 27);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(134, 23);
            this.txBxName.TabIndex = 0;
            // 
            // txBoxAddress
            // 
            this.txBoxAddress.Location = new System.Drawing.Point(12, 198);
            this.txBoxAddress.Name = "txBoxAddress";
            this.txBoxAddress.Size = new System.Drawing.Size(134, 23);
            this.txBoxAddress.TabIndex = 1;
            // 
            // txBxAge
            // 
            this.txBxAge.Location = new System.Drawing.Point(12, 349);
            this.txBxAge.Name = "txBxAge";
            this.txBxAge.Size = new System.Drawing.Size(134, 23);
            this.txBxAge.TabIndex = 2;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(49, 90);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(56, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lstBoxOutput
            // 
            this.lstBoxOutput.FormattingEnabled = true;
            this.lstBoxOutput.ItemHeight = 15;
            this.lstBoxOutput.Location = new System.Drawing.Point(202, 27);
            this.lstBoxOutput.Name = "lstBoxOutput";
            this.lstBoxOutput.Size = new System.Drawing.Size(251, 349);
            this.lstBoxOutput.TabIndex = 4;
            this.lstBoxOutput.SelectedIndexChanged += new System.EventHandler(this.lstBoxOutput_SelectedIndexChanged);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(49, 255);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(56, 23);
            this.btnAddAddress.TabIndex = 5;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            // 
            // btnAddAge
            // 
            this.btnAddAge.Location = new System.Drawing.Point(49, 390);
            this.btnAddAge.Name = "btnAddAge";
            this.btnAddAge.Size = new System.Drawing.Size(56, 23);
            this.btnAddAge.TabIndex = 6;
            this.btnAddAge.Text = "Add";
            this.btnAddAge.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 445);
            this.Controls.Add(this.btnAddAge);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lstBoxOutput);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txBxAge);
            this.Controls.Add(this.txBoxAddress);
            this.Controls.Add(this.txBxName);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

