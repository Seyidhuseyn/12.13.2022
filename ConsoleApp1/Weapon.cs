using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Weapon
    {
		private byte _bulletCapacity; /*daragin gulle tutumu*/
        private byte _numberBullets; /*daragdaki gulle sayi*/
        private byte _chargeSecond; /*daragin bosalma saniyesi*/
        private string _automatic; /*atis modu (avtomatik)*/

        public byte BulletCapacity
		{
			get { return _bulletCapacity; }
			set { _bulletCapacity = value; }
		}
		public byte NumberBullets
		{
			get { return _numberBullets; }
			set { _numberBullets = value; }
		}
		public byte ChargeSecond
		{
			get { return _chargeSecond; }
			set { _chargeSecond = value; }
		}
		public string Automatic
		{
			get { return _automatic; }
			set { _automatic = value; }
		}

		public Weapon(byte bulletCapacity, byte numberBullets, byte chargeSecond, string automatic)
		{
			BulletCapacity = bulletCapacity;
			NumberBullets = numberBullets;
			ChargeSecond = chargeSecond;
			Automatic = automatic;
		}
        byte numberBullets = 70;
        byte chargeSecond = 2;
        byte numberBullet = 20;
		private int bulletCapacity;

        public void Shoot()
		{
			Console.WriteLine("ates acildi.");
		}
		public void Fire()
		{
			Console.WriteLine($"daraqdaki gullenin nece saniyede bitdiyini gosterir: {numberBullets / chargeSecond}");
		}
		public void GetRemainBulletCount()
		{
			Console.WriteLine($"daragin tam dolmasi ucun lazim olan gullenin sayi: {bulletCapacity - numberBullets}");
		}
		public void Reload()
		{

			Console.WriteLine($"daragi yeniden doldurur: {bulletCapacity - numberBullets}");
		}
		public void ChangeFireMode()
		{

		}

    }
}
