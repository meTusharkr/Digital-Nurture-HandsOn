# Exercise 2 - Factory Method Pattern

## Aim

Implement the Factory Method Design Pattern in C#.

## Description

The Factory Method Pattern provides an interface for creating objects while allowing subclasses to decide which class to instantiate.

## Components

- Product Interface (`IDocument`)
- Concrete Products (`WordDocument`, `PdfDocument`, `ExcelDocument`)
- Abstract Factory (`DocumentFactory`)
- Concrete Factories (`WordFactory`, `PdfFactory`, `ExcelFactory`)

## Output

```
Opening Word Document...
Opening PDF Document...
Opening Excel Document...
```
