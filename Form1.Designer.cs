namespace Chapter_1_3_Basic_Input_Assignment
{
    partial class BasicInput
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.tkbHeight = new System.Windows.Forms.TrackBar();
            this.lblReadOut = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(211, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Please enter your name:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(24, 156);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(274, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Please select your height in cm:";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(24, 92);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(196, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Please selectyour age:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(371, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 26);
            this.txtName.TabIndex = 3;
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.Location = new System.Drawing.Point(371, 90);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(50, 26);
            this.nudAge.TabIndex = 4;
            // 
            // tkbHeight
            // 
            this.tkbHeight.Location = new System.Drawing.Point(360, 156);
            this.tkbHeight.Maximum = 200;
            this.tkbHeight.Minimum = 100;
            this.tkbHeight.Name = "tkbHeight";
            this.tkbHeight.Size = new System.Drawing.Size(220, 45);
            this.tkbHeight.TabIndex = 7;
            this.tkbHeight.Value = 100;
            this.tkbHeight.ValueChanged += new System.EventHandler(this.tkbHeight_Scroll);
            // 
            // lblReadOut
            // 
            this.lblReadOut.AutoSize = true;
            this.lblReadOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadOut.Location = new System.Drawing.Point(368, 185);
            this.lblReadOut.Name = "lblReadOut";
            this.lblReadOut.Size = new System.Drawing.Size(81, 16);
            this.lblReadOut.TabIndex = 8;
            this.lblReadOut.Text = "READOUT: ";
            this.lblReadOut.Click += new System.EventHandler(this.lblReadOut_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(458, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 35);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(28, 258);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 10;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(27, 465);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(542, 107);
            this.lblAnswer.TabIndex = 11;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("High Tower Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(228, 350);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 32);
            this.lblResults.TabIndex = 12;
            this.lblResults.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 314);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblReadOut);
            this.Controls.Add(this.tkbHeight);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Location = new System.Drawing.Point(0, -20);
            this.Name = "BasicInput";
            this.Text = "Basic Input";
            this.Load += new System.EventHandler(this.BasicInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TrackBar tkbHeight;
        private System.Windows.Forms.Label lblReadOut;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblResults;
    }
}

