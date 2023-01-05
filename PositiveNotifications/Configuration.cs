using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PositiveNotifications {
	public class Configuration {
		private readonly string SettingsFile;
		public Settings settings;
		private static Configuration _instance;

		public bool Unsaved { get; private set; }
		public void MarkUnsaved() { Unsaved = true; }

		private Configuration() {
			var AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			SettingsFile = Path.Combine(AppPath, "settings.json");
			Load();
		}

		public static Configuration getInstance() {
			if(_instance is null) {
				_instance = new Configuration();
			}

			return _instance;
		}

		private void Load() {
			try {
				string json = File.ReadAllText(SettingsFile);
				settings = JsonConvert.DeserializeObject<Settings>(json);
				if(settings == null) {
					throw new FileNotFoundException();
				}
				if(settings.Statements == null) {
					settings.Statements = new List<string> {
						"I am worthy of love.",
						"I am strong.",
						"I am capable.",
						"I deserve the best.",
						"I am worthy of abundence.",
						"I am creative.",
						"I am loved.",
						"I am valid in all of my emotions.",
						"I am caring and kind."
					};

					Unsaved = true;
				}
			} catch(FileNotFoundException ex) {
				settings = new Settings {
					Statements = new List<string> {
						"I am worthy of love.",
						"I am strong.",
						"I am capable.",
						"I deserve the best.",
						"I am worthy of abundence.",
						"I am creative.",
						"I am loved.",
						"I am valid in all of my emotions.",
						"I am caring and kind."
					},
					MinutesInterval = 30,
					ForceAcknowledgement = false
				};

				Unsaved = true;
			}
		}

		public void Save() {
			string json = JsonConvert.SerializeObject(settings);
			File.WriteAllText(SettingsFile, json);
		}

		public class Settings {
			public List<string> Statements { get; set; }
			public int MinutesInterval { get; set; }
			public bool ForceAcknowledgement { get; set; }
		}
	}
}
