using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMover.ObjectTypes
{
	public class MyDynamicObject : MyMapObject
	{
		public int VirtualWorld { get; private set; }
		public int InteriorID { get; private set; }
		public double StreamDistance { get; private set; } = 300f;

		public MyDynamicObject(int id, double x, double y, double z, double rx, double ry, double rz, int vworld, int interior, double streamDist, double drawDist)
		{
			InitBase(id, x, y, z, rx, ry, rz, drawDist);
			InteriorID = interior;
			VirtualWorld = vworld;
			StreamDistance = streamDist;
		}

		public virtual void SetWorldData(int interior, int vw)
		{
			InteriorID = interior;
			VirtualWorld = vw;
		}

		public virtual void OverrideStreamDistance(double s)
		{
			StreamDistance = s;
		}

		public override string ToString()
		{
			return $"CreateDynamicObject({ObjectID}, {ObjectX}, {ObjectY}, {ObjectZ}, {ObjectRotX}, {ObjectRotY}, {ObjectRotZ}, {VirtualWorld}, {InteriorID}, -1, {StreamDistance}, {DrawDistance}, -1, 0);";
		}

		public static MyDynamicObject Parse(string code)
		{
			code = code.Replace("CreateDynamicObject(", "").Replace(");", ""); //We strip the string to keep only the parameters.
			string[] pms = code.Split(',');
			try
			{
				return new MyDynamicObject(int.Parse(pms[0]), double.Parse(pms[1]), double.Parse(pms[2]), double.Parse(pms[3]), double.Parse(pms[4]), double.Parse(pms[5]), double.Parse(pms[6]), int.Parse(pms[7]), int.Parse(pms[8]), double.Parse(pms[9]), double.Parse(pms[10]));
			}
			catch
			{
				return null;
			}
		}
	}
}
