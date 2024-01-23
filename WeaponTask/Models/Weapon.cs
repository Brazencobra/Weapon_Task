using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WeaponTask.Models
{
    internal class Weapon
    {
        private int _bulletCapacity;
        private int _bulletNumber;
        private int _endSecond;
        private string _shootMood = "tekli";

        public int BulletCapacity 
        {
            get => _bulletCapacity;
            set
            {
                if (value>0 && value <= 50)
                {
                    _bulletCapacity = value;
                }
            }
        }
        public int BulletNumber 
        {
            get => _bulletNumber;
            set
            {
                if (value<=_bulletCapacity && value>= 0)
                {
                    _bulletNumber = value;
                }
            }
        }
        public int EndSecond 
        {
            get => _endSecond;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _endSecond = value;
                }
            } 
        }
        public string ShootMode 
        {
            get => _shootMood;
            set
            {
                if (value == "tek" || value == "avto")
                {
                    _shootMood = value;
                }
            }
        }

        public Weapon(int bulletcapacity,int bulletnumber,int endsecond,string shootmood)
        {
            BulletCapacity = bulletcapacity;
            BulletNumber = bulletnumber;
            EndSecond = endsecond;
            ShootMode = shootmood;
        }

        public int Shoot()
        {
            if (BulletNumber > 0)
            {
                BulletNumber--;
                return BulletNumber;
            }
            return 0;
        }
        
        public int Fire()
        {
            if (ShootMode == "tek")
            {
                int lastnumber = BulletNumber / 2;
                BulletNumber = 0;
                return lastnumber;
            }
            int lastnumber1 = BulletNumber / 3;
            BulletNumber = 0;
            return lastnumber1;
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletNumber;
        }

        public void Reload()
        {
            if (BulletNumber == BulletCapacity)Console.WriteLine("Sizin daraginiz doludur Reload olunmadi");
            else
            {
                int needammo = 0;
                needammo = BulletCapacity - BulletNumber;
                Console.WriteLine("Sizin daraga " + needammo + " gulle elave edilerek " + BulletCapacity + " oldu");
                BulletNumber += needammo; 

            }
        }

        public void ChangeFireMode()
        {
            if (ShootMode == "tek") ShootMode = "avto";
            else
            {
                ShootMode = "tek";
            }
        }

        public override string ToString()
        {
            return $"Silah maqazin tutumu - {BulletCapacity}\nMaqazinde olan gulle sayi - {BulletNumber}\nGullelerin bitme muddeti - {EndSecond}\nSilahin atis modu - {ShootMode}";
        }
    }
}
