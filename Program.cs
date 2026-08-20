// Summary : Some use cases of using pattern matching : 

// 1) Type pattern in switch : 
using Pattern_matching_use_cases;

string Describe(object ob)
{
    return ob switch
    {
        int => "Integer",
        string => "String",
        bool => "Boolean",
        null => "Null",
        _ => "Other" // We use discart key to define default value
    };
}

Console.WriteLine(Describe(new List<int>() { 1, 2}));



// 2) Relational + Logical Patterns :
string GetAgeCategory(int age)
{
    return age switch
    {
        < 0 => "invalid",
        0 and <= 12 => "Child",
        13 and <= 17 => "Teenager",
        18 and <= 64 => "Adult",
        _ => "Senior",
    };
}

Console.WriteLine(GetAgeCategory(20));


// 3) Property Pattern : 
bool CanAccessAdminPanel(User user)
{
    return user is { Role: "Admin", IsActive: true };
}

User user = new() { Role = "Developper", IsActive = true};
Console.WriteLine(CanAccessAdminPanel(user));



// 4) Business Logic use case :

string GetOrderState(Order order)
{
    return order switch
    {
        { Status: "PAID", Total: > 0, PaymentValid: true } => "Ready",
        { Status: "PAID" } => "Paid",
        { Status: "PENDING" } => "Waiting",
        { Status: "CANCELLED" } => "Cancelled",
        _ => "Unknown"
    };
}

Order order = new()
{
    Status = "PAID",
    Total = 123,
    PaymentValid = true
};

Console.WriteLine(GetOrderState(order));



// 5) 

string Analyze(object value)
{
    return value switch
    {
        int num when num > 0 => "Positive integer",
        int num when num <= 0 => "Negative integer",
        string word when word.Length == 0 => "Empty string",
        string word when word.Length > 0 => "Text",
        null => "Null",
        _ => "Unknow"
    };
}

Console.WriteLine(Analyze("mohammed"));