# DestructionAPI

DestructionAPI is a lightweight C# library for creating and managing destructible objects in game projects.

The goal of this project is to provide a simple and extendable destruction system that can be integrated into game engines and custom frameworks.

## Features

- Destructible object system
- Damage handling
- Object health management
- Material-based destruction
- Fragment support
- Simple destruction engine architecture

## Example

```csharp
using DestructionAPI;

DestructibleObject wall =
    new DestructibleObject(
        "Concrete Wall",
        1000,
        Material.Concrete
    );

DestructionEngine engine =
    new DestructionEngine();

engine.ApplyDamage(
    wall,
    500
);

Output:

Object Concrete Wall damaged

Materials

Supported materials:

Wood

Glass

Concrete

Metal

Stone


Version

0.1.0

License

MIT License
