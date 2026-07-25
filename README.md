# DestructionAPI

A lightweight C# destruction system designed for game engines.

DestructionAPI provides a simple framework for creating destructible objects,
applying damage, and managing destruction logic.

## Features

- Destructible objects
- Damage system
- Material support
- Fragment system
- Simple destruction engine
- Easy integration into game projects

## Project Structure

DestructionAPI/ │ ├── LICENSE ├── README.md │ ├── DestructionAPI/ │   ├── DestructionAPI.cs │   ├── DestructionEngine.cs │   ├── DestructibleObject.cs │   ├── Fragment.cs │   ├── Material.cs │   └── Vector3.cs │ └── Example/ └── Program.cs

## Usage

Create a destructible object:

```csharp
DestructibleObject wall =
    new DestructibleObject(
        "Concrete Wall",
        1000,
        Material.Concrete
    );

Create the destruction engine:

DestructionEngine engine =
    new DestructionEngine();

Apply damage:

engine.ApplyDamage(
    wall,
    500
);

Check destruction state:

if (wall.IsDestroyed())
{
    Console.WriteLine("Object destroyed");
}

Supported Materials

Wood

Glass

Concrete

Metal

Stone


Version

Current version:

0.1.0

License

This project is licensed under the MIT License.
