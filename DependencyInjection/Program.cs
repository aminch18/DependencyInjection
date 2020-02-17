using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor Injection
            var soldierOne = new ConstructorSoldier(new Gun());
            soldierOne.Shoot();

            //Property Injection => We can instance the object and then set the property.
            var soldierTwo = new PropertySoldier
            {
                _weapon = new ShotGun()
            };
            soldierTwo.Shoot();

            //Methon Injection
            var soldierThree = new MethodSoldier();
            soldierThree.SetDependency(new MachineGun());
            soldierThree.Shoot();

        }
    }

    #region Contracts = Definintion
    public interface IWeapon
    {
        void Shoot();
    }

    public interface IWeaponDependency
    {
        void SetDependency(IWeapon weapon);
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
    class ConstructorSoldier
    {
        IWeapon _weapon;

        public ConstructorSoldier(IWeapon weapon)
        {
            _weapon = weapon ?? throw new ArgumentNullException();
        }

        public void Shoot()
        {
            _weapon.Shoot();
        }
    }

    class PropertySoldier
    {
        public IWeapon _weapon { get; set; }

        public PropertySoldier()
        {

        }
        public void Shoot()
        {
            _weapon.Shoot();
        }
    }

    class MethodSoldier : IWeaponDependency
    {
        public IWeapon _weapon { get; set; }

        public MethodSoldier()
        {

        }
        public void Shoot()
        {
            _weapon.Shoot();
        }

        public void SetDependency(IWeapon weapon)
        {
            _weapon = weapon;
        }
    }
    #endregion
}
