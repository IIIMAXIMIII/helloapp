namespace HelloApp;

static class HelloApp
{
    static void Main()
    {
        Console.WriteLine("hello everyone");
        GreetBlack();
        GreetWhite();
    }
    public static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }
    public static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}