namespace FacultyPagingSystem
{
    partial class FacultyInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyInterface));
            this.btnRespond = new System.Windows.Forms.Button();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.facultyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataLog = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inQueue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.formNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboAvailability = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.TextBox();
            this.Arduino1 = new System.IO.Ports.SerialPort(this.components);
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRespond
            // 
            this.btnRespond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnRespond.FlatAppearance.BorderSize = 2;
            this.btnRespond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespond.ForeColor = System.Drawing.Color.White;
            this.btnRespond.Location = new System.Drawing.Point(253, 403);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(101, 35);
            this.btnRespond.TabIndex = 27;
            this.btnRespond.Text = "Respond";
            this.btnRespond.UseVisualStyleBackColor = false;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // studentNumber
            // 
            this.studentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber.Location = new System.Drawing.Point(405, 211);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.ReadOnly = true;
            this.studentNumber.Size = new System.Drawing.Size(180, 26);
            this.studentNumber.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(400, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "Student Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(210, 211);
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Size = new System.Drawing.Size(180, 26);
            this.studentName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(206, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "Student Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose.Location = new System.Drawing.Point(15, 282);
            this.purpose.Name = "purpose";
            this.purpose.ReadOnly = true;
            this.purpose.Size = new System.Drawing.Size(570, 26);
            this.purpose.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Purpose";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // facultyName
            // 
            this.facultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyName.Location = new System.Drawing.Point(15, 210);
            this.facultyName.Name = "facultyName";
            this.facultyName.ReadOnly = true;
            this.facultyName.Size = new System.Drawing.Size(180, 26);
            this.facultyName.TabIndex = 20;
            this.facultyName.TextChanged += new System.EventHandler(this.facultyName_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Faculty Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(21)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(135, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 95);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dataLog);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.inQueue);
            this.panel5.Location = new System.Drawing.Point(0, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 83);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(139)))), ((int)(((byte)(21)))));
            this.panel6.Location = new System.Drawing.Point(214, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 84);
            this.panel6.TabIndex = 32;
            // 
            // dataLog
            // 
            this.dataLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLog.ForeColor = System.Drawing.Color.White;
            this.dataLog.Location = new System.Drawing.Point(10, 38);
            this.dataLog.Name = "dataLog";
            this.dataLog.Size = new System.Drawing.Size(198, 39);
            this.dataLog.TabIndex = 9;
            this.dataLog.Text = "Data Log";
            this.dataLog.UseVisualStyleBackColor = true;
            this.dataLog.Click += new System.EventHandler(this.dataLog_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(428, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "In Queue:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inQueue
            // 
            this.inQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inQueue.ForeColor = System.Drawing.Color.White;
            this.inQueue.Location = new System.Drawing.Point(114, 1);
            this.inQueue.Name = "inQueue";
            this.inQueue.Size = new System.Drawing.Size(36, 36);
            this.inQueue.TabIndex = 11;
            this.inQueue.Text = "00";
            this.inQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(420, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 42);
            this.label11.TabIndex = 28;
            this.label11.Text = "F";
            // 
            // formNumber
            // 
            this.formNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formNumber.ForeColor = System.Drawing.Color.White;
            this.formNumber.Location = new System.Drawing.Point(164, -1);
            this.formNumber.Name = "formNumber";
            this.formNumber.Size = new System.Drawing.Size(61, 38);
            this.formNumber.TabIndex = 6;
            this.formNumber.Text = "0000";
            this.formNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Form Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 135);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 123);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.formNumber);
            this.panel2.Location = new System.Drawing.Point(135, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 40);
            this.panel2.TabIndex = 0;
            // 
            // cboAvailability
            // 
            this.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvailability.FormattingEnabled = true;
            this.cboAvailability.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboAvailability.Location = new System.Drawing.Point(16, 357);
            this.cboAvailability.Name = "cboAvailability";
            this.cboAvailability.Size = new System.Drawing.Size(180, 28);
            this.cboAvailability.TabIndex = 28;
            this.cboAvailability.SelectedIndexChanged += new System.EventHandler(this.cboAvailability_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Availability";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Response";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // response
            // 
            this.response.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.Location = new System.Drawing.Point(210, 357);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(375, 26);
            this.response.TabIndex = 31;
            // 
            // Arduino1
            // 
            this.Arduino1.PortName = "COM7";
            // 
            // FacultyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.response);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAvailability);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.facultyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyInterface";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRespond;
        private System.Windows.Forms.TextBox studentNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox purpose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox facultyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label formNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAvailability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dataLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.Panel panel6;
        private System.IO.Ports.SerialPort Arduino1;
    }
}