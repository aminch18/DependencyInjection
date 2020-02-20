using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Entities
{
    public class Gun : IWeapon
    {
        public Gun()
        {

        }

        public void Shoot()
            => Console.WriteLine("Bang! Bang!");
        
    }
}
