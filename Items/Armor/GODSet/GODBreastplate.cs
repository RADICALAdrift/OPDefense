using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.GODSet
{
	[AutoloadEquip(EquipType.Body)]
	public class GODBreastplate : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
            item.value = 10000;
			item.rare = 2;
			item.defense = 2500;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GOD Breastplate");
      Tooltip.SetDefault("This is a GOD Breastplate.\nImmunity to 'On Fire!'\n+20 max mana and +1 max minions");
    }
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 5);
            recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
