namespace ReverseApi;

public static class TextUtils
{
    public static string Reverse(string? s)
    {
        if (s is null) return string.Empty;
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
