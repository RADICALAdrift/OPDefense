using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace OPDefense.Projectiles
{
    public class GODKnifeP : ModProjectile
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GOD Knife");
		}
		public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.aiStyle = 2;
            projectile.thrown = true;
            projectile.penetrate = 2;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            aiType = ProjectileID.ThrowingKnife;
        }
        public override void AI()
        {            
                projectile.ai[0] += 0.999f;
            if (projectile.ai[0] >= 500f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 0.99f;    // projectile velocity
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                           // sound that the projectile make when hiting the terrain
            {
                projectile.Kill();
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10); 
				Main.PlaySound(2, Style: mod.GetSoundSlot(SoundType.Item, "Sounds/Item/Wooo"));
            }
            return false;
        }
    }
}
