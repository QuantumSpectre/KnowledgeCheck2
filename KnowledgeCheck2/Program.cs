using KnowledgeCheck2.Objects;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("How many characters do you want to add today? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<FantasyCharacter>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new FantasyCharacter();

                Console.WriteLine("Enter your characters name ");
                myClass.Name = Console.ReadLine();
                Console.WriteLine("What is your characters gender?");
                myClass.Gender = Console.ReadLine();
                Console.WriteLine("What is your characters starting age?");
                myClass.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("What race is your character?");
                myClass.Race = Console.ReadLine();
                Console.WriteLine("Please enter a short discription for your character.");
                myClass.Description = Console.ReadLine();
                Console.WriteLine("What is your characters class?");
                myClass.Class = Console.ReadLine();


                recordList.Add(myClass);
                Console.WriteLine("Character added! \n");
            }

            // Print out the list of records using Console.WriteLine()

            Console.WriteLine("Your new characters are: \n");

            foreach (FantasyCharacter x in recordList)
            {
                Console.WriteLine(x.ToString());
            }

        }
    }
}