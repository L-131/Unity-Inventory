using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public UIManager uiManager { get { return UIManager.Instance; } }
    public Sprite charaSprite { get; private set; }
    public string playerName { get; private set; }
    public int lv { get; private set; }
    public int curExp { get; private set; }
    public int maxExp { get { return lv * 10 + 5; } }
    public string playerTitle { get; private set; }
    public string playerDescription { get; private set; }
    public int playerGold { get; private set; }
    public int pureAP { get; private set; }
    public int pureDP { get; private set; }
    public int pureHP { get; private set; }
    public int pureCP { get; private set; }
    public int equipAP { get; private set; }
    public int equipDP { get; private set; }
    public int equipHP { get; private set; }
    public int equipCP { get; private set; }
    public int totalAP { get { return pureAP + equipAP; } }
    public int totalDP { get { return pureDP + equipDP; } }
    public int totalHP { get { return pureHP + equipHP; } }
    public int totalCP { get { return pureCP + equipCP; } }




    public void InitPureStatus(CharacterData data)
    {
        charaSprite = data.portrait;
        playerName = data.name;
        lv = data.level;
        curExp = data.exp;
        playerTitle = data.title;
        playerDescription = data.description;
        playerGold = data.gold;
        pureAP = data.ap;
        pureDP = data.dp;
        pureHP = data.hp;
        pureCP = data.cp;
    }

    public void InitEquipItem(int ap, int dp, int hp, int cp)
    {
        equipAP = ap;
        equipDP = dp;
        equipHP = hp;
        equipCP = cp;
    }
}
