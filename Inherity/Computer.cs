namespace Inherity;

public class Computer
{

    public int Ram { get; set; }
    public  int Storage { get; set; }
    public string Keybord { get; set; }
    
     public Computer(int ram,int storage,string keybord){

              Ram = ram;
              Storage = storage;
              Keybord= keybord;

      }
      public void AddRam(int ram)
      {
          
            Ram = ram;
            System.Console.WriteLine(Ram);

      }
      public void  AddStorage(int storage)
      {
         Storage=storage;
         System.Console.WriteLine(Storage);
      }

      public Computer(){

      }


         
}
