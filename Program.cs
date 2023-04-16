using BookApp5.App.Services.Implementations;

BookServices bookServices = new BookServices();

Console.WriteLine("0. Close App");
Console.WriteLine("1. Create Book");
Console.WriteLine("2. Show Books");

string request=Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            bookServices.Created();
            break;
        case "2":
            bookServices.Shows();
            break;
        default:
            Console.WriteLine("If you don't mind,please enter right away");
            break;
    }
    Console.WriteLine("0. Close App");
    Console.WriteLine("1. Create Book");
    Console.WriteLine("2. Show Books");

     request = Console.ReadLine();
}




