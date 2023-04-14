using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NpcInteract : MonoBehaviour
{
    public Dialogue dialogueScript;
    public Win winScript;
    [TextArea]
    public List<string> dialogue;
    public inventoryItems playerInventory;
    public Color nameColor;
    public enum item {coin, screw, orb, cola, waterBottle, none }
    public item wantedItem;
    public bool spawnItem;
    public GameObject itemToSpawn = null;

    int whichLine;
    bool firstInteraction;
    bool finalInteraction;
    // Start is called before the first frame update
    void Start()
    {
        if (itemToSpawn != null)
            itemToSpawn.SetActive(false);

        whichLine = 0;
        firstInteraction = true;
        finalInteraction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!firstInteraction)
            whichLine = 1;

        if (playerInventory.itemArray[(int)wantedItem])
        {
            if (firstInteraction)
                whichLine = 3;
            else
                whichLine = 2;
        }

        if (finalInteraction)
            whichLine = 4;

        if (transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith)
        {
            dialogueScript.StartDialogue(dialogue[whichLine], name, nameColor);
            transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith = false;

            if (whichLine == 0)
                firstInteraction = false;

            if (whichLine == 2 || whichLine == 3)
            {
                playerInventory.itemArray[(int)wantedItem] = false;
                finalInteraction = true;
                winScript.NPCHelped();
                if (spawnItem == true || itemToSpawn != null)
                    itemToSpawn.SetActive(true);

            }

        }
    }
}
