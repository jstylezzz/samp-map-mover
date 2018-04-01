namespace MapMover
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
            ObjectID = id;
            ObjectX = x;
            ObjectY = y;
            ObjectZ = z;

            ObjectRotX = rx;
            ObjectRotY = ry;
            ObjectRotZ = rz;
        }

        public void Move(float x, float y, float z)
        {
            ObjectX += x;
            ObjectY += y;
            ObjectZ += z;
        }

        public void SetWorldData(int interior, int vw)
        {
            InteriorID = interior;
            VirtualWorld = vw;
        }

        public void SetStreamDist(float s)
        {
            StreamDistance = s;
        }
    }
}
