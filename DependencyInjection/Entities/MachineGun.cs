using DependencyInjection.Contracts;
using System;

namespace DependencyInjection.Entities
{
    public class MachineGun : IWeapon
    {
        public MachineGun()
        {

        }

        public void Shoot()
            => Console.WriteLine("Ta-ta-ta-ta-ta!");
        
    }
}
