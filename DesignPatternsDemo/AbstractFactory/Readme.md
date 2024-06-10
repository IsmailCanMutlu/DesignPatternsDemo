# Abstract Factory Pattern

## Overview
The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is used when a system should be independent of how its products are created, composed, and represented.

## Structure
- **Abstract Product (IButton, ICheckbox):** Declares an interface for a type of product object.
- **Concrete Product (WinButton, WinCheckbox, MacButton, MacCheckbox):** Implements the abstract product interface.
- **Abstract Factory (IGUIFactory):** Declares an interface for operations that create abstract product objects.
- **Concrete Factory (WinFactory, MacFactory):** Implements the operations to create concrete product objects.

## Example
This example demonstrates creating UI elements (buttons and checkboxes) for different operating systems (Windows and Mac) using the Abstract Factory pattern.

## Code Explanation
- The `IButton` and `ICheckbox` interfaces define the abstract products.
- The `WinButton`, `WinCheckbox`, `MacButton`, and `MacCheckbox` classes implement these interfaces for Windows and Mac styles.
- The `IGUIFactory` interface declares methods for creating abstract products.
- The `WinFactory` and `MacFactory` classes implement these methods to create concrete products for Windows and Mac, respectively.
- The `Application` class demonstrates the use of factories to create UI elements.

## Usage
```bash
dotnet run --project DesignPatternsDemo/AbstractFactory
