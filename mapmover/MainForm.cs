using MapMover.ObjectTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MapMover
{
	public partial class ConverterMainPage : Form
    {
		private float m_moveX;
		private float m_moveY;
		private float m_moveZ;
		private float m_drawDist;

		private int m_interior;
		private int m_virtualWorld;
		private float m_streamDist;

        public ConverterMainPage()
        {
            InitializeComponent();
        }

        private void ClearOriginalButtonClicked(object sender, EventArgs e)
        {
            m_originalMapBox.Clear();
        }

        private void ClearMovedButtonClicked(object sender, EventArgs e)
        {
            m_movedMapBox.Clear();
        }

        private void ClearBothClicked(object sender, EventArgs e)
        {
            m_movedMapBox.Clear();
            m_originalMapBox.Clear();
        }

		private bool ParseMoveData()
		{
			if(float.TryParse(m_moveXBox.Text, out m_moveX) && float.TryParse(m_moveYBox.Text, out m_moveY) && float.TryParse(m_moveZBox.Text, out m_moveZ) && float.TryParse(m_drawDistBox.Text, out m_drawDist))
			{
				return true;
			}
			else
			{
				MessageBox.Show("The general move parameters you entered are incorrect. Please enter floats for the move amounts and object draw distance.", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private bool ParseMoveDataDynamic()
		{
			if(int.TryParse(m_interiorIDBox.Text, out m_interior) && int.TryParse(m_vWorldBox.Text, out m_virtualWorld) && float.TryParse(m_streamDistBox.Text, out m_streamDist))
			{
				return true;
			}
			else
			{
				MessageBox.Show("The streamer move parameters you entered are incorrect. Please enter integers for interior ID and virtual world, and a float for the stream distance.", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private MyDynamicObject SetupAsDynamic(string code)
		{
			MyDynamicObject currentObject = MyDynamicObject.Parse(code);

			if(currentObject != null)
			{
				currentObject.SetStreamDist(m_streamDist);
				currentObject.SetWorldData(m_interior, m_virtualWorld);
			}

			return currentObject;
		}

        private void MoveMappingClicked(object sender, EventArgs e)
        {
			if(ParseMoveData() == false || ParseMoveDataDynamic() == false)
				return;

            string[] obs = m_originalMapBox.Text.Replace(" ", "").Split(';');
            List<MyMapObject> objects = new List<MyMapObject>();
			MyMapObject currentObject;
			string code;

			foreach (string s in obs)
            {
				currentObject = null;

				if(string.IsNullOrEmpty(s))
					continue;

				code = $"{s};"; //Let's add back the ; that we split these lines by, just for consistency when passing the code to other classes.

				if(s.Contains("VC2SAObject"))
				{
					currentObject = MyVC2SAObject.Parse(code);
				}
				else if(s.Contains("CreateDynamicObject"))
				{
					currentObject = SetupAsDynamic(code);
				}
				else if(s.Contains("CreateObject"))
				{
					if(m_convertToDynamic.Checked)
						currentObject = MyDynamicObject.Parse(code);
					else
						currentObject = MyCreateObject.Parse(code);
				}
				else
				{
					MessageBox.Show($"You entered a unsupported object input type. \"{s.Split('(')[0]}\" is not supported.\nYou can create an issue in this tool's GitHub repo: https://github.com/jstylezzz/samp-map-mover/issues", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if(currentObject == null)
				{
					MessageBox.Show($"You have supplied invalid arguments for an object of type \"{s.Split('(')[0]}\".\nPlease check your map codes and try again.", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//Perform move operations down here, since this is the same for all objects.
				currentObject.Move(m_moveX, m_moveY, m_moveZ);
				objects.Add(currentObject);
			}

            
            m_movedMapBox.Clear();
            StringBuilder sb = new StringBuilder();
            foreach(MyMapObject o in objects)
            {
				sb.Append($"{o.ToString()}\n");
            }
            m_movedMapBox.Text = sb.ToString();
            
            sb.Clear();
            sb = null;
        }

        private void CopyToClipboardClicked(object sender, EventArgs e)
        {
            Clipboard.SetText(m_movedMapBox.Text);
        }
    }
}
