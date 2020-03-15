namespace RadarDisplay
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
            this.btnInit = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.gbCollect = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblCoord = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDataView = new System.Windows.Forms.ListBox();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAxis = new System.Windows.Forms.CheckBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTesting = new System.Windows.Forms.CheckBox();
            this.btnAddp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCollect.SuspendLayout();
            this.gbData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMap.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(6, 46);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(102, 43);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Initialise";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(6, 19);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 2;
            // 
            // gbCollect
            // 
            this.gbCollect.Controls.Add(this.btnEnd);
            this.gbCollect.Controls.Add(this.btnInit);
            this.gbCollect.Controls.Add(this.cbCom);
            this.gbCollect.Location = new System.Drawing.Point(12, 26);
            this.gbCollect.Name = "gbCollect";
            this.gbCollect.Size = new System.Drawing.Size(174, 100);
            this.gbCollect.TabIndex = 3;
            this.gbCollect.TabStop = false;
            this.gbCollect.Text = "Data Collection";
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(115, 47);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(50, 42);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "Stop";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnClearData);
            this.gbData.Controls.Add(this.btnSave);
            this.gbData.Controls.Add(this.groupBox4);
            this.gbData.Controls.Add(this.lbDataView);
            this.gbData.Enabled = false;
            this.gbData.Location = new System.Drawing.Point(12, 132);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(274, 300);
            this.gbData.TabIndex = 4;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(88, 122);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDel);
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Location = new System.Drawing.Point(7, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 145);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Point Data";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 119);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete Point";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAngle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDist, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCoord, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(124, 69);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(115, 25);
            this.lblAngle.TabIndex = 7;
            this.lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDist
            // 
            this.lblDist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(124, 46);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(115, 23);
            this.lblDist.TabIndex = 6;
            this.lblDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoord
            // 
            this.lblCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(124, 23);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(115, 23);
            this.lblCoord.TabIndex = 5;
            this.lblCoord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(124, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(115, 23);
            this.lblId.TabIndex = 4;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point ID: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "X, Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDataView
            // 
            this.lbDataView.FormattingEnabled = true;
            this.lbDataView.Location = new System.Drawing.Point(7, 20);
            this.lbDataView.Name = "lbDataView";
            this.lbDataView.Size = new System.Drawing.Size(255, 95);
            this.lbDataView.TabIndex = 0;
            this.lbDataView.SelectedIndexChanged += new System.EventHandler(this.lbDataView_SelectedIndexChanged);
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.groupBox5);
            this.gbMap.Controls.Add(this.pbDisplay);
            this.gbMap.Enabled = false;
            this.gbMap.Location = new System.Drawing.Point(292, 26);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(418, 411);
            this.gbMap.TabIndex = 5;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "Graphic Display";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAxis);
            this.groupBox5.Controls.Add(this.btnDraw);
            this.groupBox5.Location = new System.Drawing.Point(7, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 94);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display controls";
            // 
            // cbAxis
            // 
            this.cbAxis.AutoSize = true;
            this.cbAxis.Checked = true;
            this.cbAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAxis.Location = new System.Drawing.Point(7, 50);
            this.cbAxis.Name = "cbAxis";
            this.cbAxis.Size = new System.Drawing.Size(75, 17);
            this.cbAxis.TabIndex = 1;
            this.cbAxis.Text = "Show Axis";
            this.cbAxis.UseVisualStyleBackColor = true;
            this.cbAxis.CheckedChanged += new System.EventHandler(this.cbAxis_CheckedChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(7, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(82, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Refresh Map";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbDisplay.Location = new System.Drawing.Point(7, 20);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(400, 250);
            this.pbDisplay.TabIndex = 0;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDisplay_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadData});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(127, 22);
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cbTesting
            // 
            this.cbTesting.AutoSize = true;
            this.cbTesting.Location = new System.Drawing.Point(6, 19);
            this.cbTesting.Name = "cbTesting";
            this.cbTesting.Size = new System.Drawing.Size(91, 17);
            this.cbTesting.TabIndex = 4;
            this.cbTesting.Text = "Testing Mode";
            this.cbTesting.UseVisualStyleBackColor = true;
            this.cbTesting.CheckedChanged += new System.EventHandler(this.cbTesting_CheckedChanged);
            // 
            // btnAddp
            // 
            this.btnAddp.Enabled = false;
            this.btnAddp.Location = new System.Drawing.Point(6, 42);
            this.btnAddp.Name = "btnAddp";
            this.btnAddp.Size = new System.Drawing.Size(75, 23);
            this.btnAddp.TabIndex = 4;
            this.btnAddp.Text = "Add point";
            this.btnAddp.UseVisualStyleBackColor = true;
            this.btnAddp.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddp);
            this.groupBox1.Controls.Add(this.cbTesting);
            this.groupBox1.Location = new System.Drawing.Point(193, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Experimental";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbCollect);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Radar Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCollect.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbMap.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.GroupBox gbCollect;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbMap;
        private System.Windows.Forms.ListBox lbDataView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblCoord;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.CheckBox cbAxis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoadData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.CheckBox cbTesting;
        private System.Windows.Forms.Button btnAddp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

