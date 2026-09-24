// LibraryKiosk — Unit 01: .NET Ecosystem & C# Fundamentals
//
// No classes yet — Unit 02 introduces those. Everything below lives right
// in this file, using nothing but variables, operators, and control flow.

var mode = args.Length > 0 ? args[0].ToLowerInvariant() : "capstone";

switch (mode)
{
    case "l1":
        RunL1();
        break;
    case "l2":
        RunL2();
        break;
    case "capstone":
        RunCapstone();
        break;
    default:
        Console.WriteLine("Usage: dotnet run -- [L1|L2|capstone]");
        break;
}

void RunL1()
{
    Console.WriteLine("=== L1: Your First Console App ===");
    // TODO 1: Print a 3-line welcome banner for the Kigali Campus Library
    //   kiosk (anything you like, as long as it's 3 separate WriteLine ca
Console.WriteLine("hello");
Console.WriteLine("how are you my friend");
Console.WriteLine("I need your support to the previous module");
    // TODO 2: Console.Write a prompt for the user's name, then
    //   Console.ReadLine() it into a string variable.
Console.WriteLine("enter your name");
string userName = Console.ReadLine();
    // TODO 3: Print a personalized greeting using the name you just read.
    Console.WriteLine($"Hello, {userName} welcome Home");
 throw new NotImplementedException("L1: print a banner, read a name, then greet it.");
}

void RunL2()
{
    Console.WriteLine("=== L2: Types, Variables & Operators ===");
    // TODO 1: Declare three variables for one book: a string title, an
    //   int pageCount, and a decimal price.

string title = "C# Programming Guide";
int pageCount = 350;
decimal price = 29.99m;
    // TODO 2: Compute a 10%-off price from price and store it in a new
    //   decimal variable.
decimal discountedPrice = price * 0.90m;
    // TODO 3: Print title, pageCount, price, and the discounted price in
    //   ONE interpolated string.
    Console.WriteLine($"Book: {title} | Pages: {pageCount} | Original Price: ${price} | Discounted Price (10% off): ${discountedPrice:F2}");


    throw new NotImplementedException("L2: declare typed variables, compute a discount, print them together.");
}

void RunCapstone()
{
    Console.WriteLine("=== Capstone: Kigali Campus Library Kiosk — Day One ===");
    // TODO 1: Declare loose variables for one Book: title (string),
    //   isbn (string), pages (int)
    string title = "Introduction to Algorithms";
string isbn = "978-0262033848";
int pages = 1312;

    // TODO 2: Declare loose variables for one Member: name (string),
    //   maxBooks (int, e.g. 3), booksCheckedOut (int, starting at 0).
string name = "Denyse Uwase";
int maxBooks = 3;
int booksCheckedOut = 0;
    // TODO 3: Write an if/else: if booksCheckedOut < maxBooks, increment
    //   booksCheckedOut and print a checkout confirmation mentioning name
    //   and title; otherwise print that the limit has been reached.
if (booksCheckedOut < maxBooks)
{
    booksCheckedOut++;
    Console.WriteLine($"Checkout confirmed: {name} has successfully checked out '{title}'.");
}
else
{
    Console.WriteLine($"Limit reached: {name} cannot check out any more books (maximum limit is {maxBooks}).");
}
    // TODO 4: Call whatever you wrote for TODO 3 four times in a row (more
    //   than maxBooks) and confirm the limit message appears at least once.
    //   A for loop is the natural way to do this — see Part 04.
    for (int i = 0; i < 4; i++)
{
    if (booksCheckedOut < maxBooks)
    {
        booksCheckedOut++;
        Console.WriteLine($"Checkout confirmed: {name} has successfully checked out '{title}'.");
    }
    else
    {
        Console.WriteLine($"Limit reached: {name} cannot check out any more books (maximum limit is {maxBooks}).");
    }
}
 throw new NotImplementedException("Capstone: loose Book/Member variables, an if/else checkout decision, called four times.");
}
