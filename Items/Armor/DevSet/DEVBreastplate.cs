using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.DevSet
{
	[AutoloadEquip(EquipType.Body)]
	public class DEVBreastplate : ModItem
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
      DisplayName.SetDefault("Dev Breastplate");
      Tooltip.SetDefault("This is a Dev Breastplate.\nImmunity to 'On Fire!'\n+200 max mana and +1 max minions");
    }
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20000;
			player.maxMinions++;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 10);
            recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
