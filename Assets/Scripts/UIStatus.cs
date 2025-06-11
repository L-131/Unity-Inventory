using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private GameObject returnBtn;
    private string ap => $"Attack Point \n<size=150%><b>{GameManager.Instance.player.pureAP} (+{GameManager.Instance.player.equipAP})</b></size>";
    private string dp => $"Defend Point \n<size=150%><b>{GameManager.Instance.player.pureDP} (+{GameManager.Instance.player.equipDP})</b></size>";
    private string hp => $"Health Point \n<size=150%><b>{GameManager.Instance.player.pureHP} (+{GameManager.Instance.player.equipHP})</b></size>";
    private string cp => $"Critical Point \n<size=150%><b>{GameManager.Instance.player.pureCP} (+{GameManager.Instance.player.equipCP})</b></size>";

    [SerializeField] private TextMeshProUGUI apText;
    [SerializeField] private TextMeshProUGUI dpText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI cpText;
    public void ReturnToMain()
    {
        UIManager.Instance.MainMenu.OpenMainMenu();
    }

    private void Update()
    {
        UpdateStatus();
    }

    public void UpdateStatus()
    {
        apText.text = ap;
        dpText.text = dp;
        hpText.text = hp;
        cpText.text = cp;
    }
}
