using System.Text;
namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string Substring(this StringBuilder target, int startIndex, int count)
        {
            StringBuilder substring= new StringBuilder();

            for (int i = 0 ; i < count; i++)
            {
                substring.Append(target[startIndex]);
                startIndex++;
            }

            return substring.ToString();
        }
    }
}
