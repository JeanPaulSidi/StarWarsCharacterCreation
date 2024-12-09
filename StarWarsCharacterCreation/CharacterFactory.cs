using StarWarsCharacterCreation.AccessoriesClasses;
using StarWarsCharacterCreation.AccessoryFactoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsCharacterCreation
{
    public static class CharacterFactory
    {
        private static Accessory Outfit;
        private static Accessory Weapon;

        private static string GetCharacterAccessory(AccessoryFactory AccessoryFactory) 
        {
            string Message = string.Empty;

            Outfit = AccessoryFactory.CreateOutfit();
            Weapon = AccessoryFactory.CreateWeapon();

            Message += "Weapon: " + Weapon.ShowStyle() + "\n\n";
            Message += "Outfit: " + Outfit.ShowStyle();

            return Message;

        }

        public static string CreateJediCharacter() 
        {
            string Message = string.Empty;

            Message = GetCharacterAccessory(new JediAccessoryFactory());

            return Message;

        }

        public static string CreateSithCharacter() 
        {
            string Message = string.Empty;

            Message = GetCharacterAccessory(new SithAccessoryFactory());

            return Message;
        }
    }
}
