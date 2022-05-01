using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL.Terraria;
using On.Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace BloupbloupMod.items
{
    public class BloupIngot : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Blue;
            item.maxStack = 99;
        }
    }
}
