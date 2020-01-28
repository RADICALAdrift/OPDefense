using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Items.Weapons
{
    public class DualUseWeapon : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 50000;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100;
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana to Life Blade");
            Tooltip.SetDefault("Incresed Damage and Transorm Mana to Life with right click.");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CraytaniumBar", 50);
            recipe.AddTile(Terraria.ID.TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                item.useTime = 20;
                item.useAnimation = 20;
                item.damage = 52;
                item.UseSound = SoundID.Item4;
                if (player.statMana >= 35)             //when the player has 35+ mana he can use this item
                {
                    player.statMana -= 35;                //when you use the item use 35 mana
                    player.statLife += 35;                //when tou use the item gives you 35 life
                }
                else
                {
                    return false;                    //this make that when you have 0 mana you cant use the item
                }
            }
            else
            {
                item.useTime = 30;
                item.useAnimation = 30;
                item.damage = 50000;
                item.UseSound = SoundID.Item1;
            }
            return base.CanUseItem(player);
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (player.altFunctionUse == 2)          //here you see an example of how to add a buff when you hit a npc with the right click attack
            {
                target.AddBuff(BuffID.Ichor, 60);
            }
            else
            {             //buff when you hit a npc with lift click
                target.AddBuff(BuffID.OnFire, 60);
            }
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                if (player.altFunctionUse == 2)       //this is the melee effenct when you use the right click
                {
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169, 0f, 0f, 100, default(Color), 2f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity.X += player.direction * 2f;
                    Main.dust[dust].velocity.Y += 0.2f;
                }
                else
                {                                            //and this is the melee effect when you use left click
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
                    Main.dust[dust].noGravity = true;
                }
            }
        }


    }
}