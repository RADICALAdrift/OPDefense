using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPDefense.Projectiles
{
    public class GODYoyoP : ModProjectile
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GOD's Yoyo");
		}
		public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Terrarian);
            projectile.penetrate = 5;  
            projectile.width = 22;
            projectile.height = 22;
        }
    }
}
