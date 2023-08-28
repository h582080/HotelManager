namespace AdminDashboard
{
    partial class MainAdministrationDashboard
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
            btnRooms = new Button();
            btnReservations = new Button();
            btnRequests = new Button();
            btnCustomers = new Button();
            SuspendLayout();
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(23, 22);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(140, 61);
            btnRooms.TabIndex = 0;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnReservations
            // 
            btnReservations.Location = new Point(217, 22);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(140, 61);
            btnReservations.TabIndex = 1;
            btnReservations.Text = "Reservations";
            btnReservations.UseVisualStyleBackColor = true;
            btnReservations.Click += btnReservations_Click;
            // 
            // btnRequests
            // 
            btnRequests.Location = new Point(23, 108);
            btnRequests.Name = "btnRequests";
            btnRequests.Size = new Size(140, 61);
            btnRequests.TabIndex = 2;
            btnRequests.Text = "Service Requests";
            btnRequests.UseVisualStyleBackColor = true;
            btnRequests.Click += btnRequests_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(217, 108);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(140, 61);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(btnCustomers);
            Controls.Add(btnRequests);
            Controls.Add(btnReservations);
            Controls.Add(btnRooms);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRooms;
        private Button btnReservations;
        private Button btnRequests;
        private Button btnCustomers;
    }
}