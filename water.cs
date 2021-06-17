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
    nAttack = "Hydro Cannon";
    attackD = HydroCannon;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
   
    }
    if(AMnumber == 2){
   
    nAttack = "Water Gun";
    attackD = WaterGun;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    
    }
    if(AMnumber == 3){
  
    nAttack = "Hydro Pump";
    attackD = HydroPump;
    Console.WriteLine($"{nAttack} did {attackD} damage!");

    }
    if(AMnumber == 4){
    nAttack = "Water Shuriken";
    attackD = WaterShuriken;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 5){
    nAttack = "Hydro Vortex";
    attackD = HydroVortex;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 6){
 
    nAttack = "WaterPulse";
    attackD = WaterPulse;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
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
  //getters and setters for the hydro pump move
  public void SetHydroPump(int HY){
    HydroPump = HY;
  }
  public int GetHydroPump(){
    return HydroPump;
  }
  //the getters and setters for the water Shuriken move
  public void SetWaterShuriken(int WS){
    WaterShuriken = WS;
  }
  public int GetWaterShuriken(){
    return WaterShuriken;
  }
  //getters and setters for the vortex move
  public void SetHydroVortex(int HV){
    HydroVortex = HV;
  }
  public int GetHydroVortex(){
    return HydroVortex;
  }
  // getters and setters for the water pulse move
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