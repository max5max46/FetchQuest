using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryItems : MonoBehaviour
{
    enum item {coin, screw, orb, cola, waterBottle, none }

    public bool[] itemArray;

    private void Start()
    {
        itemArray = new bool[6];
        itemArray[(int)item.coin] = false;
        itemArray[(int)item.screw] = false;
        itemArray[(int)item.orb] = false;
        itemArray[(int)item.cola] = false;
        itemArray[(int)item.waterBottle] = false;
        itemArray[(int)item.none] = false;

    }

    private void Update()
    {
        Debug.Log(itemArray[(int)item.coin]);
    }

    public void GiveItem(int itemID)
    {
        itemArray[itemID] = true;
    }
}
