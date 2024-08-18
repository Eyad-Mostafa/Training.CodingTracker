using Spectre.Console;

namespace CodingTracker.Models;

internal static class TableVisualisationEngine
{
    internal static void PrintSessions(List<CodingSession> sessions)
    {
        Console.Clear();
        var table = new Table();

        table.Title("Coding Sessions");

        table.AddColumn("ID");
        table.AddColumn("Date");
        table.AddColumn("Start Time");
        table.AddColumn("End Time");
        table.AddColumn("Duration");
        table.AddColumn("Description");
        foreach (var session in sessions)
        {
            table.AddRow($"{session.Id}", $"{session.Date}", $"{session.StartTime}", $"{session.EndTime}", $"{session.DurationFormatted}", $"{session.Description}");
        }

        AnsiConsole.Write(table);
    }




    //    // Display a progress bar
    //    AnsiConsole.Progress()
    //        .Start(ctx =>
    //        {
    //    var task = ctx.AddTask("[green]Processing...[/]");

    //    while (!ctx.IsFinished)
    //    {
    //        task.Increment(12.5);
    //        Thread.Sleep(50);
    //    }
    //});
    //    TimeSpan test = DateTime.Now.AddHours(3) - DateTime.Now;
    //AnsiConsole.MarkupLine($"[bold red] {((int)test.TotalHours)} [/]");



}
