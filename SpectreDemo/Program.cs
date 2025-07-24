using Spectre.Console;

AnsiConsole.Clear();

// Lesson 02 Initial Setup
// AnsiConsole.MarkupLine("[red bold]Hello World[/]");
// AnsiConsole.MarkupLine("Hello World");
// AnsiConsole.MarkupLine("[slowblink]Hello World[/]");

//Lesson 03 - Colors and Styles
AnsiConsole.MarkupLine("[red on white bold]This is the inline markup[/]");

Style danger = new(
    foreground: Color.Red,
    background: Color.White,
    Decoration.Bold | Decoration.Italic | Decoration.RapidBlink);

//AnsiConsole.Write(new Markup("Danger Text from Style\n", danger));
AnsiConsole.Write(new Markup("Danger Text from Style", danger));
AnsiConsole.WriteLine(" and more...");

AnsiConsole.MarkupLine("");


