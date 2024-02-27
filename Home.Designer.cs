namespace ManageEmployers
{
    partial class Home
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
            this.PanelHome = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ButtonDetails = new System.Windows.Forms.Button();
            this.ButtonEmpoyees = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.PanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.PanelHome.Controls.Add(this.labelHome);
            this.PanelHome.Controls.Add(this.ButtonAbout);
            this.PanelHome.Controls.Add(this.ButtonDetails);
            this.PanelHome.Controls.Add(this.ButtonEmpoyees);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(626, 397);
            this.PanelHome.TabIndex = 0;
            this.PanelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHome_Paint);
            this.PanelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseDown);
            this.PanelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseMove);
            this.PanelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseUp);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(185, 72);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(252, 91);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Home";
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAbout.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAbout.Location = new System.Drawing.Point(389, 224);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(119, 43);
            this.ButtonAbout.TabIndex = 2;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonDetails
            // 
            this.ButtonDetails.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonDetails.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonDetails.Location = new System.Drawing.Point(255, 224);
            this.ButtonDetails.Name = "ButtonDetails";
            this.ButtonDetails.Size = new System.Drawing.Size(119, 43);
            this.ButtonDetails.TabIndex = 1;
            this.ButtonDetails.Text = "Details";
            this.ButtonDetails.UseVisualStyleBackColor = true;
            this.ButtonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
            // 
            // ButtonEmpoyees
            // 
            this.ButtonEmpoyees.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonEmpoyees.Location = new System.Drawing.Point(122, 224);
            this.ButtonEmpoyees.Name = "ButtonEmpoyees";
            this.ButtonEmpoyees.Size = new System.Drawing.Size(119, 43);
            this.ButtonEmpoyees.TabIndex = 0;
            this.ButtonEmpoyees.Text = "Employees";
            this.ButtonEmpoyees.UseVisualStyleBackColor = true;
            this.ButtonEmpoyees.Click += new System.EventHandler(this.ButtonEmpoyees_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.Location = new System.Drawing.Point(605, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(21, 24);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 397);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PanelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(626, 397);
            this.MinimumSize = new System.Drawing.Size(626, 397);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managing Employees";
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonDetails;
        private System.Windows.Forms.Button ButtonEmpoyees;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label ExitBtn;
    }
}

