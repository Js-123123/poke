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
          break;
        case 2:
        //computer pokemon
        foreach (Pokemon PokeCom in computerList){
          Console.WriteLine(PokeCom);
        }
          break;
        case 3:
        //get player pokemon
        foreach (Pokemon PokePlayah in playerList){
          Console.WriteLine(PokePlayah);
        }
        Console.WriteLine("\nChoose 1st pokemon");
        string PchoiceO = Console.ReadLine();
        Console.WriteLine("Choose 2nd pokemon");
        string PchoiceT = Console.ReadLine();
        Console.WriteLine("Choose 3rd pokemon");
        string PchoiceH = Console.ReadLine();
        //get computer pokemon
        foreach (Pokemon PokeCom in computerList){
          Console.WriteLine(PokeCom);
        }
        Console.WriteLine("\nChoose Computer's 1st pokemon");
        string CchoiceO = Console.ReadLine();
        Console.WriteLine("Choose Computer's2nd pokemon");
        string CchoiceT = Console.ReadLine();
        Console.WriteLine("Choose Computer's3rd pokemon");
        string CchoiceH = Console.ReadLine();
        
        
        
        
        //battle loops 
           
        
          
          
        while ((PlayerBatNum > 0) & (BotBatNum > 0)){
        Random rnd = new Random();
        int number = rnd.Next(0, 6); 
          if(number == 1){
            
            Console.WriteLine($"{PchoiceO} has fainted");
            PlayerBatNum --;
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
           
            battleNum --;
          }
          else if (number == 2){
            Console.WriteLine($"{PchoiceT} has fainted");
            
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            PlayerBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
            
            battleNum --;
          }
          else if (number == 3){
            Console.WriteLine($"{PchoiceH} has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            PlayerBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
            
            battleNum --;
          }
          else if (number == 4){
            Console.WriteLine($"{CchoiceH} has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
            battleNum --;
          
          }
          else if (number == 5){
            Console.WriteLine($"{CchoiceO}Hydeigon has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
            battleNum --;
          }
          else if (number == 6){
            Console.WriteLine($"{CchoiceT} has fainted ");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");
            battleNum --;
          }
          else{
            Console.WriteLine($"{CchoiceH} has fainted?");
            Console.WriteLine($"You have {PlayerBatNum} pokemon left");
            BotBatNum --;
            Console.WriteLine($"Terrorbyte has {BotBatNum} pokemon left\n");  
            
            battleNum --;
          }
          
          }
          if(PlayerBatNum == 0){
    
            Console.WriteLine("PLAYER HAS LOST");
          // for the battle loop
          }
          if(BotBatNum == 0)
            Console.WriteLine("PLAYER IS VICTORIOUS");
          break;
        case 4:
        //reset hp
        foreach(Pokemon pokemon in playerList){    
          pokemon.Revive();   
      }
        foreach(Pokemon pokemon in computerList){  
          pokemon.Revive();   
        }
        Console.WriteLine($"HP has been reset to max");  
          break;
        case 5:
        //program exit
        //TMR
          //StreamWriter outputFile = new StreamWriter("pokemon.csv");
          Console.WriteLine("Thank you for using the program ");

          done = true;   
          break;
        default:
          // if the user picks a non 1,2,3,4 number
          Console.WriteLine("❌  That option does not exist ❌\n");
          break;
    }     
    Console.Write("\nPress enter to continue");
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
