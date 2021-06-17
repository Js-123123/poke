using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/14/21
   
 create a program using Pokemon and  Inheritance 
*/

class Electric : Pokemon{
//the pokemon stats
  private int Thunder; // thunder move 
  private int BoltStrike;
  private int MaxLightning ; 
  private int Overdrive;  
  private int ParabolicCharge;
  private int Electrify;  // trrop num
  
  public Electric(string a){
  
    
  }
// defalt contructer
  public Electric(){
    Thunder = 110;
    BoltStrike = 130;
    MaxLightning = 140;
    Overdrive = 80;
    ParabolicCharge = 65;
    Electrify = 45;
  }
  public override void Attacks(){
    string nAttack;
    int attackD;
    Random rnd = new Random();
    int AMnumber = rnd.Next(0, 6);
    if(AMnumber == 1){
    attackD = Thunder;
   
    }
    if(AMnumber == 2){
    attackD = BoltStrike;
   
 
    }
    if(AMnumber == 3){
   
    attackD = MaxLightning;
  
    }
    if(AMnumber == 4){
   
    attackD = Overdrive;
 
    }
    if(AMnumber == 5){
  
    attackD = ParabolicCharge;
   
    }
    if(AMnumber == 6){
  
    attackD = Electrify;
 
    }
    Console.WriteLine($"{nAttack} did {attackD} damage!");



}
    //getter and setters
  public void SetThunder(int T){
    Thunder = T;
  }
  public int GetThunder(){
    return Thunder;
  } 
  public void SetBoltStrike(int B){
    BoltStrike = B;
  }
  public int GetBoltStrike(){
    return BoltStrike;
  }
  public void SetMaxLightning(int ML){
    MaxLightning = ML;
  }
  public int GetMaxLightning(){
    return MaxLightning;
  }
  public void SetOverdrive(int O){
    Overdrive = O;
  }
  public int GetOverdrive(){
    return Overdrive;
  }
  public void SetParabolicCharge(int PC){
    ParabolicCharge = PC;
  }
  public int GetParabolicCharge(){
    return ParabolicCharge;
  }
  public void SetElectrify(int SE){
    Electrify = SE;
  }
  public int GetElectrify(){
    return Electrify;
  }



  
  // the to string
   public override string ToString(){
    string msg = string.Format($"{GetName(), 10}  Type: {GetPokeType(), 12}   Level: {GetLevel(), 3} Speed:{GetSpeed(), 4}  HP: {GetCurHP()}/{GetMaxHP()}");
    return msg;
  }
  
}