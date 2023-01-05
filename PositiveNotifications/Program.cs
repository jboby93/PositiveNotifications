using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositiveNotifications {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var MainForm = new SettingsForm();
			var config = Configuration.getInstance();

			if(config.Unsaved) {
				// app has never been run, or no config file exists
				// need to show the window
				Application.Run(MainForm);
			} else {
				Application.Run();
			}
			
			
		}
	}
}
