
namespace ClassPracticeOf18August
{
    public static class StringExtension
    {
        public static string ToCapitalize(this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

    }
}
