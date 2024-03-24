using System;

namespace MyApp
{
    
    internal class Program
    {
      

        static void Main(string[] args)
        {
            int heroLifePoint =10;
            int monsterLifePoint = 10;
            Random ran = new Random();
           
            while(heroLifePoint >= 0 || monsterLifePoint>=0){
              Console.WriteLine("The Hero attacks");
              monsterLifePoint -= ran.Next(1,10);
              Console.Write("The Dragon life point is ");

              Console.WriteLine(monsterLifePoint);
              if(monsterLifePoint>0){
              Console.WriteLine("The Dragon attack");
                heroLifePoint-=ran.Next(1,10);
              Console.Write("The hero life point is ");

                Console.WriteLine(heroLifePoint);
              }
              if(heroLifePoint <0){
                Console.WriteLine("The Dragon wins");
                break;
              }
                 if(monsterLifePoint <0){
                Console.WriteLine("The hero wins");
                break;
              }
            }



         

           
            Console.ReadLine();


        }
    }
}