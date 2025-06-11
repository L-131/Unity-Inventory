using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private UIIdle idle;
    public UIIdle Idle { get { return idle; } }

    [SerializeField] private UIMainMenu mainMenu;
    public UIMainMenu MainMenu { get { return mainMenu; } }

    [SerializeField] private UIStatus status;
    public UIStatus Status { get { return status; } }

    [SerializeField] private UIInventory inventory;
    public UIInventory Inventory { get { return inventory; } }

    [SerializeField] private UIItemDesc itemDesc;
    public UIItemDesc ItemDesc { get { return itemDesc; } }

    private void Start()
    {
        Idle.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(true);
        Status.gameObject.SetActive(false);
        Inventory.gameObject.SetActive(false);
        CalcTotalEquipPlus();
    }

    /// <summary>
    /// 장비 착용으로 올라간 능력치 계산하고 반영하기
    /// </summary>
    public void CalcTotalEquipPlus()
    {
        int totalEquipAP = 0;
        int totalEquipDP = 0;
        int totalEquipHP = 0;
        int totalEquipCP = 0;

        for (int i = 0; i < Inventory.items.Count; i++)
        {
            if (Inventory.items[i].isEquiped)
            {
                totalEquipAP += Inventory.items[i].PlusAP;
                totalEquipDP += Inventory.items[i].PlusDP;
                totalEquipHP += Inventory.items[i].PlusHP;
                totalEquipCP += Inventory.items[i].PlusCP;
            }
        }

        GameManager.Instance.player.InitEquipItem(totalEquipAP, totalEquipDP, totalEquipHP, totalEquipCP);
    }
}
