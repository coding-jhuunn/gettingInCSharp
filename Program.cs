using System;

namespace MyApp
{
      class Wizard{
            public string uname ;
            public string magicName ;
            public int spellSlots;
            public float experience; 


            public Wizard(string _uname,string _magicName){
                uname = _uname;
                magicName= _magicName;
                spellSlots = 2;
                experience =0f;
            }
            public void introduce(){
                Console.WriteLine("Hello My name is "+ uname);
            }
            public void castMagic(){
                Console.WriteLine("I cast my "+ magicName +" to you");
            }
        }
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Wizard firstWizard = new Wizard("asd","asd");
          Wizard wizard01 = new Wizard("Leveticus","Hayaahh");
          Wizard wizard02 = new Wizard("Warlock","Rain of Shadows");
          wizard01.introduce();
          wizard01.castMagic();
          wizard02.introduce();
          wizard02.castMagic();
          Console.WriteLine(wizard02.experience);
          Console.ReadKey();
        }
    }
}