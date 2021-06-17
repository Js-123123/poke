using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class GrassPoison : Pokemon{
//the pokemon stats
  private int GigaDrain; 
  private int MagicalLeaf;
  private int SolarBeam;
  private int SeedBomb;  
  private int BulletSeed;
  private int Venoshock;// trrop num
  
  public GrassPoison(string a){
  
    
  }
// defalt contructer
  public GrassPoison(){
  GigaDrain = 75;
	MagicalLeaf = 60;
	SolarBeam = 125;
	SeedBomb = 80;
	BulletSeed = 25;
	Venoshock = 65;
  }
  public override void Attacks(){
    string nAttack;
    int attackD;
    Random rnd = new Random();
    int AMnumber = rnd.Next(0, 6);
    if(AMnumber == 1){
    Console.WriteLine($" uses Thunder");

    }
    if(AMnumber == 2){
    Console.WriteLine("2Sussy Baka");
    }
    if(AMnumber == 3){
    Console.WriteLine("3Sussy Baka");
    }
    if(AMnumber == 4){
    Console.WriteLine("4Sussy Baka");
    }
    if(AMnumber == 5){
    Console.WriteLine("5Sussy Baka");
    }
    if(AMnumber == 6){
    Console.WriteLine("6Sussy Baka");
    }




}
    //getter and setters
  public void SetGigaDrain(int GD){
    GigaDrain = GD;
  }
  public int GetGigaDrain(){
    return GigaDrain;
  } 
  public void SetMagicalLeaf(int ML){
    MagicalLeaf = ML;
  }
  public int GetMagicalLeaf(){
    return MagicalLeaf;
  }
  public void SetSeedBomb(int BB){
    SeedBomb = BB;
  }
  public int GetSeedBomb(){
    return SeedBomb;
  }
  public void SetBulletSeed(int BT){
    BulletSeed = BT;
  }
  public int GetBulletSeed(){
    return BulletSeed;
  }
  public void SetSolarBeam(int SB){
    SolarBeam = SB;
  }
  public int GetSolarBeam(){
    return SolarBeam;
  }
  public void SetVenoshock(int V){
    Venoshock = V;
  }
  public int GetVenoshock(){
    return Venoshock;
  }


  
  // the to string
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
  
}