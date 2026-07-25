namespace DestructionAPI
{
    public class Vector3
    {
        public float X { get; private set; }

        public float Y { get; private set; }

        public float Z { get; private set; }


        public Vector3(
            float x,
            float y,
            float z
        )
        {
            X = x;
            Y = y;
            Z = z;
        }


        public void Set(
            float x,
            float y,
            float z
        )
        {
            X = x;
            Y = y;
            Z = z;
        }


        public static Vector3 Zero()
        {
            return new Vector3(
                0,
                0,
                0
            );
        }


        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
