using Spectre.Console;

AnsiConsole.Clear();

// Lesson 02 Initial Setup
// AnsiConsole.MarkupLine("[red bold]Hello World[/]");
// AnsiConsole.MarkupLine("Hello World");
// AnsiConsole.MarkupLine("[slowblink]Hello World[/]");

//Lesson 03 - Colors and Styles
// AnsiConsole.MarkupLine("[red on white bold]This is the inline markup[/]");
//
// Style danger = new(
//     foreground: Color.Red,
//     background: Color.White,
//     Decoration.Bold | Decoration.Italic | Decoration.RapidBlink);
//
// //AnsiConsole.Write(new Markup("Danger Text from Style\n", danger));
// AnsiConsole.Write(new Markup("Danger Text from Style", danger));
// AnsiConsole.WriteLine(" and more...");

// Lesson 04 - Text Prompts
//int age = AnsiConsole.Ask<int>("What is you age?");
//bool isHappy = AnsiConsole.Ask<bool>("Are you happy?");
// int age = AnsiConsole.Prompt(
//     new TextPrompt<int>("What is your age?")
//         .Validate((x) => x switch
//         {
//             < 0 => ValidationResult.Error("You were not born yet"),
//             > 120 => ValidationResult.Error("You are too old"),
//             _ => ValidationResult.Success()
//         })
// );
// string happyText = AnsiConsole.Prompt(
//     new TextPrompt<string>("Are you happy")
//         .AddChoice("yes")
//         .AddChoice("no")
//         .DefaultValue("yes")
// );
// AnsiConsole.MarkupLine($"Happy: {happyText}\nAge: {age}\n");

// Lesson 05 - Item Selections
// List<string> names =
// [
//     "Zara Blackwood",
//     "Felix Northstar",
//     "Luna Silverbrook",
//     "Kai Winters",
//     "Aurora Vale",
//     "Atlas Thorne\n"
// ];
//
// string favoriteName = AnsiConsole.Prompt(
//     new SelectionPrompt<string>()
//         .Title("which is your favorite placeholder name?")
//         .PageSize(4)
//         .MoreChoicesText("[grey](move down to reveal more choices)[/]")
//         .AddChoices(names)
//
// );
//
// AnsiConsole.MarkupLine($"Your favorite name is [red]{favoriteName}[/].");

//Lesson 06 - Multi Selects
// List<string> names =
// [
//     "Zara Blackwood",
//     "Felix Northstar",
//     "Luna Silverbrook",
//     "Kai Winters",
//     "Aurora Vale",
//     "Atlas Thorne\n"
// ];
//
// List<string> familyNames =
// [
//     "Charity",
//     "Jon",
//     "Chris"
// ];
//
// List<string> favoriteName = AnsiConsole.Prompt(
//     new MultiSelectionPrompt<string>()
//         .Title("Which are your favorite placeholder names?")
//         .InstructionsText("Press <space> to toggle, <enter> to accept")
//         //.AddChoices(names)
//         .AddChoiceGroup("Usual Names", names)
//         .AddChoiceGroup("Family Names", familyNames)
// );
//
// foreach (string name in favoriteName)
// {
//     Console.WriteLine(name);
// }

//Lesson 07 - Tables

List<Text> person =
[
    new("Bilbo"),
    new("Baggins"),
    new("111")
];

Table table = new();
table.Centered();
//table.Expand();
table.Border(TableBorder.Rounded);
table.ShowRowSeparators();

table.AddColumn("First Name");
table.AddColumn("Last Name");
table.AddColumn("Age");

table.Columns[0].PadLeft(5).PadRight(5);
table.Columns[1].Width(15);
table.Columns[1].RightAligned();


table.AddRow("Tim", "Corey", "46");
table.AddRow("Sue", "Storm", "23");
table.AddRow(person);

AnsiConsole.Write(table);

AnsiConsole.MarkupLine("");


