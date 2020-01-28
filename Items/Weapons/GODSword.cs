using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Weapons
{
	public class GODSword : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 50000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 75;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("GODSword");
      Tooltip.SetDefault("You're Lucky To Have ME.\nNice To Meet You.");
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
