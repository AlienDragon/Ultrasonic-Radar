namespace RadarDisplay
{
    partial class AddData
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
            this.scrAngle = new System.Windows.Forms.HScrollBar();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbDist = new System.Windows.Forms.TextBox();
            this.scrDist = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrAngle
            // 
            this.scrAngle.Location = new System.Drawing.Point(3, 41);
            this.scrAngle.Maximum = 189;
            this.scrAngle.Name = "scrAngle";
            this.scrAngle.Size = new System.Drawing.Size(293, 17);
            this.scrAngle.TabIndex = 0;
            this.scrAngle.Value = 90;
            this.scrAngle.ValueChanged += new System.EventHandler(this.scrAngle_ValueChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(236, 137);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Complete";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.tbAngle);
            this.gbData.Controls.Add(this.tbDist);
            this.gbData.Controls.Add(this.scrDist);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.scrAngle);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(299, 119);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            this.gbData.Text = "Set Data";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(80, 20);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(45, 20);
            this.tbAngle.TabIndex = 7;
            this.tbAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAngle_KeyPress);
            // 
            // tbDist
            // 
            this.tbDist.Location = new System.Drawing.Point(90, 74);
            this.tbDist.Name = "tbDist";
            this.tbDist.Size = new System.Drawing.Size(45, 20);
            this.tbDist.TabIndex = 6;
            this.tbDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDist_KeyPress);
            // 
            // scrDist
            // 
            this.scrDist.Location = new System.Drawing.Point(3, 99);
            this.scrDist.Maximum = 200;
            this.scrDist.Name = "scrDist";
            this.scrDist.Size = new System.Drawing.Size(293, 17);
            this.scrDist.TabIndex = 5;
            this.scrDist.Value = 90;
            this.scrDist.ValueChanged += new System.EventHandler(this.scrDist_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distance (cm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servo Angle:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 137);
            this.lblError.MaximumSize = new System.Drawing.Size(225, 30);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error:";
            this.lblError.Visible = false;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 166);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnFinish);
            this.Name = "AddData";
            this.Text = "Data creator";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrAngle;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scrDist;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbDist;
        private System.Windows.Forms.Label lblError;
    }
}