public class Program
{
    static string FLCP(string[] strs) {
        var prefix = strs[0];
        foreach (var word in strs)
        {
            while (word.IndexOf(prefix, StringComparison.Ordinal) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return "Completely different words";
            }
        }
        return prefix;
    }
	
    public static void Main()
    {
        Console.WriteLine($"Answer = {FLCP(new[] {"flower", "flow", "flight"})}"); 
        Console.WriteLine($"Answer = {FLCP(new[] {"dog", "racecar", "car"})}"); 
    }
}