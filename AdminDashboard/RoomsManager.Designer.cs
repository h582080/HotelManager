namespace AdminDashboard
{
    partial class RoomsManager
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
            this.dataGridRooms = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Layout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRooms
            // 
            this.dataGridRooms.AllowUserToAddRows = false;
            this.dataGridRooms.AllowUserToDeleteRows = false;
            this.dataGridRooms.AllowUserToOrderColumns = true;
            this.dataGridRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.RoomNumber,
            this.Beds,
            this.Occupancy,
            this.Layout,
            this.Price});
            this.dataGridRooms.Location = new System.Drawing.Point(34, 61);
            this.dataGridRooms.MultiSelect = false;
            this.dataGridRooms.Name = "dataGridRooms";
            this.dataGridRooms.ReadOnly = true;
            this.dataGridRooms.RowTemplate.Height = 25;
            this.dataGridRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRooms.Size = new System.Drawing.Size(646, 333);
            this.dataGridRooms.TabIndex = 0;
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "RoomId";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Beds
            // 
            this.Beds.DataPropertyName = "Beds";
            this.Beds.HeaderText = "Number of Beds";
            this.Beds.Name = "Beds";
            this.Beds.ReadOnly = true;
            // 
            // Occupancy
            // 
            this.Occupancy.DataPropertyName = "Occupancy";
            this.Occupancy.HeaderText = "Occupancy";
            this.Occupancy.Name = "Occupancy";
            this.Occupancy.ReadOnly = true;
            // 
            // Layout
            // 
            this.Layout.DataPropertyName = "Layout";
            this.Layout.HeaderText = "Layout";
            this.Layout.Name = "Layout";
            this.Layout.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(34, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(115, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Add New Room";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(222, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Room";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(303, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Room";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "data state";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(475, 32);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(89, 23);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "Book Room";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(570, 32);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(107, 23);
            this.btnAddRequest.TabIndex = 7;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // RoomsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dataGridRooms);
            this.Name = "RoomsManager";
            this.Text = "RoomsManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridRooms;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnReload;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private Button btnBook;
        private Button btnAddRequest;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Beds;
        private DataGridViewTextBoxColumn Occupancy;
        private DataGridViewTextBoxColumn Layout;
        private DataGridViewTextBoxColumn Price;
    }
}