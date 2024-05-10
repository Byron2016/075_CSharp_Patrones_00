using _075_CSharp_Patrones_00.models;

namespace _075_CSharp_Patrones_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu();
            }
            
        }
    }
}
