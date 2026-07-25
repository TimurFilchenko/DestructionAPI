namespace DestructionAPI
{
    public class DestructibleObject
    {
        public string Name { get; }

        public float Health { get; private set; }

        public Material Material { get; }


        public DestructibleObject(
            string name,
            float health,
            Material material
        )
        {
            Name = name;
            Health = health;
            Material = material;
        }


        public void ApplyDamage(
            float damage
        )
        {
            Health -= damage;


            if (Health < 0)
                Health = 0;
        }


        public void Repair(
            float amount
        )
        {
            Health += amount;
        }


        public bool IsDestroyed()
        {
            return Health <= 0;
        }
    }
}
