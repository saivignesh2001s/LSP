namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IFileRead rs = new Normalaccess();
            rs.Read();
            IFileWrite rf = new Adminaccess();
            IFileRead rd = new Adminaccess();
            rd.Read();
            rf.Write();

        }
    }
}