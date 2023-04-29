using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace Crimo.Items.Weapons//命名空间
{
    public class Brick : ModItem//物品类型
    {
        public override void SetStaticDefaults()//基本属性
        {
            DisplayName.SetDefault("板砖");//名字
            Tooltip.SetDefault("子曰：“打架用砖乎，不亦说乎。”");//介绍
            
            Item.maxStack = 1;//堆叠数
        }

        public override void SetDefaults()//特殊属性
        {
            Item.width = 80;//物品宽度
            Item.height = 40;//物品高度
            Item.value = 75000;//售价

            Item.useStyle = ItemUseStyleID.Swing;//怎么用
            Item.useTime = 10;//使用时间
            Item.useAnimation = 10;//另一个使用时间
            Item.autoReuse = true;//连续使用？
            Item.useTurn = true;//使用时可以转身？
            Item.UseSound = SoundID.Item1;//使用音效

            Item.DamageType = DamageClass.Melee;//伤害类型
            Item.damage = 100000;//伤害
            Item.scale = 1.5f;//伤害范围
            Item.knockBack = 0f;//击退
            Item.crit = 50;//暴击率

            Item.accessory = false;//饰品？
            Item.rare = 10;//稀有度
        }

        public override void AddRecipes()//合成表
        {
            Recipe recipe = CreateRecipe();//开头
            recipe.AddIngredient(ItemID.ClayBlock, 6);//需要的物品
            recipe.AddTile(TileID.WorkBenches);//需要的合成站
            recipe.Register();//结束
        }
    }
}