using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Resourcer;

public static class Images
{
    static Images()
    {
        using var activeStream = Resource.AsStream("active.ico");
        Active = new(activeStream);
        using var defaultStream = Resource.AsStream("default.ico");
        Default = new(defaultStream);
        using var exitStream = Resource.AsStream("exit.png");
        Exit = new (exitStream);
        using var deleteStream = Resource.AsStream("delete.png");
        Delete = new(deleteStream);
        using var acceptAllStream = Resource.AsStream("acceptAll.png");
        AcceptAll = new(acceptAllStream);
        using var acceptStream = Resource.AsStream("accept.png");
        Accept = new(acceptStream);
        using var discardStream = Resource.AsStream("discard.png");
        Discard = new(discardStream);
        using var vsStream = Resource.AsStream("vs.png");
        VisualStudio = new(vsStream);
        using var folderStream = Resource.AsStream("folder.png");
        Folder = new(folderStream);
        using var optionsStream = Resource.AsStream("cogs.png");
        Options = new(optionsStream);
        using var linkStream = Resource.AsStream("link.png");
        Link = new(linkStream);
    }

    public static Bitmap VisualStudio { get; }
    public static Bitmap Link { get; }
    public static Bitmap Discard { get; }
    public static Bitmap Accept { get; }
    public static Bitmap AcceptAll { get; }
    public static Bitmap Delete { get; }
    public static Bitmap Exit { get; }
    public static Bitmap Folder { get; }
    public static Bitmap Options { get; }
    public static WindowIcon Active { get; }
    public static WindowIcon Default { get; }
}