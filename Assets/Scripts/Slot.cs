using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Image image => GetComponent<Image>();

    [SerializeField] private Image EisEquiped;

    private Item curItem;

    private void Start()
    {
        //SynchroEandIsEquiped();
    }

    /// <summary>
    /// �������� isEquiped�� E �� ����ȭ�ϴ� �Լ��ε� �ʿ������
    /// </summary>
    private void SynchroEandIsEquiped()
    {
        for (int i = 0; i < UIManager.Instance.Inventory.items.Count; i++)
        {
            UIManager.Instance.Inventory.slots[i].EisEquiped.gameObject.SetActive(UIManager.Instance.Inventory.items[i].isEquiped);
        }
    }

    public void SetItem(Item item)
    {
        curItem = item;
        image.sprite = item.itemImage;
        EisEquiped.gameObject.SetActive(item.isEquiped);
    }

    public void ClearItem()
    {
        curItem = null;
        image.sprite = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //�� if���� ������ ���� �ߴµ� ������������� ���⼭�� �Ұ� ���Ƽ� �ϴ� �״�� �׾��
        if (curItem != null)
        {
            if (!curItem.isEquiped)
            {
                curItem.isEquiped = true;
                EisEquiped.gameObject.SetActive(true);
            }
            else
            {
                curItem.isEquiped = false;
                EisEquiped.gameObject.SetActive(false);
            }
            UIManager.Instance.CalcTotalEquipPlus();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (curItem != null)
        {
            UIManager.Instance.ItemDesc.gameObject.SetActive(true);
            UIManager.Instance.ItemDesc.ShowItemDesc(curItem);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        UIManager.Instance.ItemDesc.gameObject.SetActive(false);
    }
}
