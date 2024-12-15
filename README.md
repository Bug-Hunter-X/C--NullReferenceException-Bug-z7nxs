This repository demonstrates a common C# bug: the NullReferenceException. The bug occurs when attempting to access a member of an object that has not been initialized.  The solution shows how to prevent this exception using null checks or initialization.

## Bug
The `bug.cs` file contains a class with a method that attempts to access an uninitialized property. This results in a `NullReferenceException`.

## Solution
The `bugSolution.cs` file provides a solution by checking for null before accessing the property or initializing the property in the constructor.