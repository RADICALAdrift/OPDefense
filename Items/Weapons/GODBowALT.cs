using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace OPDefense.Items.Weapons
{
    public class GODBowALT : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 30000;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.knockBack = 15;
            item.value = 1000;
            item.rare = 7;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.useAmmo = mod.ItemType("Thor's Arrow");
			item.shoot = mod.ProjectileType("GODProjectile");
        }
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD's Bow(Special)");
      Tooltip.SetDefault("I'm Different\nI'm For The Cheaty People");
    }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 2);
            recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
