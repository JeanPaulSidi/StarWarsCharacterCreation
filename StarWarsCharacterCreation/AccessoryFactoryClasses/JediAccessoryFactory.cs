using StarWarsCharacterCreation.AccessoriesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacterCreation.AccessoryFactoryClasses
{
    public class JediAccessoryFactory : AccessoryFactory
    {
        public override Accessory CreateOutfit()
        {
            return (new JediOutfit());
        }

        public override Accessory CreateWeapon()
        {
            return (new JediWeapon());
        }
    }
}
