using System.Text;
using System.Text.Json;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = File.ReadAllLines("C:\\hw.txt");
            array = array.Select(e => e.FirstSymbolsToUpper()).ToArray();
        }


    }
    public static class StringExtensions
    {
        public static string FirstSymbolsToUpper(this string input) =>
            input switch
            {
                "" => throw new Exception("This string cannot be empty"),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };
    }
}
