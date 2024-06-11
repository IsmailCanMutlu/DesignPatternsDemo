
# Composite Pattern

## Overview
The Composite pattern allows you to compose objects into tree structures to represent part-whole hierarchies. This pattern lets clients treat individual objects and compositions of objects uniformly.

## Structure
- **Component (Graphic):** Declares the interface for objects in the composition.
- **Leaf (Circle):** Represents leaf objects in the composition.
- **Composite (CompositeGraphic):** Represents a composite component (has children).

## Example
This example demonstrates drawing shapes (circles) using a composite structure.

## Code Explanation
- The `Graphic` class is the component interface.
- The `Circle` class is a leaf that implements `Graphic`.
- The `CompositeGraphic` class is a composite that implements `Graphic` and contains children.
- The `Program` class demonstrates the use of the composite pattern to draw shapes.

## Usage
```bash
dotnet run --project DesignPatternsDemo/Composite
