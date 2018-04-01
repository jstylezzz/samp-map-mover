using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MapMover
{
	public partial class ConverterMainPage : Form
    {
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

        private void MoveMappingClicked(object sender, EventArgs e)
        {
            string[] obs = m_originalMapBox.Text.Split(';');
            List<MyMapObject> objects = new List<MyMapObject>();
            bool errored = false;
            foreach (string s in obs)
            {
                string ns = s.Replace(",", " , ");
                string[] prms = ns.Split(',');

                if (prms.Length > 1)
                {
                    //Remove CreateObject( from the string
                    prms[0] = prms[0].Replace('(', ' ');
                    prms[0] = prms[0].Remove(0, prms[0].IndexOf(" "));

                    //Remove ) from the string
                    prms[6] = prms[6].Replace(")", "");

                    int id, interior, vworld;
                    float x, y, z, rx, ry, rz, stream;
                    float mx, my, mz;

                    if (float.TryParse(m_moveXBox.Text, out mx) && float.TryParse(m_moveYBox.Text, out my) && float.TryParse(m_moveZBox.Text, out mz) && float.TryParse(m_streamDistBox.Text, out stream))
                    {
                        if (Int32.TryParse(m_interiorIDBox.Text, out interior) && Int32.TryParse(m_vWorldBox.Text, out vworld))
                        {
                            if (Int32.TryParse(prms[0], out id) && float.TryParse(prms[1], out x) && float.TryParse(prms[2], out y) && float.TryParse(prms[3], out z) && float.TryParse(prms[4], out rx) && float.TryParse(prms[5], out ry) && float.TryParse(prms[6], out rz))
                            {
                                MyMapObject o = new MyMapObject(id, x, y, z, rx, ry, rz);
                                o.Move(mx, my, mz);
                                o.SetWorldData(interior, vworld);
                                o.SetStreamDist(stream);
                                objects.Add(o);
                            }
                            else
                            {
                                errored = true;
                                MessageBox.Show("The map code you entered could not be parsed. Please make sure to enter only CreateObject code, and that it is complete (from the function name to the ; at the end).", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        else
                        {
                            errored = true;
                            MessageBox.Show("The move parameters you entered are incorrect. Please enter only integers for the interior ID and virtual world.", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        errored = true;
                        MessageBox.Show("The move parameters you entered are incorrect. Please enter floats for the move amounts and stream distance.", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }

            if (errored == false)
            {
                m_movedMapBox.Clear();
                StringBuilder sb = new StringBuilder();
                foreach(MyMapObject o in objects)
                {
                    //CreateDynamicObject(modelid, Float:x, Float:y, Float:z, Float:rx, Float:ry, Float:rz, worldid = -1, interiorid = -1, playerid = -1, Float:streamdistance = 300.0);
                    sb.Append("CreateDynamicObject(" + o.ObjectID + ", " + o.ObjectX + ", " + o.ObjectY + ", " + o.ObjectZ + ", " + o.ObjectRotX + ", " + o.ObjectRotY + ", " + o.ObjectRotZ + ", " + o.VirtualWorld + ", " + o.InteriorID + ", -1, " + o.StreamDistance + ");\n");
                }
                m_movedMapBox.Text = sb.ToString();
                Clipboard.SetText(sb.ToString());
                sb.Clear();
                sb = null;
            }

        }

        private void CopyToClipboardClicked(object sender, EventArgs e)
        {
            Clipboard.SetText(m_movedMapBox.Text);
        }
    }
}
