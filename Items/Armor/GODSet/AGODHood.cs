using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.GODSet
{
	[AutoloadEquip(EquipType.Head)]
	public class AGODHood : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 1250;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD Hood");
      Tooltip.SetDefault("This is a GOD helmet.");
    }
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GODBreastplate") && legs.type == mod.ItemType("GODLeggings");
		}
		public override void UpdateArmorSet(Player player)
		{
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 5);
            recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();;
		}
	}
}
