using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace Crimo.Items.Ammo
{
	public class ColorfulRegularGunBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("五彩缤纷的子弹");
			Tooltip.SetDefault("五彩缤纷的普通枪的子弹"); // The item's description, can be set to whatever you want.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() 
		{
			Item.damage = 12; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shootSpeed = 16f; // The speed of the projectile.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}
	    
		public override void AddRecipes()//合成表
        {
            Recipe recipe = CreateRecipe(5);//开头
            recipe.AddIngredient(ItemID.IronBar, 1);//需要的物品
			recipe.AddIngredient(ItemID.RainbowDye, 1);
            recipe.AddTile(TileID.WorkBenches);//需要的合成站
            recipe.Register();//结束
		}
	}
}
