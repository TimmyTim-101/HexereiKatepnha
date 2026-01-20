using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class ArtifactConstants
{
    public static readonly ArtifactSetModel _501 = new()
    {
        Rid = 501,
        Vid = 10010,
        Name = "冒险家",
        RarityList = [1, 2, 3],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "冒险家头带" }, { 2, "冒险家尾羽" }, { 1, "冒险家之花" }, { 3, "冒险家怀表" }, { 4, "冒险家金杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10010_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10010_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10010_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10010_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10010_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "生命值上限提高1000点。" },
            { 4, "开启各类宝箱后的5秒内，持续恢复30%生命值。" }
        }
    };

    public static readonly ArtifactSetModel _502 = new()
    {
        Rid = 502,
        Vid = 10011,
        Name = "幸运儿",
        RarityList = [1, 2, 3],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "幸运儿银冠" }, { 2, "幸运儿鹰羽" }, { 1, "幸运儿绿花" }, { 3, "幸运儿沙漏" }, { 4, "幸运儿之杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10011_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10011_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10011_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10011_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10011_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "防御力提高100点。" },
            { 4, "拾取摩拉时，恢复300点生命值。" }
        }
    };

    public static readonly ArtifactSetModel _503 = new()
    {
        Rid = 503,
        Vid = 10013,
        Name = "游医",
        RarityList = [1, 2, 3],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "游医的方巾" }, { 2, "游医的枭羽" }, { 1, "游医的银莲" }, { 3, "游医的怀钟" }, { 4, "游医的药壶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10013_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10013_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10013_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10013_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10013_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "角色受到的治疗效果提高20%。" },
            { 4, "施放元素爆发时，恢复20%生命值。" }
        }
    };

    public static readonly ArtifactSetModel _504 = new()
    {
        Rid = 504,
        Vid = 10001,
        Name = "行者之心",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "感别之冠" }, { 2, "归乡之羽" }, { 1, "故人之心" }, { 3, "逐光之石" }, { 4, "异国之盏" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10001_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10001_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10001_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10001_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10001_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "重击的暴击率提升30%。" }
        }
    };

    public static readonly ArtifactSetModel _505 = new()
    {
        Rid = 505,
        Vid = 10004,
        Name = "奇迹",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "奇迹耳坠" }, { 2, "奇迹之羽" }, { 1, "奇迹之花" }, { 3, "奇迹之沙" }, { 4, "奇迹之杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10004_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10004_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10004_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10004_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10004_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "所有元素抗性提高20%。" },
            { 4, "受到某个元素类型的伤害后，相应的抗性提升30%，持续10秒。该效果每10秒只能触发一次。" }
        }
    };

    public static readonly ArtifactSetModel _506 = new()
    {
        Rid = 506,
        Vid = 10005,
        Name = "战狂",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "战狂的鬼面" }, { 2, "战狂的翎羽" }, { 1, "战狂的蔷薇" }, { 3, "战狂的时计" }, { 4, "战狂的骨杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10005_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10005_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10005_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10005_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10005_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "暴击率提高12%。" },
            { 4, "生命值低于70%时，暴击率额外提升24%。" }
        }
    };

    public static readonly ArtifactSetModel _507 = new()
    {
        Rid = 507,
        Vid = 10007,
        Name = "教官",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "教官的帽子" }, { 2, "教官的羽饰" }, { 1, "教官的胸花" }, { 3, "教官的怀表" }, { 4, "教官的茶杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10007_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10007_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10007_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10007_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10007_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "触发元素反应后，队伍中所有角色的元素精通提高120点，持续8秒。" }
        }
    };

    public static readonly ArtifactSetModel _508 = new()
    {
        Rid = 508,
        Vid = 10009,
        Name = "流放者",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "流放者头冠" }, { 2, "流放者之羽" }, { 1, "流放者之花" }, { 3, "流放者怀表" }, { 4, "流放者之杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10009_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10009_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10009_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10009_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10009_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素充能效率提高20%。" },
            { 4, "施放元素爆发后，每2秒为队伍中所有角色（不包括自己）恢复2点元素能量。该效果持续6秒，无法叠加。" }
        }
    };

    public static readonly ArtifactSetModel _509 = new()
    {
        Rid = 509,
        Vid = 10003,
        Name = "守护之心",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "守护束带" }, { 2, "守护徽印" }, { 1, "守护之花" }, { 3, "守护座钟" }, { 4, "守护之皿" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10003_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10003_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10003_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10003_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10003_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "防御力提高30%。" },
            { 4, "队伍里每有不同一种元素类型的自己的角色，自身获得30%相应的元素抗性。" }
        }
    };

    public static readonly ArtifactSetModel _510 = new()
    {
        Rid = 510,
        Vid = 10002,
        Name = "勇士之心",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "勇士的冠冕" }, { 2, "勇士的期许" }, { 1, "勇士的勋章" }, { 3, "勇士的坚毅" }, { 4, "勇士的壮行" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10002_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10002_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10002_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10002_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10002_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "对生命值高于50%的敌人，造成的伤害增加30%。" }
        }
    };

    public static readonly ArtifactSetModel _511 = new()
    {
        Rid = 511,
        Vid = 10006,
        Name = "武人",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "武人的头巾" }, { 2, "武人的羽饰" }, { 1, "武人的红花" }, { 3, "武人的水漏" }, { 4, "武人的酒杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10006_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10006_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10006_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10006_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10006_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "普通攻击与重击造成的伤害提高15%。" },
            { 4, "施放元素战技后的8秒内，普通攻击和重击造成的伤害提升25%。" }
        }
    };

    public static readonly ArtifactSetModel _512 = new()
    {
        Rid = 512,
        Vid = 10008,
        Name = "赌徒",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "赌徒的耳环" }, { 2, "赌徒的羽饰" }, { 1, "赌徒的胸花" }, { 3, "赌徒的怀表" }, { 4, "赌徒的骰盅" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10008_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10008_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10008_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10008_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10008_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素战技造成的伤害提升20%。" },
            { 4, "击败敌人时，有100%概率清除元素战技的冷却时间。该效果每15秒至多触发一次。" }
        }
    };

    public static readonly ArtifactSetModel _513 = new()
    {
        Rid = 513,
        Vid = 10012,
        Name = "学士",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "学士的镜片" }, { 2, "学士的羽笔" }, { 1, "学士的书签" }, { 3, "学士的时钟" }, { 4, "学士的墨杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_10012_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_10012_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_10012_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_10012_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_10012_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素充能效率提高20%。" },
            { 4, "获得元素微粒或元素晶球时，队伍中所有弓箭和法器角色额外恢复3点元素能量。该效果每3秒只能触发一次。" }
        }
    };

    public static readonly ArtifactSetModel _514 = new()
    {
        Rid = 514,
        Vid = 15009,
        Name = "祭火之人",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "祭火礼冠" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15009_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 1, "受到的火元素附着效果的持续时间减少40%。" }
        }
    };

    public static readonly ArtifactSetModel _515 = new()
    {
        Rid = 515,
        Vid = 15010,
        Name = "祭水之人",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "祭水礼冠" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15010_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 1, "受到的水元素附着效果的持续时间减少40%。" }
        }
    };

    public static readonly ArtifactSetModel _516 = new()
    {
        Rid = 516,
        Vid = 15011,
        Name = "祭雷之人",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "祭雷礼冠" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15011_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 1, "受到的雷元素附着效果的持续时间减少40%。" }
        }
    };

    public static readonly ArtifactSetModel _517 = new()
    {
        Rid = 517,
        Vid = 15013,
        Name = "祭冰之人",
        RarityList = [3, 4],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "祭冰礼冠" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15013_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 1, "受到的冰元素附着效果的持续时间减少40%。" }
        }
    };

    public static readonly ArtifactSetModel _518 = new()
    {
        Rid = 518,
        Vid = 14001,
        Name = "冰风迷途的勇士",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "破冰踏雪的回音" }, { 2, "摧冰而行的执望" }, { 1, "历经风雪的思念" }, { 3, "冰雪故园的终期" }, { 4, "遍结寒霜的傲骨" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_14001_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_14001_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_14001_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_14001_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_14001_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%冰元素伤害加成。" },
            { 4, "攻击处于冰元素影响下的敌人时，暴击率提高20%；若敌人处于冻结状态下，则暴击率额外提高20%。" }
        }
    };

    public static readonly ArtifactSetModel _519 = new()
    {
        Rid = 519,
        Vid = 14002,
        Name = "平息鸣雷的尊者",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "平雷之冠" }, { 2, "平雷之羽" }, { 1, "平雷之心" }, { 3, "平雷之刻" }, { 4, "平雷之器" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_14002_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_14002_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_14002_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_14002_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_14002_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "雷元素抗性提高40%。" },
            { 4, "对处于雷元素影响下的敌人造成的伤害提升35%。" }
        }
    };

    public static readonly ArtifactSetModel _520 = new()
    {
        Rid = 520,
        Vid = 14003,
        Name = "渡过烈火的贤人",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "渡火者的智慧" }, { 2, "渡火者的解脱" }, { 1, "渡火者的决绝" }, { 3, "渡火者的煎熬" }, { 4, "渡火者的醒悟" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_14003_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_14003_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_14003_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_14003_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_14003_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "火元素抗性提高40%。" },
            { 4, "对处于火元素影响下的敌人造成的伤害提升35%。" }
        }
    };

    public static readonly ArtifactSetModel _521 = new()
    {
        Rid = 521,
        Vid = 14004,
        Name = "被怜爱的少女",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "少女易逝的芳颜" }, { 2, "少女飘摇的思念" }, { 1, "远方的少女之心" }, { 3, "少女苦短的良辰" }, { 4, "少女片刻的闲暇" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_14004_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_14004_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_14004_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_14004_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_14004_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "角色造成的治疗效果提升15%。" },
            { 4, "施放元素战技或元素爆发后的10秒内，队伍中所有角色受治疗效果加成提高20%。" }
        }
    };

    public static readonly ArtifactSetModel _522 = new()
    {
        Rid = 522,
        Vid = 15001,
        Name = "角斗士的终幕礼",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "角斗士的凯旋" }, { 2, "角斗士的归宿" }, { 1, "角斗士的留恋" }, { 3, "角斗士的希冀" }, { 4, "角斗士的酣醉" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15001_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15001_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15001_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15001_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15001_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "装备该圣遗物套装的角色为单手剑、双手剑、长柄武器角色时，角色普通攻击造成的伤害提高35%。" }
        }
    };

    public static readonly ArtifactSetModel _523 = new()
    {
        Rid = 523,
        Vid = 15002,
        Name = "翠绿之影",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "翠绿的猎人之冠" }, { 2, "猎人青翠的箭羽" }, { 1, "野花记忆的绿野" }, { 3, "翠绿猎人的笃定" }, { 4, "翠绿猎人的容器" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15002_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15002_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15002_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15002_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15002_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%风元素伤害加成。" },
            { 4, "扩散反应造成的伤害提升60%。根据扩散的元素类型，降低受到影响的敌人40%的对应元素抗性，持续10秒。" }
        }
    };

    public static readonly ArtifactSetModel _524 = new()
    {
        Rid = 524,
        Vid = 15003,
        Name = "流浪大地的乐团",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "指挥的礼帽" }, { 2, "琴师的箭羽" }, { 1, "乐团的晨光" }, { 3, "终幕的时计" }, { 4, "吟游者之壶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15003_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15003_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15003_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15003_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15003_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "装备该圣遗物套装的角色为法器、弓箭角色时，角色重击造成的伤害提高35%。" }
        }
    };

    public static readonly ArtifactSetModel _525 = new()
    {
        Rid = 525,
        Vid = 15005,
        Name = "如雷的盛怒",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "唤雷的头冠" }, { 2, "雷灾的孑遗" }, { 1, "雷鸟的怜悯" }, { 3, "雷霆的时计" }, { 4, "降雷的凶兆" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15005_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15005_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15005_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15005_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15005_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%雷元素伤害加成。" },
            { 4, "超载、感电、超导、超绽放反应造成的伤害提升40%，超激化反应带来的伤害提升提高20%，月感电反应造成的伤害提升20%。触发上述元素反应或原激化反应时，元素战技冷却时间减少1秒。该效果每0.8秒最多触发一次。" }
        }
    };

    public static readonly ArtifactSetModel _526 = new()
    {
        Rid = 526,
        Vid = 15006,
        Name = "炽烈的炎之魔女",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "焦灼的魔女帽" }, { 2, "魔女常燃之羽" }, { 1, "魔女的炎之花" }, { 3, "魔女破灭之时" }, { 4, "魔女的心之火" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15006_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15006_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15006_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15006_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15006_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%火元素伤害加成。" },
            { 4, "超载、燃烧、烈绽放反应造成的伤害提升40%，蒸发、融化反应的加成系数提高15%。施放元素战技后的10秒内，2件套的效果提高50%，该效果最多叠加3次。" }
        }
    };

    public static readonly ArtifactSetModel _527 = new()
    {
        Rid = 527,
        Vid = 15007,
        Name = "昔日宗室之仪",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "宗室面具" }, { 2, "宗室之翎" }, { 1, "宗室之花" }, { 3, "宗室时计" }, { 4, "宗室银瓮" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15007_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15007_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15007_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15007_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15007_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素爆发造成的伤害提升20%。" },
            { 4, "施放元素爆发后，队伍中所有角色攻击力提升20%，持续12秒。该效果不可叠加。" }
        }
    };

    public static readonly ArtifactSetModel _528 = new()
    {
        Rid = 528,
        Vid = 15008,
        Name = "染血的骑士道",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "染血的铁假面" }, { 2, "染血的黑之羽" }, { 1, "染血的铁之心" }, { 3, "骑士染血之时" }, { 4, "染血骑士之杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15008_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15008_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15008_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15008_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15008_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "造成的物理伤害提高25%。" },
            { 4, "击败敌人后的10秒内，施放重击时不消耗体力，且重击造成的伤害提升50%。" }
        }
    };

    public static readonly ArtifactSetModel _529 = new()
    {
        Rid = 529,
        Vid = 15014,
        Name = "悠古的磐岩",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "不动玄石之相" }, { 2, "嵯峨群峰之翼" }, { 1, "磐陀裂生之花" }, { 3, "星罗圭璧之晷" }, { 4, "巉岩琢塑之樽" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15014_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15014_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15014_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15014_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15014_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%岩元素伤害加成。" },
            { 4, "获得结晶反应形成的晶片或触发月结晶反应时，队伍中所有角色获得35%对应元素伤害加成，持续10秒。同时只能通过该效果获得一种元素伤害加成。" }
        }
    };

    public static readonly ArtifactSetModel _530 = new()
    {
        Rid = 530,
        Vid = 15015,
        Name = "逆飞的流星",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "夏祭之面" }, { 2, "夏祭终末" }, { 1, "夏祭之花" }, { 3, "夏祭之刻" }, { 4, "夏祭水玉" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15015_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15015_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15015_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15015_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15015_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "护盾强效提高35%。" },
            { 4, "处于护盾庇护下时，额外获得40%普通攻击和重击伤害加成。" }
        }
    };

    public static readonly ArtifactSetModel _531 = new()
    {
        Rid = 531,
        Vid = 15016,
        Name = "沉沦之心",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "酒渍船帽" }, { 2, "追忆之风" }, { 1, "饰金胸花" }, { 3, "坚铜罗盘" }, { 4, "沉波之盏" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15016_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15016_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15016_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15016_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15016_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%水元素伤害加成。" },
            { 4, "施放元素战技后的15秒内，普通攻击与重击造成的伤害提高30%。" }
        }
    };

    public static readonly ArtifactSetModel _532 = new()
    {
        Rid = 532,
        Vid = 15017,
        Name = "千岩牢固",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "将帅兜鍪" }, { 2, "昭武翎羽" }, { 1, "勋绩之花" }, { 3, "金铜时晷" }, { 4, "盟誓金爵" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15017_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15017_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15017_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15017_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15017_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "生命值提升20%。" },
            { 4, "元素战技命中敌人后，使队伍中附近的所有角色攻击力提升20%，护盾强效提升30%，持续3秒。该效果每0.5秒至多触发一次。装备此圣遗物套装的角色处于队伍后台时，依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _533 = new()
    {
        Rid = 533,
        Vid = 15018,
        Name = "苍白之火",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "嗤笑之面" }, { 2, "贤医之羽" }, { 1, "无垢之花" }, { 3, "停摆之刻" }, { 4, "超越之盏" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15018_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15018_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15018_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15018_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15018_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "造成的物理伤害提高25%。" },
            { 4, "元素战技命中敌人后，攻击力提升9%。该效果持续7秒，至多叠加2层，每0.3秒至多触发一次。叠满2层时，2件套的效果提升100%。" }
        }
    };

    public static readonly ArtifactSetModel _534 = new()
    {
        Rid = 534,
        Vid = 15019,
        Name = "追忆之注连",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "无常之面" }, { 2, "思忆之矢" }, { 1, "羁缠之花" }, { 3, "朝露之时" }, { 4, "祈望之心" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15019_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15019_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15019_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15019_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15019_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "施放元素战技时，如果角色的元素能量高于或等于15点，则会流失15点元素能量，使接下来的10秒内，普通攻击、重击、下落攻击造成的伤害提高50%，持续期间内该效果不会再次触发。" }
        }
    };

    public static readonly ArtifactSetModel _535 = new()
    {
        Rid = 535,
        Vid = 15020,
        Name = "绝缘之旗印",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "华饰之兜" }, { 2, "切落之羽" }, { 1, "明威之镡" }, { 3, "雷云之笼" }, { 4, "绯花之壶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15020_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15020_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15020_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15020_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15020_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素充能效率提高20%。" },
            { 4, "基于元素充能效率的25%，提高元素爆发造成的伤害。至多通过这种方式获得75%提升。" }
        }
    };

    public static readonly ArtifactSetModel _536 = new()
    {
        Rid = 536,
        Vid = 15021,
        Name = "华馆梦醒形骸记",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "形骸之笠" }, { 2, "华馆之羽" }, { 1, "荣花之期" }, { 3, "众生之谣" }, { 4, "梦醒之瓢" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15021_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15021_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15021_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15021_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15021_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "防御力提高30%。" },
            { 4, "装备此圣遗物套装的角色在以下情况下，将获得「问答」效果：在场上用岩元素攻击命中敌人后获得一层，每0.3秒至多触发一次；在队伍后台中，每3秒获得一层。问答至多叠加4层，每层能提供6%防御力与6%岩元素伤害加成。每6秒，若未获得问答效果，将损失一层。" }
        }
    };

    public static readonly ArtifactSetModel _537 = new()
    {
        Rid = 537,
        Vid = 15022,
        Name = "海染砗磲",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "海祇之冠" }, { 2, "渊宫之羽" }, { 1, "海染之花" }, { 3, "离别之贝" }, { 4, "真珠之笼" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15022_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15022_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15022_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15022_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15022_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "治疗加成提高15%。" },
            { 4, "装备此圣遗物套装的角色对队伍中的角色进行治疗时，将产生持续3秒的海染泡沫，记录治疗的生命值回复量（包括溢出值）。持续时间结束时，海染泡沫将会爆炸，对周围的敌人造成90%累计回复量的伤害（该伤害结算方式同感电、超导等元素反应，但不受元素精通、等级或反应伤害加成效果影响）。每3.5秒至多产生一个海染泡沫；海染泡沫至多记录30000点回复量，含溢出部分的治疗量；自己的队伍中同时至多存在一个海染泡沫。装备此圣遗物套装的角色处于队伍后台时，依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _538 = new()
    {
        Rid = 538,
        Vid = 15023,
        Name = "辰砂往生录",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "虺雷之姿" }, { 2, "潜光片羽" }, { 1, "生灵之华" }, { 3, "阳辔之遗" }, { 4, "结契之刻" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15023_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15023_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15023_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15023_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15023_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "施放元素爆发后，将产生持续16秒的「潜光」效果：攻击力提升8%；并在角色的生命值降低时，攻击力进一步提升10%，至多通过这种方式提升4次，每0.8秒至多触发一次。「潜光」效果将在角色退场时消失；持续期间再次施放元素爆发，将移除原有的「潜光」。" }
        }
    };

    public static readonly ArtifactSetModel _539 = new()
    {
        Rid = 539,
        Vid = 15024,
        Name = "来歆余响",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "浮溯之珏" }, { 2, "垂玉之叶" }, { 1, "魂香之花" }, { 3, "祝祀之凭" }, { 4, "涌泉之盏" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15024_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15024_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15024_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15024_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15024_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "普通攻击命中敌人时，有36%概率触发「幽谷祝祀」：普通攻击造成的伤害提高，伤害提高值为攻击力的70%，该效果将在普通攻击造成伤害后的0.05秒后清除。普通攻击未触发「幽谷祝祀」时，会使下次触发概率提升20%；0.2秒内至多判定1次触发与否。" }
        }
    };

    public static readonly ArtifactSetModel _540 = new()
    {
        Rid = 540,
        Vid = 15025,
        Name = "深林的记忆",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "月桂的宝冠" }, { 2, "翠蔓的智者" }, { 1, "迷宫的游人" }, { 3, "贤智的定期" }, { 4, "迷误者之灯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15025_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15025_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15025_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15025_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15025_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%草元素伤害加成。" },
            { 4, "元素战技或元素爆发命中敌人后，使命中目标的草元素抗性降低30%，持续8秒。装备者处于队伍后台时，依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _541 = new()
    {
        Rid = 541,
        Vid = 15026,
        Name = "饰金之梦",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "沙王的投影" }, { 2, "裁断的翎羽" }, { 1, "梦中的铁花" }, { 3, "沉金的岁月" }, { 4, "如蜜的终宴" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15026_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15026_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15026_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15026_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15026_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "触发元素反应后的8秒内，会根据队伍内其他角色的元素类型，使装备者获得强化：队伍中每存在1个和装备者同类元素的角色，攻击力提升14%；每存在1个和装备者不同元素类型的角色，元素精通提升50点。上述每类效果至多计算3个角色。该效果每8秒至多触发一次。装备者处于队伍后台时，依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _542 = new()
    {
        Rid = 542,
        Vid = 15027,
        Name = "沙上楼阁史话",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "流沙贵嗣的遗宝" }, { 2, "黄金邦国的结末" }, { 1, "众王之都的开端" }, { 3, "失落迷途的机芯" }, { 4, "迷醉长梦的守护" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15027_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15027_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15027_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15027_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15027_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%风元素伤害加成。" },
            { 4, "重击命中敌人后，该角色的普通攻击速度提升10%，普通攻击、重击与下落攻击造成的伤害提升40%，持续15秒。" }
        }
    };

    public static readonly ArtifactSetModel _543 = new()
    {
        Rid = 543,
        Vid = 15028,
        Name = "乐园遗落之花",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "紫晶的花冠" }, { 2, "谢落的筵席" }, { 1, "月女的华彩" }, { 3, "凝结的时刻" }, { 4, "守秘的魔瓶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15028_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15028_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15028_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15028_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15028_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "装备者绽放、超绽放、烈绽放反应造成的伤害提升40%，造成的月绽放反应伤害提升10%。此外，装备者触发绽放、超绽放、烈绽放、月绽放后，上述效果带来的加成提升25%，该效果持续10秒，至多叠加4次，每1秒至多触发一次。装备者处于队伍后台时依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _544 = new()
    {
        Rid = 544,
        Vid = 15029,
        Name = "水仙之梦",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "  恶龙的单片镜  " }, { 2, "  坏巫师的羽杖  " }, { 1, "  旅途中的鲜花  " }, { 3, "水仙的时时刻刻" }, { 4, "  勇者们的茶会  " },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15029_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15029_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15029_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15029_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15029_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%水元素伤害加成。" },
            { 4, "普通攻击、重击、下落攻击、元素战技或元素爆发命中敌人后，将产生1层持续8秒的「镜中水仙」效果。处于1/2/3层及以上「镜中水仙」效果下时，攻击力将提高7%/16%/25%，水元素伤害加成提升4%/9%/15%。由普通攻击、重击、下落攻击、元素战技或元素爆发产生的「镜中水仙」将分别独立存在。" }
        }
    };

    public static readonly ArtifactSetModel _545 = new()
    {
        Rid = 545,
        Vid = 15030,
        Name = "花海甘露之光",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "灵光明烁之心" }, { 2, "琦色灵彩之羽" }, { 1, "灵光源起之蕊" }, { 3, "久远花落之时" }, { 4, "无边酣乐之筵" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15030_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15030_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15030_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15030_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15030_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "生命值提升20%。" },
            { 4, "元素战技与元素爆发造成的伤害提升10%；装备者受到伤害后的5秒内，上述伤害提升效果提高80%，该提高效果至多叠加5层，每层持续时间独立计算，处于队伍后台时依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _546 = new()
    {
        Rid = 546,
        Vid = 15031,
        Name = "逐影猎人",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "老兵的容颜" }, { 2, "杰作的序曲" }, { 1, "猎人的胸花" }, { 3, "裁判的时刻" }, { 4, "遗忘的容器" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15031_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15031_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15031_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15031_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15031_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "普通攻击与重击造成的伤害提高15%。" },
            { 4, "当前生命值提升或降低时，暴击率提升12%，该效果持续5秒，至多叠加3次。" }
        }
    };

    public static readonly ArtifactSetModel _547 = new()
    {
        Rid = 547,
        Vid = 15032,
        Name = "黄金剧团",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "黄金剧团的奖赏" }, { 2, "黄金飞鸟的落羽" }, { 1, "黄金乐曲的变奏" }, { 3, "黄金时代的先声" }, { 4, "黄金之夜的喧嚣" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15032_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15032_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15032_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15032_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15032_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素战技造成的伤害提升20%。" },
            { 4, "元素战技造成的伤害提升25%；此外，处于队伍后台时，元素战技造成的伤害还将进一步提升25%，该效果将在登场后2秒移除。" }
        }
    };

    public static readonly ArtifactSetModel _548 = new()
    {
        Rid = 548,
        Vid = 15033,
        Name = "昔时之歌",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "昔时传奏之诗" }, { 2, "昔时浮想之思" }, { 1, "昔时遗落之誓" }, { 3, "昔时回映之音" }, { 4, "昔时应许之梦" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15033_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15033_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15033_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15033_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15033_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "治疗加成提高15%。" },
            { 4, "装备者对队伍中的角色进行治疗时，将产生持续6秒的渴盼效果，记录治疗的生命值回复量（包括溢出值）。持续时间结束时，渴盼效果将转变为「彼时的浪潮」效果：队伍中自己的当前场上角色的普通攻击、重击、下落攻击、元素战技与元素爆发命中敌人时，将基于渴盼效果所记录的回复量的8%提高造成的伤害，「彼时的浪潮」将在生效5次或10秒后移除。一次渴盼效果至多记录15000点回复量，同时至多存在一个，能够记录多个装备者的产生的回复量；装备者处于队伍后台时，依然能触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _549 = new()
    {
        Rid = 549,
        Vid = 15034,
        Name = "回声之林夜话",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "慈爱的淑女帽" }, { 2, "诚恳的蘸水笔" }, { 1, "无私的妆饰花" }, { 3, "忠实的砂时计" }, { 4, "慷慨的墨水瓶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15034_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15034_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15034_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15034_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15034_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "施放元素战技后的10秒内，岩元素伤害加成提升20%；若处于结晶反应产生的护盾庇护下，或附近存在月结晶反应产生的月笼，上述效果提高150%，进一步提高的效果将在不满足上面条件的1秒后移除。" }
        }
    };

    public static readonly ArtifactSetModel _550 = new()
    {
        Rid = 550,
        Vid = 15035,
        Name = "谐律异想断章",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "异想零落的圆舞" }, { 2, "古海玄幽的夜想" }, { 1, "谐律交响的前奏" }, { 3, "命途轮转的谐谑" }, { 4, "灵露倾洒的狂诗" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15035_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15035_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15035_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15035_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15035_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "生命之契的数值提升或降低时，角色造成的伤害提升18%，该效果持续6秒，至多叠加3次。" }
        }
    };

    public static readonly ArtifactSetModel _551 = new()
    {
        Rid = 551,
        Vid = 15036,
        Name = "未竟的遐思",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "失冕的宝冠" }, { 2, "褪光的翠尾" }, { 1, "暗结的明花" }, { 3, "举业的识刻" }, { 4, "筹谋的共樽" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15036_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15036_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15036_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15036_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15036_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "脱离战斗状态3秒后，造成的伤害提升50%。在战斗状态下，附近不存在处于燃烧状态下的敌人超过6秒后，上述伤害提升效果每秒降低10%，直到降低至0%；存在处于燃烧状态下的敌人时，每秒提升10%，直到达到50%。装备此圣遗物套装的角色处于队伍后台时，依然会触发该效果。" }
        }
    };

    public static readonly ArtifactSetModel _552 = new()
    {
        Rid = 552,
        Vid = 15037,
        Name = "烬城勇者绘卷",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "魔战士的羽面" }, { 2, "巡山客的信标" }, { 1, "驯兽师的护符" }, { 3, "秘术家的金盘" }, { 4, "游学者的爪杯" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15037_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15037_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15037_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15037_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15037_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "队伍中附近的角色触发「夜魂迸发」时，装备者恢复6点元素能量。" },
            { 4, "装备者触发其对应元素类型的相关反应后，队伍中附近的所有角色的该元素反应相关的元素伤害加成提升12%，持续15秒。若触发该效果时，装备者处于夜魂加持状态下，还将使队伍中附近的所有角色的与该元素反应相关的元素伤害加成提升28%，持续20秒。装备者处于后台时也能触发上述效果。同名圣遗物套装产生的伤害加成效果无法叠加。" }
        }
    };

    public static readonly ArtifactSetModel _553 = new()
    {
        Rid = 553,
        Vid = 15038,
        Name = "黑曜秘典",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "诸圣的礼冠" }, { 2, "灵髓的根脉" }, { 1, "异种的期许" }, { 3, "夜域的迷思" }, { 4, "纷争的前宴" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15038_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15038_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15038_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15038_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15038_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "装备者处于夜魂加持状态，并且在场上时，造成的伤害提高15%。" },
            { 4, "装备者在场上消耗1点夜魂值后，暴击率提高40%，持续6秒。该效果每1秒至多触发一次。" }
        }
    };

    public static readonly ArtifactSetModel _554 = new()
    {
        Rid = 554,
        Vid = 15039,
        Name = "长夜之誓",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "被浸染的缨盔" }, { 2, "夜鸣莺的尾羽" }, { 1, "执灯人的誓词" }, { 3, "不死者的哀铃" }, { 4, "未吹响的号角" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15039_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15039_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15039_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15039_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15039_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "下落攻击造成的伤害提升25%。" },
            { 4, "装备者的下落攻击/重击/元素战技命中敌人后，获得1/2/2层「永照的流辉」，由下落攻击、重击或元素战技产生的该效果分别每1秒至多触发一次。永照的流辉：下落攻击造成的伤害提升15%，持续6秒，至多叠加5层，每层持续时间独立计算。" }
        }
    };

    public static readonly ArtifactSetModel _555 = new()
    {
        Rid = 555,
        Vid = 15040,
        Name = "深廊终曲",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "深廊的遂失之冕" }, { 2, "深廊的漫远之约" }, { 1, "深廊的回奏之歌" }, { 3, "深廊的湮落之刻" }, { 4, "深廊的饫赐之宴" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15040_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15040_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15040_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15040_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15040_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "获得15%冰元素伤害加成。" },
            { 4, "装备者的元素能量为0时，普通攻击造成的伤害提升60%，元素爆发造成的伤害提升60%。装备者的普通攻击造成伤害后，上述元素爆发伤害提升效果将失效6秒；装备者的元素爆发造成伤害后，上述普通攻击伤害提升效果将失效6秒。角色处于队伍后台也能触发。" }
        }
    };

    public static readonly ArtifactSetModel _556 = new()
    {
        Rid = 556,
        Vid = 15041,
        Name = "穹境示现之夜",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "永劫之冕" }, { 2, "深罪之羽" }, { 1, "渴真之花" }, { 3, "谕告之钟" }, { 4, "满溢之壶" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15041_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15041_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15041_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15041_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15041_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "队伍中附近的角色触发月曜反应时，若装备者在场上，将获得持续4秒的「月辉明光·蓄念」效果：队伍的月兆为初辉/满辉时，暴击率提升15%/30%。队伍中的角色每拥有一种不同的「月辉明光」效果，队伍中的所有角色触发的月曜反应造成的伤害提升10%。由「月辉明光」产生的效果无法叠加。" }
        }
    };

    public static readonly ArtifactSetModel _557 = new()
    {
        Rid = 557,
        Vid = 15042,
        Name = "纺月的夜歌",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "司信者的圣冕" }, { 2, "受福者的白羽" }, { 1, "流离者的晶泪" }, { 3, "祭霜者的迷狂" }, { 4, "至纯者的欢荣" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15042_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15042_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15042_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15042_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15042_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素充能效率提高20%。" },
            { 4, "造成元素伤害时，获得持续8秒的「月辉明光·崇信」效果：队伍的月兆为初辉/满辉时，队伍中的所有角色的元素精通提高60点/120点。装备者处于后台时也能触发上述效果。队伍中的角色每拥有一种不同的「月辉明光」效果，队伍中的所有角色触发的月曜反应造成的伤害提升10%。由「月辉明光」产生的效果无法叠加。" }
        }
    };

    public static readonly ArtifactSetModel _558 = new()
    {
        Rid = 558,
        Vid = 15043,
        Name = "晨星与月的晓歌",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "献与月的银冕" }, { 2, "献与月的离光" }, { 1, "献与月的华梦" }, { 3, "献与月的终时" }, { 4, "献与月的酹祭" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15043_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15043_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15043_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15043_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15043_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "元素精通提高80点。" },
            { 4, "装备者处于队伍后台时，造成的月曜反应伤害提升20%；队伍的月兆等级至少为满辉时，造成的月曜反应伤害进一步提升40%。上述效果将在装备者位于场上3秒后移除。" }
        }
    };

    public static readonly ArtifactSetModel _559 = new()
    {
        Rid = 559,
        Vid = 15044,
        Name = "风起之日",
        RarityList = [4, 5],
        PositionNameDict = new Dictionary<int, string>
        {
            { 5, "哀慕的恋歌" }, { 2, "晨光的明誓" }, { 1, "风花的箴铭" }, { 3, "春律的片刻" }, { 4, "未言的宴话" },
        },
        PositionImagePathDict = new Dictionary<int, string>
        {
            { 1, "/Resources/Images/Artifacts/UI_RelicIcon_15044_4.png" },
            { 2, "/Resources/Images/Artifacts/UI_RelicIcon_15044_2.png" },
            { 3, "/Resources/Images/Artifacts/UI_RelicIcon_15044_5.png" },
            { 4, "/Resources/Images/Artifacts/UI_RelicIcon_15044_1.png" },
            { 5, "/Resources/Images/Artifacts/UI_RelicIcon_15044_3.png" },
        },
        EffectDict = new Dictionary<int, string>
        {
            { 2, "攻击力提高18%。" },
            { 4, "普通攻击、重击、元素战技或元素爆发命中敌人后，将获得持续6秒的「风与牧歌的眷怜」：攻击力提高25%。若装备者已经完成了「魔女的课业」，则「风与牧歌的眷怜」将会升级为「风与牧歌的决意」，额外使通过考验的装备者的暴击率提升20%。装备者处于队伍后台时，也能触发上述效果。" }
        }
    };
}