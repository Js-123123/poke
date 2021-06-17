using System;
/* Student Name: Josh santos
   Student ID: 18272
   Lesson: 7-07
   Date: 6/15/21
   
 create a program using Pokemon and  Inheritance 
*/
class Pokemon{
  private string trainer;//trainer name
  private string name;// Pokemon name
  private string pokeType;// pokeType
  private int level;// Pokemon level
  private int speed;// pokemon speed
  private int maxHP;// max hp
  private int curHP;
  private int currEvo;// current evolution
  private int maxEvo;// max evolution
  private char team;//team
//the pokemon stats
  public Pokemon(string tr, string n, string pT, int l, int s, int cH,int mH,  int cE, int mE, char te){
    trainer = tr;
    name = n;
    pokeType = pT;
    level = l;
    speed = s;
    curHP = cH;
    maxHP = mH;
    currEvo = cE;
    maxEvo = mE;
    team = te;
  }
//Tangela,Grass,87,60,65,1,2,C
//overloded constructer for video game class
  public Pokemon(String line){
    string[] fields = line.Split(",");
    name = fields[0];
    pokeType = fields[1];
    level = Convert.ToInt32(fields[2]);
    speed = Convert.ToInt32(fields[3]);
    curHP = Convert.ToInt32(fields[4]);
    maxHP = Convert.ToInt32(fields[5]);
    currEvo = Convert.ToInt32(fields[6]);
    maxEvo = Convert.ToInt32(fields[7]);
    team = Convert.ToChar(fields[8]);
  }
// defalt contructer
  public Pokemon(){
    name = "Emboar";
    pokeType = "Fire";
    level = 50;
    speed = 65;
    curHP = 123;
    maxHP = 123;
    currEvo = 1;
    maxEvo = 3;
    team = 'P';
  }

    //getter and setters
  public void SetTrainer(string tr){
    trainer = tr;
  }
  public string GetTrainer(){
    return trainer;
  }
  //setter and getter for the name
  public void SetName(string n){
    name = n;
  }
  public string GetName(){
    return name;
  }
  //setter and getter for pokemon type
  public void SetPokeType(string pT){
    pokeType = pT;
  }
  public string GetPokeType(){
    return pokeType;
  }
  //getter and getter for level
  public void SetLevel(int l){
    level = l;
  }
  public int GetLevel(){
    return level;
  }
  // getter and setter for speed
  public void SetSpeed(int s){
    speed = s;
  }
  public int GetSpeed(){
    return speed;
  }
  //getter and setter fir max hp
  public void SetMaxHP(int mH){
    maxHP = mH;
  }
  public int GetMaxHP(){
    return maxHP;
  }
  //getter and setter fir current hp
  public void SetCurHP(int cH){
    curHP = cH;
  }
  public int GetCurHP(){
    return curHP;
  }
  //
  //getter and setter for current evolution
  public void SetCurrEvo(int cE){
    currEvo = cE;
  }
  public int GetCurrEvo(){
    return currEvo;
  }
  //getter and setter for max evolution
  public void SetMaxEvo(int mE){
    maxEvo = mE;
  }
  public int GetMaxEvo(){
    return maxEvo;
  }
  // getter and setter for team
  public void SetTeam(char te){
    team = te;
  }
  public char GetTeam(){
    return team;
  }
  // set attacks
  // PEASE CHANGE LATER//////////////////////
    public virtual void Attacks(){
      Console.WriteLine("TEST");
    }
  // the to string
  public override string ToString(){
    string msg = string.Format($"{name, -10}  Type: {pokeType, -12}   Level: {level, 3} Speed:{speed, 4}  HP: {curHP}/{maxHP}");
    return msg;
  }
  public void Revive(){
    curHP = maxHP;
  }
  
}