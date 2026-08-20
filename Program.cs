string Describe(object ob)
{
    return ob switch
    {
        int => "Integer",
        string => "String",
        bool => "Boolean",
        null => "Null",
        _ => "Other"
    };
}

Console.WriteLine(Describe(new List<int>() { 1, 2}));