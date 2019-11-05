# Read-only struct members

You could already mark a `struct` as `readonly` since C# 7.2

Take the following struct as example. We have marked it as `readonly` so that the compiler can make sure that its state is not modified after its creation.

```csharp
public readonly struct Point
{
    public Point(double x, double y) 
    {
        X = x;
        Y = y;
    }

    public double X { get; }

    public double Y { get; }
}
```

Now you can apply the `readonly` modifier to specific members of the struct that don't modify its state: the compiler will warn you if a member marked as `readonly` is accessing one not marked `readonly`.


In the following code snippet, try marking the `ToString` method as readonly and make sure no warning is issued by the compiler.

```cs --source-file ../Snippets/Program.cs --project ../Snippets/Snippets.csproj --region readonly-struct-members --session read-only-struct-members
```
You can use this snippet to execute your code.
```cs --source-file ../Snippets/Program.cs --project ../Snippets/Snippets.csproj --region readonly-struct-members-usage --session read-only-struct-members
``` 

Finally, try adding a method to the struct `Point` that accepts a `double` value and adds it to its current X property. Try marking the new method as `readonly`.