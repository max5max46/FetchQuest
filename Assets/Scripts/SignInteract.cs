using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignInteract : MonoBehaviour
{
    public Dialogue dialogueScript;
    [TextArea]
    public string signText;
    public Color nameColor;

    // Update is called once per frame
    void Update()
    {
        if (transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith)
        {
            dialogueScript.StartDialogue(signText, name, nameColor);
            transform.GetChild(0).GetComponent<TriggerInteract>().isInteractedWith = false;
        }
    }
}
