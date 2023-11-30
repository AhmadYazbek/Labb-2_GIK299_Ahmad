using System.ComponentModel;

namespace Labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur stor familj har du?");
            int familySize = Convert.ToInt32(Console.ReadLine());
            
            
            
            string[] names = new string[familySize];  
            double[] age = new double[familySize];
            double totalAge = 0;
            double averageAge = 0;
            int menuSelector = 0;
            int userInput = 0;


            while (menuSelector != 5)  // En whileloop där varibeln menuSelector som bestämmer om loopen fortsätter eller inte.
            {
                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "\nVälj ett av alternativen:" +
                    "\n1.) Lägg till namn på familjemedlemmar" +
                    "\n2.) Visa familjemedlemmar" +
                    "\n3.) Skriva ut summan av familjemedlemmarnas ålder" +
                    "\n4.) Skriva ut medelåldern för familjemedlemmarna" +
                    "\n5.) Avsluta" +
                    "\n----------------------------------------------------"
                    );
                menuSelector = Int32.Parse(Console.ReadLine()); // Tar emot användarens input och konverterar den från en sträng till ett heltal (int) för att anpassa den till variebeln menuSelector.

                switch (menuSelector)  // Använt en switch-case för att avgöra vad användaren väljer.

                {
                    case 1:

                        if (userInput < familySize)
                        {
                            Console.WriteLine("Namn på familjemedlemen"); // Jag frågar användaren vad familjemedlemmen heter genom att den skriver ut texten till konsolfönstret.
                            names[userInput] = Console.ReadLine();

                            Console.WriteLine("Ålder på familjemedlemen");
                            age[userInput] = double.Parse(Console.ReadLine());
                            userInput++;
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("stopp, det är fullt");
                        }

                        break;  // Använder en break för att gå ur det case i switch-loopen som vi befinner oss i.


                    case 2:
                        {
                            if (userInput == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Du har ej namngett någon familjemedlem");
                            }

                            else
                            {
                                for (int i = 0; i < userInput; i++)   // Använder en for loop som användaren själv väljer vilket tal som helst och lägger på olika index i arrayen userInput. 
                                {
                                    Console.WriteLine(names[i] + " är " + age[i] + " år gammal"); // 

                                }
                            }
                        }

                        break;

                    case 3:

                        for (int i = 0; i < userInput; i++)
                            
                        {
                            totalAge += age[i];

                        }
                        Console.WriteLine(" Summan är " + totalAge.ToString("0.00"));

                        break;

                    case 4:
                        for (int i = 0; i < userInput; i++)
                        {
                            averageAge += age[i];

                        }
                        averageAge = averageAge / userInput;  // För att räkna ut medelåldern för familjemedlemmarna så delas totala åldern med antal familjemedlemmar.
                            Console.WriteLine(" Medelåldern är " + averageAge.ToString("0.00"));
                       
                        break;

                    case 5:
                        Console.WriteLine("Avsluta");
                        break;


                    default: // Ifall inget annat case körs, ser ni default-case i switch-satsen som är det case som körs.
                        Console.WriteLine("Felaktig indata, du måste ange ett nummer mellan 1 - 5\n");
                        break;
                }   }
            }
        }
    }


