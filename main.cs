using System;
 
class Program {
 public static void Main (string[] args) {

   Console.ForegroundColor = ConsoleColor.Cyan;//sets font to Red
   Console.BackgroundColor = ConsoleColor.Black;//sets background to white

   Sig();
 
   Console.WriteLine ("\t\t\t\t\t\t WELCOME TO: What Kind of Super Hero Are You?:");
 
   Console.WriteLine("\n\t\t\t\t\t\tReady for your first question?");
// Declare all variables to use later to set to return values
   string question1= "";
   string question2 = "";
   string question3 = "";
   string question4 = "";
   string question5 = "";
   string question6 ="";
   string question7 = "";
   string question8 = "";
   string question9 = "";
   string question10 = "";
   string personality = "";

//set values of returns to a variable
   question1 =Q1();
   question2 =Q2();
   question3 =Q3();
   question4 =Q4();
   question5 =Q5(); 
   question6 =Q6();
   question7 =Q7();
   question8 =Q8();
   question9 =Q9();
   question10 =Q10();

 
   // CALCULATION PROCESS
   // As Kid, Super Strength, Leader, Weak Super Powers, Every Kids Idol, Funny Super Powers 
   if (question1 == "study" || question2 == "just a glass"|| question3 == "books" ||question4 == "teacher"|| question5 == "lottery")
   {
     personality = "60% Smart Super Hero\n  0% Super Strength\n 20% Leader, 20% Weak Super Powers\n 0% Every Kids Idol\n 0% Funny Super Powers";
   }
 
    if (question4 == "scholar" || question5 == "As" || question6 == "intellegence" || question8 == "solo" || question1 == "code" || question2 == "no glass"||question7 =="bystander" || question8 == "partners"||question9 == "I use kindle")
   {
     personality = "10% Smart Super Hero\n  0% Super Strength\n 50% Leader\n 30% Weak Super Powers\n 10% Every Kids Idol\n 0% Funny Super Powers";
   }
 
    if (question2 == "empty" || question7 == "nerd" || question9 == "yes" || question10 == "Chipotle" || question1 == "exercise"|| question4 == "doctor" ||question5 == "kill covid")
   {
     personality = "20% Smart Super Hero\n  0% Super Strength\n 10% Leader\n 70% Weak Super Powers\n 0% Every Kids Idol\n 0% Funny Super Powers";
   }
 
    if (question1 == "play" || question7 == "bully" || question4 == "athlete" || question9 == "no" || question3 == "shopping" || question6 == "new outfit"||question8== "tro"||question10 == "Mcdonalds")
   {
     personality = "0% Smart Super Hero\n  70% Super Strength\n 0% Leader\n 0% Weak Super Powers\n 10% Every Kids Idol\n 20% Funny Super Powers";
   }
 
    if (question2 == "full" || question5 == "love" || question6 == "hair" || question8 == "team" ||question3 == "dance"||question7 =="principal" || question9 == "what are books" || question10 == "Subway")
   {
     personality = "0% Smart Super Hero\n  20% Super Strength\n 10% Leader\n 0% Weak Super Powers\n 60% Every Kids Idol\n 10% Funny Super Powers";
   }
 
   if (question3 == "games" || question10 == "Tacobell" || question6 == "no mask" )
   {
     personality = "10% Smart Super Hero\n  10% Super Strength\n 10% Leader\n 0% Weak Super Powers\n 0% Every Kids Idol\n 70% Funny Super Powers";
   }

   Console.WriteLine("\t\t\t\t\t\tCongrats on finishing the survey!");
   
   Console.WriteLine("\n\n\t\t\t\t\t\tYour Super Hero personality is...\n" + personality);
   
   Console.WriteLine("Have a Nice Day!");

   Sig();
 
 }

     static string Q1()
     {
       //Q1
     Console.WriteLine("\n1. Would you rather: \n 'study' for an upcoming math test\n 'play' with your friends?\n 'exercise' \n  'code' ");
 
      return Console.ReadLine();
 
     }
 
     static string Q2(){ //Q2
 
     Console.WriteLine("\n2. Do you see the glass as half: \n  'empty'\n 'full'\n 'just a glass'\n there is 'no glass' \n");
 
      return  Console.ReadLine();
 
     }
 
     static string Q3(){//Q3
 
     Console.WriteLine("\n3. Pick one: \n'books' \n 'games'\n 'dance'\n 'shopping' \n");
 
      return Console.ReadLine();
 
     }
 
     static string Q4(){//Q4
 
     Console.WriteLine("\n4. Which one do you want to be when you grow up?:\n 'scholar'\n 'athlete'\n 'teacher'\n 'doctor'\n ");
 
      return Console.ReadLine();
 
     }
 
      static string Q5(){//Q5
 
     Console.WriteLine("\n5. Pick one: \n'As' \n 'love' \n 'lottery' \n 'kill covid'\n ");
 
      return Console.ReadLine();
 
      }
 
      static string Q6(){//Q6
 
     Console.WriteLine("\n 6. Pick one: \n'intellegence' \n 'hair' \n 'no mask' \n 'new outfit'\n ");
 
      return Console.ReadLine();
      
      }
      static string Q7(){//Q7
 
     Console.WriteLine("\n7. Are you a:\n 'nerd' \n 'bully' \n 'bystander' \n 'principal' \n");
 
      return Console.ReadLine();
     
      }
      static string Q8(){//Q8
 
     Console.WriteLine("\n8. Would you rather save the world as\n a 'team'\n 'solo' \n 'partners' \n 'trio' \n");
 
      return Console.ReadLine();
 
      }
      static string Q9(){//Q9
 
     Console.WriteLine("\n9. Do you lick the pages of a book when you turn them?\n 'yes' \n 'no' \n 'what are books' \n 'I use kindle'\n ");
 
      return Console.ReadLine();
      
      }
     static string Q10(){//Q10
 
     Console.WriteLine("\n10. Pick a fast food place: \n 'Chipotle' \n 'Tacobell' \n 'Subway' \n 'Mcdonalds' \n");
 
     return Console.ReadLine();
 
     }
     static void Sig()
{
Console.WriteLine(@" __  _, ____, ____, ___,       ____, ___,   ____, ____,  
(-\ |  (-|_, (-|_, (-|_)      (-|   (-|_\_,(-|   (-|  |  
   \|   _|__, _|__, _| \_,    _ |    _|  )  _|__, _|  |_,
       (     (     (         (__/   (      (     (       ");

}
 }