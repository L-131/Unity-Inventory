using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject returnBtn;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    public List<Item> items = new List<Item>();
    public List<Slot> slots = new List<Slot>();
    public int slotCount = 9;
    public void ReturnToMain()
    {
        UIManager.Instance.MainMenu.OpenMainMenu();
    }

    private void Start()
    {
        MakeSlot(slotCount);
        UpdateInventoryUI();
    }

    public void UpdateInventoryUI()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (i < items.Count)
            {
                slots[i].SetItem(items[i]);
            }
            else
            {
                slots[i].ClearItem();
            }
        }
    }

    private void MakeSlot(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, slotParent);
            Slot slot = slotObj.GetComponent<Slot>();
            slots.Add(slot);
        }
    }
}
