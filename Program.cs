namespace git_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RURU");
            int n1,n2;
            string nom;
            n1 = n2 = 1;
            Console.WriteLine(n1 + n2);
            nom = leerdato();
        }
        public static string leerdato()
        {
            string nom;
            nom= Console.ReadLine();
            return nom;
        }
    }
}