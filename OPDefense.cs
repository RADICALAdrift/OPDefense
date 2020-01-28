using Terraria.ModLoader;

namespace OPDefense
{
	class OPDefense : Mod
	{
		public OPDefense()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
