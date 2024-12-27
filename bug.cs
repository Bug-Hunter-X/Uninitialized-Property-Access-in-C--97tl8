public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing MyProperty before it's initialized
        Console.WriteLine(MyProperty); // This will print 0 because it has a default value.
    }
}