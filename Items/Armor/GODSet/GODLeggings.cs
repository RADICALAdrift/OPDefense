using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.GODSet
{
	[AutoloadEquip(EquipType.Legs)]
	public class GODLeggings : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 1500;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD Leggings");
      Tooltip.SetDefault("This is GOD leg armor.\n5% increased movement speed");
    }
		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 5);
            recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
