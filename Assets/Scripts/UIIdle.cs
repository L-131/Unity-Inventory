using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIIdle : MonoBehaviour
{
    private Sprite charaImage => GameManager.Instance.player.charaSprite;
    private string playerTitle => GameManager.Instance.player.playerTitle;
    private string playerName => GameManager.Instance.player.playerName;
    private string playerLv => $"Lv <size=170%><b>{GameManager.Instance.player.lv.ToString("D2")}</b></size>";
    private string expBar => $"{GameManager.Instance.player.curExp} / {GameManager.Instance.player.maxExp}";
    private string playerDescription => GameManager.Instance.player.playerDescription;
    private string playerGold => GameManager.Instance.player.playerGold.ToString("N0");
    private int curExp => GameManager.Instance.player.curExp;
    private int maxExp => GameManager.Instance.player.maxExp;

    [SerializeField] private Image showCharaImage;
    [SerializeField] private Image expUiBar;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI lvText;
    [SerializeField] private TextMeshProUGUI expText;
    [SerializeField] private TextMeshProUGUI playerDescriptionText;
    [SerializeField] private TextMeshProUGUI playerGoldText;

    private void Update()
    { 
        UpdateIdleStatus();
    }
    public void UpdateIdleStatus()
    {
        showCharaImage.sprite = charaImage;
        expUiBar.fillAmount = (float)curExp / maxExp;
        titleText.text = playerTitle;
        nameText.text = playerName;
        lvText.text = playerLv;
        expText.text = expBar;
        playerDescriptionText.text = playerDescription;
        playerGoldText.text = playerGold;
    }
}
