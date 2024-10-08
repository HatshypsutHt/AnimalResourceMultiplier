using System.Collections.Generic;
using Oxide.Core;
using Oxide.Core.Plugins;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("AnimalResourceMultiplier", "Hatshypsut", "1.0.0")]
    [Description("Increases the resources gathered from animals by 10 times")]

    public class AnimalResourceMultiplier : RustPlugin
    {
        // Множник для добування ресурсів з тварин
        private const float Multiplier = 10.0f;

        private void OnDispenserGather(ResourceDispenser dispenser, BaseEntity entity, Item item)
        {
            // Перевіряємо, чи ресурс, який видобувається, відноситься до тварин
            if (item.info.shortname == "bone.fragments" || item.info.shortname == "leather" ||
                item.info.shortname == "cloth" || item.info.shortname == "fat.animal" || item.info.shortname == "meat.bear" ||
                item.info.shortname == "meat.wolf" || item.info.shortname == "meat.boar" || item.info.shortname == "meat.deer")
            {
                // Збільшуємо кількість ресурсу, який гравець отримує
                var originalAmount = item.amount;
                item.amount = Mathf.CeilToInt(originalAmount * Multiplier);
            }
        }
    }
}
