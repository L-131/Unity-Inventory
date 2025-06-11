using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        this.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        this.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }

}
