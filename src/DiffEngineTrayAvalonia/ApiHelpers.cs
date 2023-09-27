public static class ApiHelpers
{
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool BringWindowToTop(nint hWnd);
}
