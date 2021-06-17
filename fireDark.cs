using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class FireDark : Pokemon{
//the pokemon stats
  private int Smog; 
  private int FoulPlay;
  private int Flamethrower;
  private int Crunch;  
  private int Bite;
  private int Inferno;// trrop num
  
  public FireDark(string a){
  
    
  }
// defalt contructer
  public FireDark(){
  Smog = 30;
	FoulPlay = 95;
	Flamethrower = 90;
	Crunch = 80;
	Bite = 60;
	Inferno = 100;
  }
  public override void Attacks(){
    string nAttack;
    int attackD;
    Random rnd = new Random();
    int AMnumber = rnd.Next(0, 6);
    if(AMnumber == 1){
   
    attackD = Inferno;
    Console.WriteLine($"{attackD}");

    }
    if(AMnumber == 2){

    attackD = Smog;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 3){

    attackD = FoulPlay;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 4){

    attackD = Flamethrower;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 5){

    attackD = Crunch;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 6){

    attackD = Bite;
    Console.WriteLine($"{attackD}");
    }




}
    //getter and setters
  public void SetSmog(int S){
    Smog = S;
  }
  public int GetSmog(){
    return Smog;
  } 
  public void SetFoulPlay(int FY){
    FoulPlay = FY;
  }
  public int GetFoulPlay(){
    return FoulPlay;
  }
  public void SetFlamethrower(int F){
    Flamethrower = F;
  }
  public int GetFlamethrower(){
    return Flamethrower;
  }
  public void SetCrunch(int C){
    Crunch = C;
  }
  public int GetCrunch(){
    return Crunch;
  }
  public void SetBite(int B){
    Bite = B;
  }
  public int GetBite(){
    return Bite;
  }
  public void SetInferno(int IR){
    Inferno = IR;
  }
  public int GetInferno(){
    return Inferno;
  }


  
  // the to string
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
  
}