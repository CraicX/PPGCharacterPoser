using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace JTPoseCore
{


	public class BrowsePose
	{
		public List<string> SelectedPoses = new List<string>();

		public List<PoseObject> PoseObjects = new List<PoseObject>();

		private string _filter = "";

		public PoseControl LastSelected;

		public FlowLayoutPanel Container;

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

		public void Delete()
		{
			foreach(PoseControl pcont in Container.Controls)
			{
				if ( pcont.Selected )
				{
					if ( File.Exists( pcont.ImagePath ) ) File.Delete(pcont.ImagePath);

					if ( File.Exists( pcont.DataPath ) ) File.Delete(pcont.DataPath);
				}
			}
			
			SelectedPoses.Clear();
			Refresh();
			Config.mainForm.lblSelected.Text = "";

		}

		public void Select( PoseControl pcontrol, bool fromLast=false )
		{
			Config.mainForm.RTB.Text = "";
			if ( fromLast && LastSelected != null && Container.Controls.Contains(LastSelected))
			{
				int flagCount = 0;

				foreach(PoseControl pcont in Container.Controls)
				{
					if (flagCount == 1) pcont.Selected = pcontrol.Selected;
					if (pcont == pcontrol) flagCount++;
					if (pcont == LastSelected) flagCount++;
					
					if (pcont.Selected)
					{
						if (!SelectedPoses.Contains(pcont.PoseName)) SelectedPoses.Add(pcont.PoseName);
					} 
					else
					{
						if (SelectedPoses.Contains(pcont.PoseName)) SelectedPoses.Remove(pcont.PoseName);
					}
					
				}
			} else
			{

				if (pcontrol.Selected)
				{
					if (!SelectedPoses.Contains(pcontrol.PoseName)) SelectedPoses.Add(pcontrol.PoseName);
				} 
				else
				{
					if (SelectedPoses.Contains(pcontrol.PoseName)) SelectedPoses.Remove(pcontrol.PoseName);
				}

			}

			LastSelected = pcontrol;
			

			if (SelectedPoses.Count > 0) {
				Config.mainForm.lblSelected.Text = SelectedPoses.Count + " selected";
				GenerateExport();
			}
			else Config.mainForm.lblSelected.Text = "";



		}

		public void GenerateExport()
		{

			StringBuilder SB = new StringBuilder();

			string tabs = new string('\t', 1);

			string openBracket  = "{";
			string closeBracket = "}";

			foreach( PoseObject pObj in PoseObjects )
			{
				if (pObj.PoseControl.Selected)
				{
					SB.AppendFormat("{0}{1} \"{2}\",\n", tabs, openBracket, pObj.PoseControl.PoseName );
					bool firstLimb = true;
					foreach ( string limb in Config.LimbNames )
					{
						float angle = Utilities.GetPropValue<float>( pObj.PoseClass, limb );

						if (angle == 0) continue;
					
						if ( firstLimb )
						{
							firstLimb = false;
							SB.AppendFormat("{0}  @\"{1}:{2}", tabs, limb, angle );
						}
						else
						{
							SB.AppendFormat(",\n{0}    {1}:{2}", tabs, limb, angle );
						}
					}

					SB.AppendFormat("\"\n{0}{1},\n\n", tabs, closeBracket );
				}
			}

			Config.mainForm.RTB.Text = SB.ToString();


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
					PoseObject pobj = new PoseObject
					{
						JsonDump = File.ReadAllText( FileName )
					};
					Console.OpenStandardOutput();

					Console.Out.WriteLine( pobj.JsonDump );
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
