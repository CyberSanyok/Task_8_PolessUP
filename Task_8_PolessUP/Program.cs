internal class Program
{
    private static void Main(string[] args)
    {
        string s = "";
        int[] rgb = { -88, 1, 999 };
        for (int i = 0; i < rgb.Length; i++)
        {
            if (rgb[i] >255) rgb[i] = 255;
            if (rgb[i] < 0) rgb[i] = 0;
            if (rgb[i].ToString().Length == 1) s += "0" + Convert.ToString(+rgb[i]);
            else
            s += Convert.ToString(rgb[i], 16);
        }
        Console.WriteLine(s);
    }
}