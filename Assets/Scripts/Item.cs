using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemImage;
    public bool isEquiped;
    public int PlusAP;
    public int PlusDP;
    public int PlusHP;
    public int PlusCP;
}
