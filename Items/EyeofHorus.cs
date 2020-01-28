using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items
{
    public class EyeofHorus : ModItem
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
      DisplayName.SetDefault("Eye of Horus");
      Tooltip.SetDefault("Gives the User\n+75 mana regen.");
    }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateEquip(Player player)
        {
            player.manaRegen = 75;
        }
    }
}
