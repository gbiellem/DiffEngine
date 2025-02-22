static partial class Implementation
{
    public static Definition Rider()
    {
        var launchArguments = new LaunchArguments(
            Left: (temp, target) => $"diff \"{target}\" \"{temp}\"",
            Right: (temp, target) => $"diff \"{temp}\" \"{target}\"");

        return new(
            Tool: DiffTool.Rider,
            Url: "https://www.jetbrains.com/rider/",
            AutoRefresh: true,
            IsMdi: false,
            SupportsText: true,
            RequiresTarget: true,
            Cost: "Paid with free option for OSS",
            BinaryExtensions: Array.Empty<string>(),
            OsSupport: new(
                Windows: new(
                    "rider64.exe",
                    launchArguments,
                    @"%LOCALAPPDATA%\Programs\Rider\bin\"),
                Osx: new(
                    "rider",
                    launchArguments,
                    "/Applications/Rider.app/Contents/MacOS/"),
                Linux: new(
                    "rider.sh",
                    launchArguments,
                    "%HOME%/.local/share/JetBrains/Toolbox/apps/Rider/*/*/bin/")),
            Notes: " * https://www.jetbrains.com/help/rider/Command_Line_Differences_Viewer.html");
    }
}