using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier(new Gun());
            soldier.Shoot();
        }
    }

    #region Contracts = Definintion
    public interface IWeapon
    {
        void Shoot();
    }
    #endregion


    #region Classes = Implementation
    public class Gun : IWeapon
    {
        public Gun()
        {

        }

        public void Shoot()
        {
            Console.WriteLine("Bang! Bang!");
        }
    }

    public class MachineGun : IWeapon
    {
        public MachineGun()
        {

        }

        public void Shoot()
        {
            Console.WriteLine("Ta-ta-ta-ta-ta!");
        }
    }

    class ShotGun : IWeapon
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

    #region Classes = Dependencies consumer
    class Soldier
    {
        IWeapon _weapon;

        public Soldier(IWeapon weapon)
        {
            _weapon = weapon ?? throw new ArgumentNullException();
        }

        public void Shoot()
        {
            _weapon.Shoot();
        }
    }
    #endregion
}
