# IT80362 · Unit 01 — .NET Ecosystem & C# Fundamentals

> Your first console app, the .NET ecosystem, and the building blocks — for the absolute beginner.  
> **Duration:** 2 hours

## What this unit covers

- **The .NET ecosystem**
- **Your first console app**
- **Types, variables & operators**
- **Control flow & conventions**

## Getting started

1. Accept the assignment — `gh student accept` (Classroom 50) creates your personal copy of this repo.
2. Open `src/LibraryKiosk.csproj` in Rider, VS Code (C# Dev Kit), or Visual Studio.
3. Restore and build: `dotnet build` from the `src/` folder.
4. Open `src/Program.cs` and complete each `TODO` inside RunL1, RunL2, and RunCapstone.
5. Run a specific exercise with `dotnet run -- L1` (or `L2`, or `capstone`).

## Labs

### L1 — Your first console app

Starter file: `src/Program.cs`. Run with `dotnet run -- L1`.

1. Run the starter repo with dotnet run and confirm it builds.
2. Print a 3-line welcome banner for the Kigali Campus Library kiosk.
3. Read the user's name with Console.ReadLine() and print a personalized greeting.

### L2 — Types, variables & operators

Starter file: `src/Program.cs`. Run with `dotnet run -- L2`.

1. Declare a string title, an int pageCount, and a decimal price for one book.
2. Compute a 10%-off price using arithmetic operators.
3. Print title, pageCount, price, and the discounted price in one interpolated string.

## Capstone — Kigali Campus Library Kiosk — Day One

Starter files: `src/Program.cs`. Run with `dotnet run -- capstone`.

1. Declare loose variables for one Book: title, isbn, pages.
2. Declare loose variables for one Member: name, maxBooks, booksCheckedOut.
3. Write an if/else checkout decision based on booksCheckedOut vs. maxBooks.
4. Run the checkout decision four times in a row and confirm the limit is enforced.

## Definition of done

- [ ] .NET is the platform and runtime; C# is the language you write against it
- [ ] dotnet new / build / run are the three commands you'll type the most
- [ ] Top-level statements skip the class-and-Main boilerplate — the file is the entry point
- [ ] int, double/decimal, string, and bool are the types you'll reach for constantly
- [ ] var infers the type from the right-hand side — it's still strongly typed
- [ ] if/else picks a branch; for/while repeats work while a condition holds
- [ ] PascalCase for types and members, camelCase for locals and parameters
- [ ] Loose variables work, but nothing stops a mix-up the compiler can't catch — Unit 02 fixes that

## How to submit

```bash
git add .
git commit -m "Complete unit 01 tasks"
git push
```

Your push is your submission — the latest commit on the main branch is graded.
