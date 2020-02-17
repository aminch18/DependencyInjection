using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun = new Gun();
            var shotGun = new ShotGun();
            var machineGun = new MachineGun();

            gun.Shoot();
            shotGun.Shoot();
            machineGun.Shoot();
        }
    }

    #region Classes!
    public class Gun
    {
        public Gun()
        {

        }

        public void Shoot()
        {
            Console.WriteLine("Bang! Bang!");
        }
    }

    public class MachineGun
    {
        public MachineGun()
        {

        }

        public void Shoot()
        {
            Console.WriteLine("Ta-ta-ta-ta-ta!");
        }
    }

    class ShotGun
    {
        public ShotGun()
        {
        }

        public void Shoot()
        {
            Console.WriteLine("Puuuuuuum!");
        }
    }

    #endregion
}
