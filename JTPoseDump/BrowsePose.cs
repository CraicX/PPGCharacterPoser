using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JTPoseDump
{


	public class BrowsePose
	{
		public List<PoseObject> PoseObjects = new List<PoseObject>();

		private string _filter = "";

		public string Filter
		{
			get { return _filter; }

			set { 
				_filter = value; 
				RefreshPoses();
			}
		}

		public void ClearPoses()
		{
			for ( int i = PoseObjects.Count; --i >= 0; )
			{
				PoseObjects[i].PoseControl.Label.Dispose();
				PoseObjects[i].PoseControl.PicBox.Dispose();
				PoseObjects[i].PoseControl.Dispose();
				
				PoseObjects.RemoveAt(i);
			}
			
		}

		public void RefreshPoses()
		{
			if (Config.mainForm.FlowPoseSet.Controls.Count > 0) ClearPoses();

			string[] FileNames = Directory.GetFiles(Config.DataPath);

			foreach ( string FileName in FileNames )
			{
				if( FileName.EndsWith("current.json") ) continue;

				if( _filter != "" && !Path.GetFileNameWithoutExtension(FileName).ToLower().Contains(_filter.ToLower()) ) continue;
				
				if( FileName.EndsWith("json"))
				{
					PoseObject pobj = new PoseObject();
					
					pobj.JsonDump   = File.ReadAllText(FileName);
					pobj.PoseClass  = JsonSerializer.Deserialize<PoseClass>(pobj.JsonDump);
					pobj.PoseName   = pobj.PoseClass.Name;
					pobj.ImagePath  = Path.Combine(Config.ImagePath, pobj.PoseName + ".png");
					pobj.DataPath   = Path.Combine(Config.DataPath,  pobj.PoseName + ".json");

					if( File.Exists( pobj.DataPath ) )
					{
						pobj.PoseControl = new PoseControl(pobj);

						Config.mainForm.FlowPoseSet.Controls.Add(pobj.PoseControl);

						pobj.PoseControl.Label.BringToFront();
						pobj.PoseControl.PicBox.BringToFront();

						PoseObjects.Add(pobj);
					}
				}
			}

			Config.PIView = Config.PIView;
		}

		public void ResizeAll( int x )
		{
			int y = x + 24;

			for ( int i = PoseObjects.Count; --i >= 0; ) { 

				PoseObjects[i].PoseControl.Size = new System.Drawing.Size(x,y);

				Utilities.ScaleFont(PoseObjects[i].PoseControl.Label);
			}


		}
	}
}
