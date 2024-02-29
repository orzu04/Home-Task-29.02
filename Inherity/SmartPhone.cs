namespace Inherity;

public class SmartPhone:Computer

{

  public int NumberOfSelfies { get; set; }
  
     public SmartPhone(int ram,int storage,string keybord,int numberOfSelfies) : base (ram,storage,keybord)
     {
               NumberOfSelfies = numberOfSelfies;


     }

     public void  TakeSelfies(int selfies)
     {
        NumberOfSelfies = selfies;
        System.Console.WriteLine($"In Telephone Kuvvai {NumberOfSelfies} ro Dorad");
        var s = Convert.ToInt32(Console.ReadLine());
        if(s>NumberOfSelfies)
        {
            System.Console.WriteLine($"Lutfan yagon chiro toza namoed");
        }
     }
     




}
