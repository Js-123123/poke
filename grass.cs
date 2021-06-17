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
    nAttack = "Giga Impact";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 2){
    attackD = MagicalLeaf;
    nAttack = "Magical Leaf";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 3){
    attackD = SolarBlade;
    nAttack = "Solar Blade";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 4){
    attackD = RockSlide;
    nAttack = "Rock Slide";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 5){
    attackD = BulletSeed;
    nAttack = "Bullet Seed";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 6){
    attackD = MaxKnuckle;
    nAttack = "Max Knuckle";
    Console.WriteLine($"{nAttack} did {attackD} damage!");
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