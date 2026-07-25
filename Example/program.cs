using System;

using DestructionAPI;


namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DestructionAPI api = new DestructionAPI();


            Console.WriteLine(
                api.GetInfo()
            );


            DestructibleObject wall =
                new DestructibleObject(
                    "Concrete Wall",
                    1000,
                    Material.Concrete
                );


            DestructionEngine engine =
                new DestructionEngine();


            Console.WriteLine(
                $"Object: {wall.Name}"
            );


            Console.WriteLine(
                $"Health: {wall.Health}"
            );


            engine.ApplyDamage(
                wall,
                300
            );


            engine.ApplyDamage(
                wall,
                800
            );


            Console.WriteLine(
                $"Destroyed: {wall.IsDestroyed()}"
            );
        }
    }
}
