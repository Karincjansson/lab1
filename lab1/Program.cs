using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string data = File.ReadAllText(@"bible-en.txt");
        //string data2 = File.ReadAllText(@"churchill.txt");
        string s = "Testar. Ett, två tre";
        int key = -3;
        var watch = System.Diagnostics.Stopwatch.StartNew();
        string t = encryptText(data.Substring(0,3200000), key);
        watch.Stop();
        var elapsedMs=watch.ElapsedMilliseconds;

        Console.WriteLine($"Efter: {t} Time: {elapsedMs.ToString()}" );
        
    }
    public static string encryptText(string inString, int key) 
    {
        string outString = "";
        for (int i = 0; i < inString.Length; i++)
        {
            char c = inString[i];   
            if(c>='a' && c <= 'z') 
            {
                c = (char)('a' + (c - 'a' + key + 26) % 26);
                
            }
            else if(c>='A' && c <= 'Z') 
            {
                c = (char)('A' + (c - 'A' + key + 26) % 26);
            }
            outString += c;
        }
        return outString;
    }
}