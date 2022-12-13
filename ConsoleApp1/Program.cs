namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(50, 25, 2, "automatic");
            

            repeat:
            Console.WriteLine("Reqem daxil edin:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0 : 
                    Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün");
                    goto repeat;
                    break;
                case 1 : 
                    Console.WriteLine("Shoot metodu ucun");
                    weapon.Shoot();
                    goto repeat;
                    break;
                case 2: 
                    Console.WriteLine("Fire metodu üçün");
                    weapon.Fire();
                    goto repeat;
                    break;
                case 3: 
                    Console.WriteLine("GetRemainBulletCount metodu üçün"); 
                    weapon.GetRemainBulletCount();
                    goto repeat;
                    break;
                case 4: 
                    Console.WriteLine("Reload metodu üçün"); 
                    weapon.Reload();
                    goto repeat;
                    break;
                case 5: 
                    Console.WriteLine("ChangeFireMode metodu üçün");
                    weapon.ChangeFireMode();
                    goto repeat;
                    break;
                case 6: 
                    Console.WriteLine(" Proqramdan dayandırmaq üçün");
                    goto repeat;
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    goto repeat;
                    break;
            }
        }
    }
}