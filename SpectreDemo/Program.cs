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
int age = AnsiConsole.Prompt(
 new TextPrompt<int>("What is your age?")
     .Validate((x) => x switch
     {
         < 0 => ValidationResult.Error("You were not born yet"),
         > 120 => ValidationResult.Error("You are too old"),
         _ => ValidationResult.Success()
     })
);
string happyText = AnsiConsole.Prompt(
 new TextPrompt<string>("Are you happy")
     .AddChoice("yes")
     .AddChoice("no")
     .DefaultValue("yes")
);
AnsiConsole.MarkupLine($"Happy: {happyText}\nAge: {age}\n");

AnsiConsole.MarkupLine("");


