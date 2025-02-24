﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace VketTools
{
    public class RuleLoader
    {
        public static BaseRule[] Load(Options options)
        {
            BaseRule[] rules = new BaseRule[] { };
            //Common rules
            rules = AddCommonRules(rules, options);
            //On/Off booth rules
            if (options.forOnoffBooth)
            {
                rules = AddOnOffBoothRules(rules, options);
            }
            //Standard booth rules
            else
            {
                rules = AddStandardBoothRules(rules, options);
            }
            return rules;
        }

        private static BaseRule[] AddCommonRules(BaseRule[] rules, Options options)
        {
            BaseRule[] commonRules = new BaseRule[]
            {
            //Template
            //new TamplateRule(options),
            //A
            new UnityVersionRule(options),
            new BaseFolderRule(options),
            new BoothPrefabRule(options),
            //B
            new NonAlphabeticalCharactersRule(options),
            new FilenameEndWithTildeRule(options),
            new FilePathLengthRule(options),
            new BlenderFileRule(options),
            //C
            new ObjectHierarchyRule(options),
            new StaticObjectRule(options),
            //D
            new BoothSizeRule(options),
            new BoothPivotRule(options),
            new BoothPositionRule(options),
            new NumberOfMaterialsRule(options),
            new TextureCompressionRule(options),
            //F
            //G
            new WhitelistComponentRule(options),
            new MonoBehaviorListRule(options),
            new ObjectSyncRule(options),
            //new PickupObjectRule(options), // 落マケは無効化
            new RigidbodyRule(options),
            new JointRule(options),
            new LightRule(options),
            new AnimatorRule(options),
            //Y
            new AnimationObjectHierarchyRule(options),
            //Z
            new PickupObjectSyncPrefabRule(options),
            new ObjectSwitchRule(options),
             };
            return rules.Concat(commonRules).ToArray();
        }
        private static BaseRule[] AddStandardBoothRules(BaseRule[] rules, Options options)
        {
            BaseRule[] standardBoothRules = new BaseRule[]
             {
            //Template
            //new TamplateRule(options),
            //E
             };
            return rules.Concat(standardBoothRules).ToArray();
        }
        private static BaseRule[] AddOnOffBoothRules(BaseRule[] rules, Options options)
        {
            BaseRule[] onoffBoothRules = new BaseRule[]
             {
            //Template
            //new TamplateRule(options),
            //E
             };
            return rules.Concat(onoffBoothRules).ToArray();
        }
    }
}