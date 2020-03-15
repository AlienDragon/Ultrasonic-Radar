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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scrDist = new System.Windows.Forms.HScrollBar();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrAngle
            // 
            this.scrAngle.Location = new System.Drawing.Point(3, 41);
            this.scrAngle.Maximum = 180;
            this.scrAngle.Name = "scrAngle";
            this.scrAngle.Size = new System.Drawing.Size(239, 17);
            this.scrAngle.TabIndex = 0;
            this.scrAngle.Value = 90;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(187, 137);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Complete";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.scrDist);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.scrAngle);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(250, 119);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            this.gbData.Text = "Set Data";
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
            // scrDist
            // 
            this.scrDist.Location = new System.Drawing.Point(3, 99);
            this.scrDist.Maximum = 200;
            this.scrDist.Name = "scrDist";
            this.scrDist.Size = new System.Drawing.Size(239, 17);
            this.scrDist.TabIndex = 5;
            this.scrDist.Value = 90;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 166);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnFinish);
            this.Name = "AddData";
            this.Text = "Data creator";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrAngle;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scrDist;
    }
}