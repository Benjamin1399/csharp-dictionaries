

Dictionary<string, string> employees = new Dictionary<string, string>();
string? code = null;
string? name = null;

do
{
    Console.Write("Enter employee code (type exit to stop): ");
    code = Console.ReadLine();

    if (!String.IsNullOrEmpty(code) && code.ToLower() != "exit")
    {
        Console.Write("Enter employee name: ");
        name = Console.ReadLine();

        if (name.ToLower() == "exit")
        {
            Console.WriteLine("Complete entry before exiting");
        }
        else
        {
            employees.Add(code, name);
            Console.WriteLine($"Employee {name} added with code {code}");
        }
    }
}
while (code.ToLower() != "exit");

Console.Write("Enter employee code to retrieve: ");
code =  Console.ReadLine();

if (employees.TryGetValue(code, out name))
{
    Console.WriteLine($"Retrieved employee {name}");
}
else
{
    Console.WriteLine("Employee code entered is invalid");
}
