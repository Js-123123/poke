using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class Fire : Pokemon{
//the pokemon stats
  private int BlazeKick; // thunder move 
  private int HeatWave;
  private int Inferno; 
  private int FlameWheel;  
  private int FirePunch; 
  private int FireBlast;  // trrop num
  
  public Fire(string a){
  
    
  }
// defalt contructer
  public Fire(){
    BlazeKick = 85;
    HeatWave = 95;
    Inferno = 100;
    FlameWheel = 60;
    FirePunch = 75;
    FireBlast = 110;
  }
  public override void Attacks(){
    string nAttack;
    int attackD;
    Random rnd = new Random();
    int AMnumber = rnd.Next(0, 6);
    if(AMnumber == 1){
    attackD = FlameWheel;
    nAttack = "Flame Wheel";
    Console.WriteLine($"{nAttack} did {attackD} damage!");

    }
    if(AMnumber == 2){
    nAttack = "Blaze Kick";
    attackD = BlazeKick;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 3){
       nAttack = "Heat Wave";
    attackD = HeatWave;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 4){
      nAttack = "Inferno";
    attackD = Inferno;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 5){
    nAttack = "Fire Punch";
    attackD = FirePunch;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }
    if(AMnumber == 6){
    nAttack = "Fire Blast";
    attackD = FireBlast;
    Console.WriteLine($"{nAttack} did {attackD} damage!");
    }




}
    //getter and setters
  public void SetBlazeKick(int BK){
    BlazeKick = BK;
  }
  public int GetBlazeKick(){
    return BlazeKick;
  } 
  public void SetHeatWave(int HW){
    HeatWave = HW;
  }
  public int GetHeatWave(){
    return HeatWave;
  }
  public void SetInferno(int I){
    Inferno = I;
  }
  public int GetInferno(){
    return Inferno;
  }
  public void SetFlameWheel(int FW){
    FlameWheel = FW;
  }
  public int GetFlameWheel(){
    return FlameWheel;
  }
  public void SetFirePunch(int FP){
    FirePunch = FP;
  }
  public int GetFirePunch(){
    return FirePunch;
  }
  public void SetFireBlast(int FB){
    FireBlast = FB;
  }
  public int GetFireBlast(){
    return FireBlast;
  }


  
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
}