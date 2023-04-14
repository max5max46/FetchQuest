using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteract : MonoBehaviour
{
    public enum item {coin, screw, orb, cola, waterBottle, none }

    public item itemToGive;
    public inventoryItems inventory;

    // Update is called once per frame
    void Update()
    {
        if (transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith)
        {
            inventory.GiveItem((int)itemToGive);
            transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith = false;
            Destroy(transform.parent.gameObject);
        }
    }
}
