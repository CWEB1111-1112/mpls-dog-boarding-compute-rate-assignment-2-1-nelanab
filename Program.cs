using System;

namespace assignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog_nights;
            string dog_addOn;
            string dog_code;

            // Getting the Amount of Time the dog is staying
            Console.WriteLine("Please enter the amount of day's your dog is staying: ");
            dog_nights = Convert.ToInt32(Console.ReadLine());

            // Asking if user wants add on services
            Console.WriteLine("Do you want add on services? Yes / No : ");
            dog_addOn = Console.ReadLine();

            if(dog_addOn == "Yes"){
                Console.WriteLine("Additional Services Cost: Bathing and Grooming Code A: $169.00 per night | Bathing Only Code C: $112.00 per night");
                Console.Write("Please enter the desired code (A, C): ");
                dog_code = Console.ReadLine();

                computeRate(dog_nights, dog_code);
            }else{
                computeRate(dog_nights);
            };   
        }

        static void computeRate(int dog_nights, string dog_code){
            const double CODE_A = 169.00;
            const double CODE_C = 112.00;

            if(dog_code == "A"){
                double total = dog_nights * CODE_A;
                Console.WriteLine($"The total for your dog's {dog_nights.ToString()} night Code: {dog_code} stay is: {total.ToString("c")}");
            }
            if(dog_code == "C"){
                double total = dog_nights * CODE_C;
                Console.WriteLine($"The total for your dog's {dog_nights.ToString()} night Code: {dog_code} stay is: {total.ToString("c")}");
            }
            if(dog_code != "A" || dog_code != "C"){
                Console.WriteLine("Code does not exist, sorry!");
            }
        }

        static void computeRate(int dog_nights){
            double total = dog_nights * 75.00;
            Console.WriteLine($"The total for your dog's {dog_nights.ToString()} night stay is: {total.ToString("c")}");
        }
    }

}

    
