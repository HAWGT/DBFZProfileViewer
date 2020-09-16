namespace DBFZTrainer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_steamid = new System.Windows.Forms.TextBox();
            this.lbl_steamid = new System.Windows.Forms.Label();
            this.btn_open_profile = new System.Windows.Forms.Button();
            this.background_find_game_process = new System.ComponentModel.BackgroundWorker();
            this.lbl_pidtxt = new System.Windows.Forms.Label();
            this.lbl_statustxt = new System.Windows.Forms.Label();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.lbl_playernametxt = new System.Windows.Forms.Label();
            this.txt_playername = new System.Windows.Forms.TextBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_steamid
            // 
            this.txt_steamid.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txt_steamid.Location = new System.Drawing.Point(73, 86);
            this.txt_steamid.Name = "txt_steamid";
            this.txt_steamid.ReadOnly = true;
            this.txt_steamid.Size = new System.Drawing.Size(134, 20);
            this.txt_steamid.TabIndex = 20;
            // 
            // lbl_steamid
            // 
            this.lbl_steamid.AutoSize = true;
            this.lbl_steamid.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lbl_steamid.Location = new System.Drawing.Point(12, 90);
            this.lbl_steamid.Name = "lbl_steamid";
            this.lbl_steamid.Size = new System.Drawing.Size(55, 13);
            this.lbl_steamid.TabIndex = 21;
            this.lbl_steamid.Text = "SteamID:";
            // 
            // btn_open_profile
            // 
            this.btn_open_profile.Enabled = false;
            this.btn_open_profile.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.btn_open_profile.Location = new System.Drawing.Point(213, 85);
            this.btn_open_profile.Name = "btn_open_profile";
            this.btn_open_profile.Size = new System.Drawing.Size(113, 23);
            this.btn_open_profile.TabIndex = 22;
            this.btn_open_profile.Text = "Visit Profile";
            this.btn_open_profile.UseVisualStyleBackColor = true;
            this.btn_open_profile.Click += new System.EventHandler(this.btn_open_profile_Click);
            // 
            // background_find_game_process
            // 
            this.background_find_game_process.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_find_game_process_DoWork);
            // 
            // lbl_pidtxt
            // 
            this.lbl_pidtxt.AutoSize = true;
            this.lbl_pidtxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pidtxt.Location = new System.Drawing.Point(12, 9);
            this.lbl_pidtxt.Name = "lbl_pidtxt";
            this.lbl_pidtxt.Size = new System.Drawing.Size(31, 13);
            this.lbl_pidtxt.TabIndex = 28;
            this.lbl_pidtxt.Text = "PID:";
            // 
            // lbl_statustxt
            // 
            this.lbl_statustxt.AutoSize = true;
            this.lbl_statustxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statustxt.Location = new System.Drawing.Point(12, 32);
            this.lbl_statustxt.Name = "lbl_statustxt";
            this.lbl_statustxt.Size = new System.Drawing.Size(49, 13);
            this.lbl_statustxt.TabIndex = 29;
            this.lbl_statustxt.Text = "Status:";
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pid.Location = new System.Drawing.Point(46, 9);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(13, 13);
            this.lbl_pid.TabIndex = 30;
            this.lbl_pid.Text = "0";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(58, 32);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(73, 13);
            this.lbl_status.TabIndex = 31;
            this.lbl_status.Text = "NOT RUNNING";
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(332, 12);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 23);
            this.btn_about.TabIndex = 32;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_info
            // 
            this.btn_info.Enabled = false;
            this.btn_info.Location = new System.Drawing.Point(332, 84);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(75, 23);
            this.btn_info.TabIndex = 33;
            this.btn_info.Text = "More Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_playernametxt
            // 
            this.lbl_playernametxt.AutoSize = true;
            this.lbl_playernametxt.Location = new System.Drawing.Point(10, 66);
            this.lbl_playernametxt.Name = "lbl_playernametxt";
            this.lbl_playernametxt.Size = new System.Drawing.Size(79, 13);
            this.lbl_playernametxt.TabIndex = 34;
            this.lbl_playernametxt.Text = "Player Name:";
            // 
            // txt_playername
            // 
            this.txt_playername.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txt_playername.Location = new System.Drawing.Point(95, 63);
            this.txt_playername.Name = "txt_playername";
            this.txt_playername.ReadOnly = true;
            this.txt_playername.Size = new System.Drawing.Size(144, 20);
            this.txt_playername.TabIndex = 35;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(332, 46);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 36;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 121);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.txt_playername);
            this.Controls.Add(this.lbl_playernametxt);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_pid);
            this.Controls.Add(this.lbl_statustxt);
            this.Controls.Add(this.lbl_pidtxt);
            this.Controls.Add(this.btn_open_profile);
            this.Controls.Add(this.lbl_steamid);
            this.Controls.Add(this.txt_steamid);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DBFZ 1.25 Profile Viewer v1.00";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_steamid;
        private System.Windows.Forms.Label lbl_steamid;
        private System.Windows.Forms.Button btn_open_profile;
        private System.ComponentModel.BackgroundWorker background_find_game_process;
        private System.Windows.Forms.Label lbl_pidtxt;
        private System.Windows.Forms.Label lbl_statustxt;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label lbl_playernametxt;
        private System.Windows.Forms.TextBox txt_playername;
        private System.Windows.Forms.Button btn_help;
    }
}

