﻿// Instantiating a new instance of a class using target-typed new expression form C# 9 .NET 5
Car car1 = new();
// You can also instantiate this way, but unless you have a good reason to do so use target-typed new expression
// Car car1 = new Car();
// var car1 = new Car();

// You can instantiate many instances of a class
Car car2 = new();

// Instantiate another instance from the same class to futher illustrate the above point
Car car3 = new();

// Create an empty class with public access modifier, no modifiers and no class members
public class Car
{
    // Class body
}
