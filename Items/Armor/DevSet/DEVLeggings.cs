using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.DevSet
{
	[AutoloadEquip(EquipType.Legs)]
	public class DEVLeggings : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000000;
			item.rare = 11;
			item.defense = 100000000;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Dev Leggings");
      Tooltip.SetDefault("This is a Dev Leggings.\nBetter increased movement speed");
    }
		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 99999999999999999999999999999999999999.0f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 10);
            recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
