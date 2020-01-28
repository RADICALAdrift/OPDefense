using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace OPDefense.Items.Weapons
{
    public class GODYoyo : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Terrarian);
            item.damage = 50000;                            
            item.value = 10000000;
            item.rare = 3;
            item.knockBack = 250;
            item.channel = true;
            item.useStyle = 5;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType("GODYoyoP");           
        }
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD's Yoyo");
      Tooltip.SetDefault("");
    }
        public override void AddRecipes()
        {                                                   //How to craft this item
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 1);
            recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
