namespace PartB
{
    partial class frmPartB
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalc = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 74);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(315, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Enter a Number to Add to the List:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(73, 190);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 41);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(462, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 251);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(287, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.Location = new System.Drawing.Point(95, 124);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(54, 19);
            this.lblCalc.TabIndex = 5;
            this.lblCalc.Text = "label";
            this.lblCalc.Visible = false;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(333, 71);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 6;
            // 
            // frmPartB
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 303);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmPartB";
            this.Text = "Part B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.TextBox txtInput;
    }
}

