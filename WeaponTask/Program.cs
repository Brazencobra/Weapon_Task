using System.Net;
using WeaponTask.Models;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(30, 15, 5, "tek");
            bool respond = true;
            do
            {
                Console.WriteLine(" - - - - - - - - - - - - - ");
                Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün");
                Console.WriteLine(" - - - - - - - - - - - - - ");
                byte input = Convert.ToByte(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        Console.WriteLine(weapon.ToString());
                        break;
                    case 1:
                        weapon.Shoot();
                        Console.WriteLine($"Bir defe ates edildi qalan gulle sayi : {weapon.BulletNumber}");
                        break;
                    case 2:
                        weapon.Fire();
                        Console.WriteLine("Butun gulleler ateslendi Reload etmek isteyirsinizse 4 daxil edin");
                        break;
                    case 3:
                        Console.WriteLine("Sizin daraginizin tam dolmasi ucun lazim olan gulle miqdari : " + weapon.GetRemainBulletCount());
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        Console.WriteLine("Indiki silah modunuz : " + weapon.ShootMode);
                        weapon.ChangeFireMode();
                        Console.WriteLine("Silah modunuz deyisdirildi : " + weapon.ShootMode);
                        break;
                    case 6:
                        respond = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis daxil edilme");
                        break;
                }
            } while (respond);
        }
    }
}