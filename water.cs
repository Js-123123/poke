using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class Water : Pokemon{
//the pokemon stats
  private int HydroCannon;
  private int WaterGun; 
  private int HydroPump;
  private int WaterShuriken;
  private int HydroVortex;
  private int WaterPulse;
  
  public Water(string a){
  
    
  }
// defalt contructer
  public Water(){
    HydroCannon = 65;
    WaterGun = 40; 
    HydroPump = 80;
    WaterShuriken = 110;
    HydroVortex = 50;
    WaterPulse = 85;
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
  public void SetHydroCannon(int HC){
    HydroCannon = HC;
  }
  public int GetHydroCannon(){
    return HydroCannon;
  } 
  public void SetWaterGun(int WG){
    WaterGun = WG;
  }
  public int GetWaterGun(){
    return WaterGun;
  }
  public void SetHydroPump(int HY){
    HydroPump = HY;
  }
  public int GetHydroPump(){
    return HydroPump;
  }
  public void SetWaterShuriken(int WS){
    WaterShuriken = WS;
  }
  public int GetWaterShuriken(){
    return WaterShuriken;
  }
  public void SetHydroVortex(int HV){
    HydroVortex = HV;
  }
  public int GetHydroVortex(){
    return HydroVortex;
  }
  public void SetWaterPulse(int WP){
    WaterPulse = WP;
  }
  public int GetWaterPulse(){
    return WaterPulse;
  }


  
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
  
}