
# Bridge Pattern

## Overview
The Bridge pattern decouples an abstraction from its implementation, allowing them to vary independently. This pattern is used when you want to avoid a permanent binding between an abstraction and its implementation.

## Structure
- **Abstraction (RemoteControl):** Defines the abstract interface and maintains a reference to an object of type Implementor.
- **Refined Abstraction (AdvancedRemoteControl):** Extends the interface defined by Abstraction.
- **Implementor (IDevice):** Defines the interface for implementation classes.
- **Concrete Implementor (TV, Radio):** Implements the Implementor interface and defines its concrete implementation.

## Example
This example demonstrates controlling different devices (TV, Radio) with a remote control using the Bridge pattern.

## Code Explanation
- The `RemoteControl` class is the abstraction that defines the interface for controlling a device.
- The `AdvancedRemoteControl` class extends `RemoteControl` with additional functionality.
- The `IDevice` interface defines the methods for the devices.
- The `TV` and `Radio` classes implement the `IDevice` interface.
- The `Program` class demonstrates the use of the bridge to control different devices.

## Usage
```bash
dotnet run --project DesignPatternsDemo/Bridge
