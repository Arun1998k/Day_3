class Program
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        Random random = new Random();

        int empCheck = random.Next(2);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee is presant");

        }
        else
        {
            Console.WriteLine("Employee is absand");

        }
    }
}