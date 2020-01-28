using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.BuffGODSet
{
	[AutoloadEquip(EquipType.Head)]
	public class ABuffGODHelmet : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100000;
			item.rare = 12;
			item.defense = 1755000;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Buff GOD Helmet");
      Tooltip.SetDefault("This is a Buff GOD helmet.\n35% Damage Reduction");
    }
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("BuffGODBreastplate") && legs.type == mod.ItemType("BuffGODLeggings");
		}
        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 0.8f;
            player.thrownDamage *= 0.8f;
            player.rangedDamage *= 0.8f;
            player.magicDamage *= 0.8f;
            player.minionDamage *= 0.8f;
        }
        public override void UpdateEquip(Player player)
        {
            player.gravControl = true;
            player.endurance += 0.35f;
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
