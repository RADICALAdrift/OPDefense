using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Weapons
{
	public class MrTango : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 500000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 75;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Mr Tango");
      Tooltip.SetDefault("I'm Beautiful I'm Beautiful It's True.\nMr T. Snickers Get Some Nuts");
    }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CraytaniumBar", 25);
            recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
