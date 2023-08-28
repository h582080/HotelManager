namespace AdminDashboard
{
    partial class ServiceRequestsForm
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
            dgRequests = new DataGridView();
            RoomNumber = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            ServiceType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            btnRemove = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRequests).BeginInit();
            SuspendLayout();
            // 
            // dgRequests
            // 
            dgRequests.AllowUserToAddRows = false;
            dgRequests.AllowUserToDeleteRows = false;
            dgRequests.AllowUserToOrderColumns = true;
            dgRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRequests.Columns.AddRange(new DataGridViewColumn[] { RoomNumber, RequestDate, ServiceType, Status, Notes });
            dgRequests.Location = new Point(14, 59);
            dgRequests.Margin = new Padding(3, 4, 3, 4);
            dgRequests.Name = "dgRequests";
            dgRequests.ReadOnly = true;
            dgRequests.RowHeadersWidth = 51;
            dgRequests.RowTemplate.Height = 25;
            dgRequests.Size = new Size(621, 200);
            dgRequests.TabIndex = 0;
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.HeaderText = "RoomNumber";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            RoomNumber.Width = 125;
            // 
            // RequestDate
            // 
            RequestDate.DataPropertyName = "RequestDate";
            RequestDate.HeaderText = "Request Date";
            RequestDate.MinimumWidth = 6;
            RequestDate.Name = "RequestDate";
            RequestDate.ReadOnly = true;
            RequestDate.Width = 125;
            // 
            // ServiceType
            // 
            ServiceType.DataPropertyName = "ServiceType";
            ServiceType.HeaderText = "Service Type";
            ServiceType.MinimumWidth = 6;
            ServiceType.Name = "ServiceType";
            ServiceType.ReadOnly = true;
            ServiceType.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Notes
            // 
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notes";
            Notes.MinimumWidth = 6;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 125;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(24, 20);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 31);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Delete";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(135, 20);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ServiceRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 296);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemove);
            Controls.Add(dgRequests);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServiceRequestsForm";
            Text = "ServiceRequestsForm";
            ((System.ComponentModel.ISupportInitialize)dgRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgRequests;
        private Button btnRemove;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn ServiceType;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Notes;
        private Button btnRefresh;
    }
}