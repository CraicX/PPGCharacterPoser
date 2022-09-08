using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Linq;

namespace JTPoseCore

{
	public partial class Settings : Form
	{
		static string GamePath   = "";

		public Settings()
		{
			InitializeComponent();
		}

        private void Settings_Load( object sender, EventArgs e )
		{
			GamePath      = ConfigurationManager.AppSettings.Get("GamePath");

			Console.WriteLine(GamePath);

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
					Config.ModPath  = Path.Combine(Config.GamePath, "mod", "JTPoserMod" );

					if( !Directory.Exists(Config.ModPath) ) Directory.CreateDirectory( Config.ModPath );

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
			Config.GamePath = TBGamePath.Text;
			Config.ModPath  = Path.Combine(Config.GamePath, "mods", "JTPoserMod");
			Utilities.AddUpdateAppSettings("GamePath", Config.GamePath);

			Utilities.AddUpdateAppSettings("Width", Config.mainForm.Width.ToString());
			Utilities.AddUpdateAppSettings("Height", Config.mainForm.Height.ToString());
			Utilities.AddUpdateAppSettings("X", Config.mainForm.Location.X.ToString());
			Utilities.AddUpdateAppSettings("Y", Config.mainForm.Location.Y.ToString());

			Utilities.CreateFolders();

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

			if (Directory.Exists(Config.ModPath) && !Directory.EnumerateFileSystemEntries(Config.ModPath).Any()) Directory.Delete(Config.ModPath);

			BtnUninstall.Enabled = false;
			BtnInstall.Enabled   = true;
		}

		private void Settings_Activated( object sender, EventArgs e )
		{
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
