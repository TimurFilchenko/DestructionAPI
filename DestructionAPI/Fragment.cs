namespace DestructionAPI
{
    public class Fragment
    {
        public string Name { get; }

        public float Mass { get; private set; }

        public Vector3 Position { get; private set; }


        public Fragment(
            string name,
            float mass,
            Vector3 position
        )
        {
            Name = name;
            Mass = mass;
            Position = position;
        }


        public void Move(
            Vector3 direction
        )
        {
            Position = direction;
        }


        public void SetMass(
            float mass
        )
        {
            if (mass < 0)
                mass = 0;


            Mass = mass;
        }
    }
}
