public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty in the constructor
        MyProperty = 0;
    }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        Console.WriteLine(MyProperty.ToString());
    }
}