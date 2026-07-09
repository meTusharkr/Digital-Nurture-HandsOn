# Exercise 2 - Factory Method Pattern

## Aim

Implement the Factory Method Design Pattern in C#.

## Objective

Demonstrate how the Factory Method Pattern creates objects through a factory instead of directly instantiating them.

## Description

The Factory Method Pattern defines an interface for creating objects while allowing subclasses to decide which concrete class to instantiate. This promotes loose coupling and makes the code easier to extend.

## Components

- Product Interface (`IDocument`)
- Concrete Products (`WordDocument`, `PdfDocument`, `ExcelDocument`)
- Abstract Factory (`DocumentFactory`)
- Concrete Factories (`WordFactory`, `PdfFactory`, `ExcelFactory`)
- Client (`Program`)

## Expected Output

```text
Opening Word Document...
Opening PDF Document...
Opening Excel Document...
```

## Conclusion

The Factory Method Pattern improves code flexibility by separating object creation from object usage, making the application easier to maintain and extend.
