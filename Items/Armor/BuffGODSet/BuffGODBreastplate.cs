using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Armor.BuffGODSet
{
	[AutoloadEquip(EquipType.Body)]
	public class BuffGODBreastplate : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
            item.value = 100000;
			item.rare = 12;
			item.defense = 2850500;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Buff GOD Breastplate");
      Tooltip.SetDefault("This is a Buff GOD Breastplate.\n40% Damage Reduction");
    }
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == mod.ItemType("BuffGODHelmet") && legs.type == mod.ItemType("BuffGODLeggings");
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
            player.noKnockback = true;
            player.AddBuff(BuffID.PaladinsShield, 99999999);
            player.endurance += 0.40f;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.OgreSpit] = true; //Problem One, Is Oozed
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.Horrified] = true;
            player.buffImmune[BuffID.TheTongue] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Wet] = true;
            player.buffImmune[BuffID.Webbed] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.VortexDebuff] = true; //Problem One, Is Distorted I Think
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.Rabies] = true; //Problem One, Is Feral Bite
            player.buffImmune[BuffID.MoonLeech] = true; //Problem One, Is Moon Bite
            player.buffImmune[BuffID.ManaSickness] = true;
            player.buffImmune[BuffID.PotionSickness] = true;
            player.buffImmune[BuffID.ChaosState] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Tipsy] = true;
            player.buffImmune[BuffID.Stinky] = true;
            player.buffImmune[BuffID.WaterCandle] = true;
            player.buffImmune[BuffID.WindPushed] = true;
            //player.buffImmune[BuffID.CreativeShock] = true; //Problem One, Is Event Based
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Midas] = true;
            player.buffImmune[BuffID.Oiled] = true;
            player.buffImmune[BuffID.Slimed] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
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
