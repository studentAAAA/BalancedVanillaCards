using BepInEx;
using UnboundLib.Cards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[BepInDependency("com.willis.rounds.unbound")]
[BepInDependency("pykess.rounds.plugins.moddingutils")]
[BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
[BepInPlugin("com.gelforce.rounds.balancedvanillacards", "BalancedVanillaCards", "1.0.0")]
[BepInProcess("Rounds.exe")]
public class BalancedVanillaCards : BaseUnityPlugin
{
    internal static string modInitials = "BVC";
    internal static AssetBundle assets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        assets = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("assets", typeof(BalancedVanillaCards).Assembly);
        assets.LoadAsset<GameObject>("ModCards").GetComponent<CardHolder>().RegisterCards();
    }
}
/*
public class CardHolder : MonoBehaviour
{
    public List<GameObject> Cards;
    public List<GameObject> HiddenCards;

    internal void RegisterCards()
    {
        foreach (var Card in Cards)
        {
            CustomCard.RegisterUnityCard(Card, BalancedVanillaCards.modInitials, Card.GetComponent<CardInfo>().cardName, true, null);
        }
        foreach (var Card in HiddenCards)
        {
            CustomCard.RegisterUnityCard(Card, BalancedVanillaCards.modInitials, Card.GetComponent<CardInfo>().cardName, false, null);
            ModdingUtils.Utils.Cards.instance.AddHiddenCard(Card.GetComponent<CardInfo>());
        }
    }
}

*/