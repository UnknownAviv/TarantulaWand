using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using TarantulaWand.Projectiles;

namespace TarantulaWand.items
{
    public class TarantulaWandWeapon : ModItem
    {
        public override string Texture => "TarantulaWand/Items/Weapons/TarantulaWandWeapon";

        public override void SetStaticDefaults()
        {
            ItemID.Sets.LockOnIgnoresCollision[Item.type] = true;
        }


        public override void SetDefaults()
        {
            Item.damage = 24;
            Item.knockBack = 1f;
            Item.mana = 10;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Splash;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Magic;
            Item.shoot = ModContent.ProjectileType<TarantulaWandProjectile>();
            Item.shootSpeed = 7f;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.SetWeaponValues(25, 6, 32);
        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}
