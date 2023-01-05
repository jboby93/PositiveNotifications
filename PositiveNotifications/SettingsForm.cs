using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositiveNotifications {
	public partial class SettingsForm : Form {

		private bool actuallyClosing = false;
		private bool firstRun = false;

		public SettingsForm() {
			InitializeComponent();

			if(!Configuration.getInstance().Unsaved) {
				// app loaded a valid configuration and is starting without the main window shown
				// in this case, show a notification

				notifyIcon1.ShowBalloonTip(5000, "PositiveNotifications", "The program is now running ☺ Right-click the icon to change settings or exit.", ToolTipIcon.Info);
			} else {
				firstRun = true;
			}

			// populate fields with data from configuration
			var config = Configuration.getInstance().settings;

			txtStatements.Text = string.Join(Environment.NewLine, config.Statements);
			nudMinutes.Value = config.MinutesInterval;
			chkForceReading.Checked = config.ForceAcknowledgement;
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
			Show();
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
			if(!actuallyClosing) {
				e.Cancel = true;
				cancelButton_Click(sender, EventArgs.Empty);
			}
		}

		private void saveButton_Click(object sender, EventArgs e) {

		}

		private void cancelButton_Click(object sender, EventArgs e) {
			if(firstRun) {
				if(MessageBox.Show("You have not yet saved a configuration - the program will exit.  Are you sure?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					actuallyClosing = true;
					Close();
				}
			} else {
				Hide();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			actuallyClosing = true;
			Close();
		}

		private void previewButton_Click(object sender, EventArgs e) {
			if(chkForceReading.Checked) {
				// ...
			} else {
				DoNormalPopup();
			}
		}

		private void timer1_Tick(object sender, EventArgs e) {
			// do time check....

			//if(chkForceReading.Checked) {
			//
			//} else {
			//	
			//}
		}

		private void DoNormalPopup() {
			var config = Configuration.getInstance().settings;
			var i = (new Random()).Next(config.Statements.Count);
			var message = config.Statements[i];

			notifyIcon1.ShowBalloonTip(8000, "A message for you 🥰", "Repeat after me: " + message, ToolTipIcon.Info);
		}
	}
}
