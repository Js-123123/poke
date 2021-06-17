using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class Grass : Pokemon{
//the pokemon stats
  private int GigaImpact; 
  private int MagicalLeaf;
  private int SolarBlade;
  private int RockSlide;  
  private int BulletSeed;
  private int MaxKnuckle;// trrop num
  
  public Grass(string a){
  
    
  }
// defalt contructer
  public Grass(){
  GigaImpact = 150;
	MagicalLeaf = 60;
	SolarBlade = 125;
	RockSlide = 75;
	BulletSeed = 25;
	MaxKnuckle = 100;
  }
  public override void Attacks(){
    string nAttack;
    int attackD;
    Random rnd = new Random();
    int AMnumber = rnd.Next(0, 6);
    if(AMnumber == 1){
    attackD = GigaImpact;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 2){
    attackD = MagicalLeaf;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 3){
    attackD = SolarBlade;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 4){
    attackD = RockSlide;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 5){
    attackD = BulletSeed;
    Console.WriteLine($"{attackD}");
    }
    if(AMnumber == 6){
    attackD = MagicalLeaf;
    Console.WriteLine($"{attackD}");
    }




}
    //getter and setters
  public void SetGigaImpact(int GI){
    GigaImpact = GI;
  }
  public int GetGigaImpact(){
    return GigaImpact;
  } 
  public void SetMagicalLeaf(int ML){
    MagicalLeaf = ML;
  }
  public int GetMagicalLeaf(){
    return MagicalLeaf;
  }
  public void SetRockSlide(int RS){
    RockSlide = RS;
  }
  public int GetRockSlide(){
    return RockSlide;
  }
  public void SetBulletSeed(int BT){
    BulletSeed = BT;
  }
  public int GetBulletSeed(){
    return BulletSeed;
  }
  public void SetSolarBlade(int SB){
    SolarBlade = SB;
  }
  public int GetSolarBlade(){
    return SolarBlade;
  }
  public void SetMaxKnuckle(int MX){
    MaxKnuckle = MX;
  }
  public int GetMaxKnuckle(){
    return MaxKnuckle;
  }


  
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
  
}