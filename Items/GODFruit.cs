using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items
{
	public class GODFruit : ModItem
	{
		public override void SetDefaults()
        {
		item.width = 10;
		item.height = 14;
		item.useStyle = 4;
		item.useTime = 30;
		item.consumable = true;
		item.value = 10;
		item.rare = 3;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("God Fruit");
      Tooltip.SetDefault("Gives the User\n+100 HP");
    }
		public override void AddRecipes() //How to craft this item
		{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.Wood, 10); //you need 10 Wood
		recipe.AddTile(TileID.WorkBenches); //at work bench
		recipe.SetResult(this);
		recipe.AddRecipe();
		}
		public override bool UseItem(Player player)
		{
		player.statLifeMax += 100;
		return true;
		}
	}
}
