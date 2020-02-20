using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Entities
{
    public class ShotGun : IWeapon
    {
        public ShotGun()
        {
        }

        public void Shoot()
            => Console.WriteLine("Puuuuuuum!");
        
    }
}
