using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.BuffGODSet
{
	[AutoloadEquip(EquipType.Legs)]
	public class BuffGODLeggings : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100000;
			item.rare = 12;
			item.defense = 1894500;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Buff GOD Leggings");
      Tooltip.SetDefault("This is Buff GOD leg armor.\n25% Damage Reduction\nImmunity To Lava");
    }
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == mod.ItemType("BuffGODHelmet") && body.type == mod.ItemType("BuffGODBreastplate");
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
            player.AddBuff(BuffID.ObsidianSkin, 99999999);
            player.AddBuff(BuffID.WaterWalking, 99999999);
            player.endurance += 0.25f;
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
