using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace JTPoseDump
{
	public partial class Settings : Form
	{
		public static string GamePath = (string)Properties.Settings.Default["GamePath"];
		public static string LastPath = (string)Properties.Settings.Default["GamePath"];

		public Settings()
		{
			InitializeComponent();
		}

        private void Settings_Load( object sender, EventArgs e )
		{
			TBGamePath.Text = GamePath;

        }

		private void BtnBrowse_Click( object sender, EventArgs e )
		{
			DialogResult result = FolderBrowser.ShowDialog();

			if ( result == DialogResult.OK )
			{
				GamePath        = FolderBrowser.SelectedPath;
				TBGamePath.Text = GamePath;

				if (Directory.Exists(GamePath))
				{
					Config.GamePath = GamePath;
					if (!File.Exists(Path.Combine(Config.ModPath, "mod.json")))
					{
						BtnUninstall.Enabled = false;
						BtnInstall.Enabled   = true;
					}
					else
					{
						BtnUninstall.Enabled = true;
						BtnInstall.Enabled   = false;
					}
				}
			}

		}

		private void BtnSave_Click( object sender, EventArgs e )
		{
			Properties.Settings.Default["GamePath"] = GamePath;
			Properties.Settings.Default.Save(); 

			if (LastPath != GamePath)
			{
				Utilities.CreateFolders();
			}

			LastPath = GamePath;

			this.Close();
		}

		private void BtnInstall_Click( object sender, EventArgs e )
		{
			if (!File.Exists(Path.Combine(Config.ModPath, "mod.json")))
			{
				if ( Directory.Exists( Path.Combine( Config.ResourcesPath, "JTPoserMod" ) ) )
				{
					Utilities.CopyFilesRecursively(Path.Combine( Config.ResourcesPath, "JTPoserMod" ), Config.ModPath);
				}

				BtnUninstall.Enabled = true;
				BtnInstall.Enabled   = false;

			}
		}

		private void BtnUninstall_Click( object sender, EventArgs e )
		{
			string[] FileNames = { "mod.json", "PoseClass.cs", "PoseDump.cs", "thumb.png" };

			foreach( string fname in FileNames )
			{
				string path = Path.Combine( Config.ModPath, fname );
				if (File.Exists(path)) File.Delete(path);
			}

			BtnUninstall.Enabled = false;
			BtnInstall.Enabled   = true;
		}

		private void Settings_Activated( object sender, EventArgs e )
		{
			LastPath = (string)Properties.Settings.Default["GamePath"];
			
			if (Directory.Exists(Config.ModPath)) { 
				if (!File.Exists(Path.Combine(Config.ModPath, "mod.json")))
				{
					BtnUninstall.Enabled = false;
					BtnInstall.Enabled   = true;
				}
				else
				{
					BtnUninstall.Enabled = true;
					BtnInstall.Enabled   = false;
				}
			} else
			{
				BtnUninstall.Enabled = false;
				BtnInstall.Enabled   = false;
			}
		}
	}
}
