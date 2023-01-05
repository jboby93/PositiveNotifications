namespace PositiveNotifications {
	partial class SettingsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtStatements = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudMinutes = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.previewButton = new System.Windows.Forms.Button();
			this.chkForceReading = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.aboutButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.trayMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon1.BalloonTipTitle = "PositiveNotifications";
			this.notifyIcon1.ContextMenuStrip = this.trayMenu;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "PositiveNotifications";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// trayMenu
			// 
			this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.trayMenu.Name = "trayMenu";
			this.trayMenu.Size = new System.Drawing.Size(121, 54);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// txtStatements
			// 
			this.txtStatements.Location = new System.Drawing.Point(12, 25);
			this.txtStatements.Multiline = true;
			this.txtStatements.Name = "txtStatements";
			this.txtStatements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtStatements.Size = new System.Drawing.Size(403, 189);
			this.txtStatements.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(406, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter some positive affirmations or thoughts you want to be reminded of (one per " +
    "line)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Show me a notification every";
			// 
			// nudMinutes
			// 
			this.nudMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudMinutes.Location = new System.Drawing.Point(158, 232);
			this.nudMinutes.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudMinutes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudMinutes.Name = "nudMinutes";
			this.nudMinutes.Size = new System.Drawing.Size(61, 20);
			this.nudMinutes.TabIndex = 5;
			this.nudMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(225, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "minutes";
			// 
			// previewButton
			// 
			this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.previewButton.Location = new System.Drawing.Point(178, 372);
			this.previewButton.Name = "previewButton";
			this.previewButton.Size = new System.Drawing.Size(75, 23);
			this.previewButton.TabIndex = 7;
			this.previewButton.Text = "Preview";
			this.previewButton.UseVisualStyleBackColor = true;
			this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
			// 
			// chkForceReading
			// 
			this.chkForceReading.AutoSize = true;
			this.chkForceReading.Enabled = false;
			this.chkForceReading.Location = new System.Drawing.Point(12, 267);
			this.chkForceReading.Name = "chkForceReading";
			this.chkForceReading.Size = new System.Drawing.Size(304, 17);
			this.chkForceReading.TabIndex = 8;
			this.chkForceReading.Text = "Force me to read it and type it out to dismiss the notification";
			this.chkForceReading.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(33, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(382, 59);
			this.label4.TabIndex = 9;
			this.label4.Text = "Note: this setting makes it a full-screen notification that can not be dismissed " +
    "without typing out the statement it gives you.\r\n\r\nWrite your affirmations in the" +
    " first-person for the best effect.";
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(259, 372);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(340, 372);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 11;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.aboutButton.Location = new System.Drawing.Point(12, 372);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(75, 23);
			this.aboutButton.TabIndex = 12;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 407);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chkForceReading);
			this.Controls.Add(this.previewButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudMinutes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtStatements);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings - PositiveNotifications";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.trayMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip trayMenu;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox txtStatements;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudMinutes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button previewButton;
		private System.Windows.Forms.CheckBox chkForceReading;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Timer timer1;
	}
}

