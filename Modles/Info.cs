namespace Center;

public sealed class Info
{
    private static Info instance = null;
    public string about { get; set; }
    private Info()
    { }

    public static Info Instance
    {
        get
        {
            if (instance is null)
                instance = new Info();

            return instance;
        }
    }
}