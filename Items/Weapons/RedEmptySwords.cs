using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

using Crimo.Projectiles;//使用弹幕库

namespace Crimo.Items.Weapons//命名空间
{
    public class RedEmptySwords : ModItem//物品类型
    {
        public override void SetStaticDefaults()//基本属性
        {
            DisplayName.SetDefault("红空刃");//名字
            Tooltip.SetDefault("他有什么用呢？");//介绍
            
            Item.maxStack = 1;//堆叠数
        }

        public override void SetDefaults()//特殊属性
        {
            Item.width = 80;//物品宽度
            Item.height = 80;//物品高度
            Item.value = Item.buyPrice(gold: 10);//售价

            Item.useStyle = ItemUseStyleID.Swing;//怎么用
            Item.useTime = 5;//使用时间
            Item.useAnimation = 5;//另一个使用时间
            Item.autoReuse = true;//连续使用？
            Item.useTurn = true;//使用时可以转身？
            Item.UseSound = SoundID.Item1;//使用音效

            Item.DamageType = DamageClass.Melee;//伤害类型
            Item.damage = 2000;//伤害
            Item.scale = 1.5f;//伤害范围
            Item.knockBack = 0.5f;//击退
            Item.crit = 6;//暴击率

            Item.accessory = false;//饰品？
            Item.rare = 8;//稀有度
        }

        public override void AddRecipes()//合成表
        {
            Recipe recipe = CreateRecipe();//开头
            recipe.AddIngredient(ItemID.AdamantiteBar, 2);//需要的物品
            recipe.AddIngredient(ItemID.CrimtaneBar, 2);
            recipe.AddIngredient(ItemID.PalladiumBar, 2);
            recipe.AddIngredient(ItemID.HellstoneBar, 2);
            recipe.AddTile(TileID.WorkBenches);//需要的合成站
            recipe.Register();//结束
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) //效果对象
        {
            target.AddBuff(BuffID.OnFire, 600);//10秒的着火效果
        }

        public override void MeleeEffects(Player player, Rectangle hitbox) //扬起灰尘
        {
			if (Main.rand.NextBool(3)) 
            {
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.Sparkle>());
			}
        }
    }
}