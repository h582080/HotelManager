namespace AdminDashboard
{
    partial class ReservationEditor
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbChecked = new System.Windows.Forms.ComboBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.dtStartOn = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dtEndOn = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(126, 108);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 23);
            this.cbStatus.TabIndex = 0;
            // 
            // cbChecked
            // 
            this.cbChecked.FormattingEnabled = true;
            this.cbChecked.Location = new System.Drawing.Point(126, 155);
            this.cbChecked.Name = "cbChecked";
            this.cbChecked.Size = new System.Drawing.Size(124, 23);
            this.cbChecked.TabIndex = 1;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(126, 64);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(124, 23);
            this.txtRoomId.TabIndex = 2;
            // 
            // dtStartOn
            // 
            this.dtStartOn.CustomFormat = "dd/MM/yyyy";
            this.dtStartOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartOn.Location = new System.Drawing.Point(126, 203);
            this.dtStartOn.Name = "dtStartOn";
            this.dtStartOn.Size = new System.Drawing.Size(124, 23);
            this.dtStartOn.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(126, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // dtEndOn
            // 
            this.dtEndOn.CustomFormat = "dd/MM/yyyy";
            this.dtEndOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndOn.Location = new System.Drawing.Point(126, 245);
            this.dtEndOn.Name = "dtEndOn";
            this.dtEndOn.Size = new System.Drawing.Size(124, 23);
            this.dtEndOn.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Checked In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "To";
            // 
            // ReservationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtEndOn);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dtStartOn);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.cbChecked);
            this.Controls.Add(this.cbStatus);
            this.Name = "ReservationEditor";
            this.Text = "ReservationEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbStatus;
        private ComboBox cbChecked;
        private TextBox txtRoomId;
        private DateTimePicker dtStartOn;
        private TextBox txtUsername;
        private DateTimePicker dtEndOn;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}