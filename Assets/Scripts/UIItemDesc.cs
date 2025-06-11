using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIItemDesc : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemDesc;

    public void ShowItemDesc(Item item)
    {
        itemDesc.text = $"{item.itemName} \n<size=90%>{item.itemDescription}</size> \n\nAP +{item.PlusAP}\tDP +{item.PlusDP} \nHP +{item.PlusHP}\tCP +{item.PlusCP}";
    }
}
