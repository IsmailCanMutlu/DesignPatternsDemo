# Visitor Pattern

## Overview
The Visitor pattern allows you to add further operations to objects without having to modify them. This pattern is used when you need to perform an operation on a group of similar kinds of objects.

## Structure
- **Visitor (IVisitor):** Declares a Visit operation for each class of ConcreteElement in the object structure.
- **Concrete Visitor (ConcreteVisitor):** Implements each operation declared by Visitor.
- **Element (IElement):** Defines an Accept operation that takes a visitor as an argument.
- **Concrete Element (ElementA, ElementB):** Implements an Accept operation that takes a visitor as an argument.
- **Object Structure (ObjectStructure):** Can enumerate its elements and provide a high-level interface to allow the visitor to visit its elements.

## Example
This example demonstrates visiting different elements (ElementA, ElementB) with a visitor using the Visitor pattern.

## Code Explanation
- The `IVisitor` interface defines the visit operations.
- The `ConcreteVisitor` class implements the `IVisitor` interface.
- The `IElement` interface defines the accept operation.
- The `ElementA` and `ElementB` classes implement the `IElement` interface.
- The `ObjectStructure` class maintains a collection of elements.
- The `Program` class demonstrates the use of the visitor pattern to visit elements.

## Usage
```bash
dotnet run --project DesignPatternsDemo/Visitor
