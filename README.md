# Uninitialized Property Access in C# 

This repository demonstrates a common C# error: attempting to access a property that hasn't been initialized.  This often leads to a `NullReferenceException`.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a corrected version.

**Problem:** In the original code, `MyProperty` is accessed before being assigned a value. If `MyProperty` were a reference type (like a string or custom class), this would cause a `NullReferenceException`.

**Solution:** Initialize `MyProperty` either in the constructor or before accessing it.