namespace NBEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            NBClass sun = new NBClass();
            sun.setPrice(25000);
            Console.WriteLine("Sun筆電單價{0}", sun.getPrice());
            Console.Read();
        }
    }
}