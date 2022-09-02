using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace JTPoseDump
{


	public class BrowsePose
	{
		public List<string> SelectedPoses = new List<string>();

		public List<PoseObject> PoseObjects = new List<PoseObject>();

		private string _filter = "";

		public PoseControl LastSelected;

		FlowLayoutPanel Container;

		public BrowsePose()
		{
			Container = Config.mainForm.FlowPoseSet;

		}

		public string Filter
		{
			get { return _filter; }

			set { 
				_filter = value; 
				Refresh();
			}
		}

		public void Clear()
		{
			for ( int i = PoseObjects.Count; --i >= 0; )
			{
				PoseObjects[i].PoseControl.Label.Dispose();
				PoseObjects[i].PoseControl.PicBox.Dispose();
				PoseObjects[i].PoseControl.Dispose();
				
				PoseObjects.RemoveAt(i);
			}
			
		}

		public void Select( PoseControl pcontrol )
		{
			LastSelected = pcontrol;

			if (pcontrol.Selected)
			{
				if (!SelectedPoses.Contains(pcontrol.PoseName)) SelectedPoses.Add(pcontrol.PoseName);
				else if (SelectedPoses.Contains(pcontrol.PoseName)) SelectedPoses.Remove(pcontrol.PoseName);
			}

			

			if (SelectedPoses.Count > 0) Config.mainForm.lblSelected.Text = SelectedPoses.Count + " selected";
			else Config.mainForm.lblSelected.Text = "";

		}

		public void Refresh()
		{
			int countFiltered = 0, countAll = 0;
			Container.Enabled = false;
			Container.Visible = false;
			
			if (Container.Controls.Count > 0) Clear();

			string[] FileNames = Directory.GetFiles(Config.DataPath);

			foreach ( string FileName in FileNames )
			{
				if( FileName.EndsWith("current.json") ) continue;

				countAll++;

				if( _filter != "" )
				{
					if (!Path.GetFileNameWithoutExtension(FileName).ToLower().Contains(_filter.ToLower()) ) continue;
					else countFiltered++;
				} 
				
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

						Container.Controls.Add(pobj.PoseControl);

						pobj.PoseControl.Label.BringToFront();
						pobj.PoseControl.PicBox.BringToFront();

						PoseObjects.Add(pobj);
					}
				}
			}

			
			Config.PIView = Config.PIView;

			if (countFiltered > 0) Config.mainForm.LblPoseCount.Text = "( " + countFiltered + " / " + countAll+ " )";
			else Config.mainForm.LblPoseCount.Text = "Poses: " + countAll;

			Container.Visible = true;
			Container.Enabled = true;
		}

		public void ResizeAll( int x )
		{
			Container.Enabled = false;
			Container.Visible = false;
			int y = x + 24;

			for ( int i = PoseObjects.Count; --i >= 0; ) { 

				PoseObjects[i].PoseControl.Size = new System.Drawing.Size(x,y);

				Utilities.ScaleFont(PoseObjects[i].PoseControl.Label);
			}

			Container.Visible = true;
			Container.Enabled = true;
		}
	}
}
