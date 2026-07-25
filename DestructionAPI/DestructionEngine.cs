using System;


namespace DestructionAPI
{
    public class DestructionEngine
    {
        public void ApplyDamage(
            DestructibleObject obj,
            float damage
        )
        {
            if (obj == null)
                return;


            obj.ApplyDamage(damage);


            if (obj.IsDestroyed())
            {
                Console.WriteLine(
                    $"Object {obj.Name} destroyed"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Object {obj.Name} damaged"
                );
            }
        }


        public void Destroy(
            DestructibleObject obj
        )
        {
            if (obj == null)
                return;


            obj.ApplyDamage(
                obj.Health
            );


            Console.WriteLine(
                $"Object {obj.Name} destroyed"
            );
        }
    }
}
