public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize to a default value
    }

    public void MyMethod()
    {
        // Accessing the initialized property
        int value = MyProperty;
    }
}