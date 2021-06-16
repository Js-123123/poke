  using System;
  using System.IO;
  using System.Collections.Generic;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class MainClass {
  public static int Battle(Pokemon player, Pokemon computer){
      //random  battle
      Random rnd = new Random();
      //gereate number
      int number = rnd.Next(0, 6);
      return number;
  }
  public static void Main (string[] args) {
    int BotBatNum = 3;   // number of bot pokemon left
    int PlayerBatNum = 3;//numbers of pokemon left
    int battleNum = 1;   //loop control
    List<Pokemon> playerList = new List<Pokemon>(); // pokemon list
    List<Pokemon> computerList = new List<Pokemon>(); // pokemon list
    StreamReader playFile = new StreamReader("pokemon.csv");
    string line;  
    bool done = false;
    while((line = playFile.ReadLine()) != null){
            string[] fields = line.Split(","); 
              if(fields[8][0] == 'P'){
                
                playerList.Add(new Pokemon(line));
                  }
              if(fields[8][0] == 'C'){
                computerList.Add(new Pokemon(line));
    }
    }
        playFile.Close();
    // while not done the menu will continue to print
    while(!done){
      int selection = PrintMenu();

      switch (selection){
       case 1:
      //player pokemon choice
        foreach (Pokemon PokePlayah in playerList){
          Console.WriteLine(PokePlayah);
        }
            
          //}
      
          break;
          //ListTech(techList);
        case 2:
        //computer pokemon
        foreach (Pokemon PokeCom in computerList){
          Console.WriteLine(PokeCom);
        }
          break;
        case 3:
        Console.WriteLine("Battle Begin:");
        //battle loops 
        for (int i = 0; i < 7; i++){
          Random rnd = new Random();
          int number = rnd.Next(0, 6);
          
          while (battleNum != 0){
          if(number == 1){
            Console.WriteLine("Gigalith has fainted");
            PlayerBatNum --;
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            PlayerBatNum --;
            battleNum --;
          }
          else if (number == 2){
            Console.WriteLine("Emboar has fainted");
            PlayerBatNum --;
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            battleNum --;
          }
          else if (number == 3){
            Console.WriteLine("Zekrom has fainted ");
            PlayerBatNum --;
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            PlayerBatNum --;
            battleNum --;
          }
          else if (number == 4){
            Console.WriteLine("Cofagrigus has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            battleNum --;
          
          }
          else if (number == 5){
            Console.WriteLine("Hydeigon has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            battleNum --;
          }
          else if (number == 6){
            Console.WriteLine("Kyurem has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");
            battleNum --;
          }
          else{
            Console.WriteLine("Gigalith has fainted?");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left");  
            BotBatNum --;
            battleNum --;
          }
          
          }
          if(PlayerBatNum == 0){
            battleNum++;
          // for the battle loop
          }
          }
          break;
        case 4:
        //reset hp
          Console.WriteLine($"HP has been reset to max");
          
          break;
        case 5:
        //program exit
          Console.WriteLine(" Thank you for using the program ");
          done = true;   
          break;
        default:
          // if the user picks a non 1,2,3,4 number
          Console.WriteLine("❌  That option does not exist ❌\n");
          break;
    }
    Console.Write("Press enter to continue");
    Console.ReadLine();
    Console.Clear();
    
  }
}  

  
  
 static int PrintMenu(){
    Console.WriteLine($"Welcome to the Pokemon System.");
    Console.WriteLine("The following options are availible:");
    Console.WriteLine("1. List Player Pokemon");
    Console.WriteLine("2. List Terrorbyte's Pokemon");
    Console.WriteLine("3. Battle");
    Console.WriteLine("4. Reset Pokemon");
    Console.WriteLine("5. Exit Program");
    Console.Write("\nOption: ");
        return Convert.ToInt32(Console.ReadLine());
      }
  }
