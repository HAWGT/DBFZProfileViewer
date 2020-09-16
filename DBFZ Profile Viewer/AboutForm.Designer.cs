namespace DBFZTrainer
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.rct_about = new System.Windows.Forms.RichTextBox();
            this.btn_steam = new System.Windows.Forms.Button();
            this.btn_github = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rct_about
            // 
            this.rct_about.Location = new System.Drawing.Point(12, 12);
            this.rct_about.Name = "rct_about";
            this.rct_about.ReadOnly = true;
            this.rct_about.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rct_about.Size = new System.Drawing.Size(302, 52);
            this.rct_about.TabIndex = 0;
            this.rct_about.Text = "Trainer version - v1.00\nGame version - 1.25\nCreated by HAWGT";
            // 
            // btn_steam
            // 
            this.btn_steam.Location = new System.Drawing.Point(12, 70);
            this.btn_steam.Name = "btn_steam";
            this.btn_steam.Size = new System.Drawing.Size(75, 23);
            this.btn_steam.TabIndex = 1;
            this.btn_steam.Text = "Steam";
            this.btn_steam.UseVisualStyleBackColor = true;
            this.btn_steam.Click += new System.EventHandler(this.btn_steam_Click);
            // 
            // btn_github
            // 
            this.btn_github.Location = new System.Drawing.Point(93, 70);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(75, 23);
            this.btn_github.TabIndex = 2;
            this.btn_github.Text = "Github";
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(239, 70);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 105);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_github);
            this.Controls.Add(this.btn_steam);
            this.Controls.Add(this.rct_about);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rct_about;
        private System.Windows.Forms.Button btn_steam;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.Button btn_ok;
    }
}