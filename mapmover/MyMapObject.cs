using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapmover
{
    public class MyMapObject
    {
        public int ObjectID { get; private set; }
        public float ObjectX { get; private set; }
        public float ObjectY { get; private set; }
        public float ObjectZ { get; private set; }
        public float ObjectRotX { get; private set; }
        public float ObjectRotY { get; private set; }
        public float ObjectRotZ { get; private set; }
        public int VirtualWorld { get; private set; }
        public int InteriorID { get; private set; }
        public float StreamDistance { get; private set; } = 100f;

        public MyMapObject(int id, float x, float y, float z, float rx, float ry, float rz)
        {
            this.ObjectID = id;
            this.ObjectX = x;
            this.ObjectY = y;
            this.ObjectZ = z;

            this.ObjectRotX = rx;
            this.ObjectRotY = ry;
            this.ObjectRotZ = rz;
        }

        public void Move(float x, float y, float z)
        {
            this.ObjectX += x;
            this.ObjectY += y;
            this.ObjectZ += z;
        }

        public void SetWorldData(int interior, int vw)
        {
            this.InteriorID = interior;
            this.VirtualWorld = vw;
        }

        public void SetStreamDist(float s)
        {
            this.StreamDistance = s;
        }
    }
}
