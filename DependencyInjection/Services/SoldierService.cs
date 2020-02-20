using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection.Services
{
    class SoldierService : ISoldierService
    {
        public IEnumerable<IWeapon> _weapons;

        public SoldierService(IEnumerable<IWeapon> weapons)
        {
            _weapons = weapons ?? throw new ArgumentNullException();
        }

        public void Shoot()
        {
            _weapons.ToList().ForEach(weapon => weapon.Shoot());
        }
    }
}
