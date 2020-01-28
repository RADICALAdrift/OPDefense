using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OPDefense.Tiles
{
    public class CraytaniumOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("CraytaniumOre");   //put your CustomBlock name
            AddMapEntry(new Color(0, 191, 255));
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 000.0f;
            g = 191.0f;
            b = 255.0f;
        }
    }
}