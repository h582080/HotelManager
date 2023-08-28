namespace AdminDashboard
{
    partial class ReservationsManager
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChecked = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.Status,
            this.StartOn,
            this.EndOn,
            this.CustomerEmail,
            this.CheckedIn,
            this.CustomerId,
            this.RoomId});
            this.dgvReservations.Location = new System.Drawing.Point(12, 62);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowTemplate.Height = 25;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(845, 215);
            this.dgvReservations.TabIndex = 0;
            this.dgvReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellContentClick);
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // StartOn
            // 
            this.StartOn.DataPropertyName = "StartOn";
            this.StartOn.HeaderText = "Starts On";
            this.StartOn.Name = "StartOn";
            this.StartOn.ReadOnly = true;
            // 
            // EndOn
            // 
            this.EndOn.DataPropertyName = "EndOn";
            this.EndOn.HeaderText = "Ends On";
            this.EndOn.Name = "EndOn";
            this.EndOn.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.DataPropertyName = "Username";
            this.CustomerEmail.HeaderText = "Customer Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            // 
            // CheckedIn
            // 
            this.CheckedIn.DataPropertyName = "CheckedIn";
            this.CheckedIn.HeaderText = "Checked In";
            this.CheckedIn.Name = "CheckedIn";
            this.CheckedIn.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "RoomId";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(28, 12);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 33);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChecked
            // 
            this.btnChecked.Location = new System.Drawing.Point(251, 12);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(116, 33);
            this.btnChecked.TabIndex = 4;
            this.btnChecked.Text = "Check In";
            this.btnChecked.UseVisualStyleBackColor = true;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(383, 12);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 33);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(524, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 37);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReservationsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 299);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnChecked);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvReservations);
            this.Name = "ReservationsManager";
            this.Text = "ReservationsManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvReservations;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn StartOn;
        private DataGridViewTextBoxColumn EndOn;
        private DataGridViewTextBoxColumn CustomerEmail;
        private DataGridViewTextBoxColumn CheckedIn;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn RoomId;
        private Button btnConfirm;
        private Button btnDelete;
        private Button btnChecked;
        private Button btnCheckOut;
        private Button btnRefresh;
    }
}