using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMover.ObjectTypes
{
	public class MyCreateObject : MyMapObject
	{
		public MyCreateObject(int id, double x, double y, double z, double rx, double ry, double rz, double drawDist)
		{
			InitBase(id, x, y, z, rx, ry, rz, drawDist);
		}

		public override string ToString()
		{
			return $"CreateObject({ObjectID}, {ObjectX}, {ObjectY}, {ObjectZ}, {ObjectRotX}, {ObjectRotY}, {ObjectRotZ}, {DrawDistance}););";
		}

		public static MyCreateObject Parse(string code)
		{
			code = code.Replace("CreateObject(", "").Replace(");", ""); //We strip the string to keep only the parameters.
			string[] pms = code.Split(',');
			try
			{
				return new MyCreateObject(int.Parse(pms[0]), double.Parse(pms[1]), double.Parse(pms[2]), double.Parse(pms[3]), double.Parse(pms[4]), double.Parse(pms[5]), double.Parse(pms[6]), double.Parse(pms[7]));
			}
			catch
			{
				return null;
			}
		}
	}
}
