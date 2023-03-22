public class Program
{  
    public static void Main(string[] args) 
    {
        string repeat = "Y";
        bool resultofcompare = false;
        do
        {
            resultofcompare = false;
            Console.WriteLine("Insert number X:");
            string firstString = Console.ReadLine();
            int x = Convert.ToInt32(firstString);
            Console.WriteLine("Insert number Y:");
            string secondString = Console.ReadLine();
            int y = Convert.ToInt32(secondString);
            Console.WriteLine("Choose operating (+, -, *, /)");
            string operating = Console.ReadLine();
            if (operating == "+")
            {
                int summ = x + y;
                Console.WriteLine("Summ = " + summ);
            }
            else if (operating == "-")
            {
                int substruct = x - y;
                Console.WriteLine("Substruct = " + substruct);
            }
            else if (operating == "*")
            {
                        int add = x * y;
                        Console.WriteLine("Add = " + add);
            }
            else if (operating == "/")
            {
                double div = (double)x / (double)y;
                Console.WriteLine("{0:F4}", div);
            }

            Console.WriteLine("Do you want to repeat evaluation? If Yes - insert y, if No - insert n");

            repeat = Console.ReadLine();
            if((repeat == "Y")||(repeat == "y")) resultofcompare = true;
        }

        while (resultofcompare);
    }  
}