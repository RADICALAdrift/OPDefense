using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OPDefense.Items.Weapons
{
    public class GODKnife : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 12000;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 15;       //this is how fast you use the item
            item.useAnimation = 15;   //this is how fast the animation when the item is used
            item.useStyle = 1;      
            item.knockBack = 75;
            item.value = 10;
            item.rare = 1;
            item.UseSound = SoundID.Item18;
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("GODKnifeP");  //javelin projectile
            item.shootSpeed = 22.3f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;          
        }
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD Knife");
      Tooltip.SetDefault("");
    }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 1);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
