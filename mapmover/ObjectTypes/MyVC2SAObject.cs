using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMover.ObjectTypes
{
	public class MyVC2SAObject : MyMapObject
	{
		public int HadFarawayModel { get; private set; }

		public MyVC2SAObject(int id, double x, double y, double z, double rx, double ry, double rz, double distance, int hadFarawayModel)
		{
			InitBase(id, x, y, z, rx, ry, rz, distance);
			HadFarawayModel = hadFarawayModel;
		}

		public override string ToString()
		{
			return $"CreateVC2SAObject({ObjectID}, {ObjectX}, {ObjectY}, {ObjectZ}, {ObjectRotX}, {ObjectRotY}, {ObjectRotZ}, {DrawDistance}, {HadFarawayModel});";
		}

		public static MyVC2SAObject Parse(string code)
		{
			code = code.Replace("CreateVC2SAObject(", "").Replace(");", ""); //We strip the string to keep only the parameters.
			string[] pms = code.Split(',');
			try
			{
				return new MyVC2SAObject(Int32.Parse(pms[0]), double.Parse(pms[1]), double.Parse(pms[2]), double.Parse(pms[3]), double.Parse(pms[4]), double.Parse(pms[5]), double.Parse(pms[6]), double.Parse(pms[7]), Int32.Parse(pms[8]));
			}
			catch
			{
				return null;
			}
		}
	}
}
