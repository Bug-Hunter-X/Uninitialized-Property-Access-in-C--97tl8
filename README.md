# Uninitialized Property Access in C#

This repository demonstrates a potential issue in C#: accessing a class property before it's explicitly assigned a value within a method. While C# provides default values, this can lead to unexpected behavior or subtle bugs. The `bug.cs` file shows the problem, and `bugSolution.cs` offers a corrected version.

## Problem

In the `bug.cs` example, `MyProperty` is accessed in `MyMethod` before being assigned.  This may lead to relying on default values, which isn't always desirable.

## Solution

The `bugSolution.cs` file illustrates a solution: explicitly initializing `MyProperty` before it's used, or assigning it a value within the method itself.