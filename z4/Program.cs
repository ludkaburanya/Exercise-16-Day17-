namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text;
            using (StreamReader sr = new StreamReader(@"C:\z3\z4.txt"))
            {
                text = sr.ReadToEnd().ToCharArray();
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0')
                    text[i] = '1';
                else
                {
                    if (text[i] == '1')
                        text[i] = '0';
                }
            }
            using (StreamWriter sw = new StreamWriter(@"C:\z3\z44.txt"))
            {
                foreach (char c in text)
                    sw.Write(c);
            }
        }
    }
}