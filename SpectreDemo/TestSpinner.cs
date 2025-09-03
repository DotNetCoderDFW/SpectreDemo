using Spectre.Console;

namespace SpectreDemo;

public class TestSpinner : Spinner
{
    public override TimeSpan Interval => TimeSpan.FromMilliseconds(200);
    public override bool IsUnicode => false;

    public override IReadOnlyList<string> Frames =>
        ["Ooooo", "oOooo", "ooOoo", "oooOo", "ooooO"];
}