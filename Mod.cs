using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace FairyTownModNS
{
    public class FairyTownMod : Mod
    {
        public override void Ready()
        {
            Logger.Log("Ready!");
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "examplemod_blueprint_golden_berry", 1);
        }
    }

    public class DimensionGate : CardData
    {
        public override bool CanHaveCardsWhileHasStatus() => true;
        public override bool CanHaveCard(CardData otherCard) => otherCard.MyCardType == CardType.Resources || CardType.resource.Food;
    
        public override bool CanBePushedBy(CardData otherCard) => false;
    }

    public class Fairy : CardData
    {
        public override bool CanHaveCard(CardData otherCard) => otherCard.MyCardType == CardType.Resources || CardType.resource.Food;
    }

    public class JewelryWorkShop : CardData
    {
        public override bool CanHaveCardsWhileHasStatus() => true;
        public override bool CanHaveCard(CardData otherCard) => otherCard.MyCardType == CardType.Resources;
    
        public override bool CanBePushedBy(CardData otherCard) => false;
    }
}