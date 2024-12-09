using StarWarsCharacterCreation.AccessoriesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacterCreation.AccessoryFactoryClasses
{
    public abstract class AccessoryFactory
    {
        public abstract Accessory CreateWeapon();
        public abstract Accessory CreateOutfit();

    }
}
