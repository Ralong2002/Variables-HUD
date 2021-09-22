using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_HUD
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Command Souls";
            Console.WriteLine (name);
            Console.ReadKey(true);
            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");

            float Humanity;
            Humanity = 100.0f;
            int health;
            health = 100;
            int souls;
            souls = 0;
            
             
            

            

            Console.WriteLine("Player is in a Castle Ruin...");

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Player Killed Undead Shield Knight +35 Souls");
            Console.WriteLine("But Was Hit For 30 Health Points");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            health = health - 30;
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            ; souls = souls + 35;
            Console.WriteLine(souls);
            

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Killed Undead Knight +50 Souls");
            Console.WriteLine("Without Taking Damage ");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            souls = souls + 50;
            Console.WriteLine(souls);
            
            
            Console.ReadKey(true);
            
            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Died To OverGrown Drake - ");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            health = 0;
            Console.WriteLine("Current HP");
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            souls = 0;
            Console.WriteLine(souls);
            

            Console.ReadKey(true);
            
            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Respawned");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Humanity = Humanity - 33.3f;
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            health = 100; 
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            Console.WriteLine(souls);
            
            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Killed Undead Shield Knight +35 Souls");
            Console.WriteLine("But Was Hit For 30 HP");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            health = health - 30;
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            ; souls = souls + 35;
            Console.WriteLine(souls);

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Killed Undead Knight +50 Souls");
            Console.WriteLine("And Was Hit For 40 HP ");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            health = health - 40;
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            souls = souls + 50;
            Console.WriteLine(souls);

            Console.ReadKey(true);
            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Killed OverGrown Drake For +1500 Souls");
            Console.WriteLine("Restoring Humanity to 100%");
            Console.WriteLine("And Was Hit For 15 HP ");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Humanity = 100.0f;
            Console.WriteLine(Humanity);
            
            Console.WriteLine("Current HP");
            health = health - 15;
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            souls = souls + 1000;
            Console.WriteLine(souls);
            
            Console.ReadKey(true);
            
            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Found A Ring That Icreases Soul Gain By 2X ");

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");
            Console.WriteLine("Player Killed Undead Knight +50x2 Souls");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current Souls");
            souls = souls + 50 * 2; 
            Console.WriteLine(souls);
            Console.WriteLine("Current HP");
             
            Console.WriteLine(health);
            

            Console.ReadKey(true);

            Console.WriteLine(" ");
            Console.WriteLine("Events-------------------------------------------------------------------------------------------------Events");
            Console.WriteLine(" ");

            Console.WriteLine("Player Returned to Bonfire To Level Up Adaption For 1000 Souls");
            Console.WriteLine(" ");
            Console.WriteLine("HUD-------------------------------------------------------------------------------------------------HUD");
            Console.WriteLine(" ");
            Console.WriteLine("Current Humanity%");
            Console.WriteLine(Humanity);
            Console.WriteLine("Current HP");
            health = 100;
            Console.WriteLine(health);
            Console.WriteLine("Current Souls");
            souls = souls - 1000;
            Console.WriteLine(souls);


            Console.ReadKey(true);
        }
    }
}




