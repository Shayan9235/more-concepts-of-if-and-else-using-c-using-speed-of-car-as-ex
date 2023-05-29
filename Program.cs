internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("enter the speed limit : ");
        int speedLimit = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the speed of car:");
        int carSpeed = int.Parse(Console.ReadLine());
        if (carSpeed <= speedLimit)
        {
            Console.WriteLine("ok!");
        }
        else
        {
            int demeritPoints = (carSpeed - speedLimit) / 5;
            Console.WriteLine("demerit points: { demeritPoints}");
            if (demeritPoints > 12)
            {
                Console.WriteLine("license suspended!");

            }
        }

    }
}
