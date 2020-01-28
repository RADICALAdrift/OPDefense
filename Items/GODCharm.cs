using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items
{
    public class GODCharm : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 10;
            item.rare = 3;
            item.accessory = true;
        }
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("God Charm");
      Tooltip.SetDefault("Gives the User\n75 Life/80 Mana Regen");
    }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HeartofRa");
			recipe.AddIngredient(null, "EyeofHorus");
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateEquip(Player player)
        {
            player.lifeRegen = 25;
			player.manaRegen = 80;
        }
    }
}
