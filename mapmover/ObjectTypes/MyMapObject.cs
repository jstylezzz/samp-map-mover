namespace MapMover.ObjectTypes
{
	public class MyMapObject
    {
        public int ObjectID { get; protected set; }
        public double ObjectX { get; protected set; }
        public double ObjectY { get; protected set; }
        public double ObjectZ { get; protected set; }
        public double ObjectRotX { get; protected set; }
        public double ObjectRotY { get; protected set; }
        public double ObjectRotZ { get; protected set; }
		public double DrawDistance { get; protected set; } = 300f;

		protected void InitBase(int id, double x, double y, double z, double rx, double ry, double rz, double drawDist)
		{
			ObjectID = id;

			ObjectX = x;
			ObjectY = y;
			ObjectZ = z;

			ObjectRotX = rx;
			ObjectRotY = ry;
			ObjectRotZ = rz;

			DrawDistance = drawDist;
		}

		public void OverrideDrawDistance(float newDist)
		{
			DrawDistance = newDist;
		}

        public virtual void Move(double x, double y, double z)
        {
            ObjectX += x;
            ObjectY += y;
            ObjectZ += z;
        }
    }
}
