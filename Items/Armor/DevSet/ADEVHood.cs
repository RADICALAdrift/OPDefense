using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.DevSet
{
	[AutoloadEquip(EquipType.Head)]
	public class ADEVHood : ModItem
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
      DisplayName.SetDefault("Dev Hood");
      Tooltip.SetDefault("This is a Dev Hood.");
    }
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DEVBreastplate") && legs.type == mod.ItemType("DEVLeggings");
		}
		public override void UpdateArmorSet(Player player)
		{
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 10);
            recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
