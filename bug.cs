public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that has not been initialized
        int value = MyProperty; // This line might throw a NullReferenceException if MyProperty is a reference type
    }
}