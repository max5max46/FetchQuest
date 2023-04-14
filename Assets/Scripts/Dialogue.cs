using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public PlayerController playerScript;
    public TextMeshProUGUI dialogueBoxText;
    public TextMeshProUGUI dialogueNameText;
    public GameObject dialoguePanel;
    public GameObject dialogueE;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBoxText.gameObject.SetActive(false);
        dialogueNameText.gameObject.SetActive(false);
        dialoguePanel.SetActive(false);
        dialogueE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.GetInteractPressed() && playerScript.GetInputOverride())
        {
            EndDialogue();
        }
    }

    public void StartDialogue(string dialogue, string name, Color nameColor)
    {
        playerScript.SetInputOverride(true);

        dialogueBoxText.gameObject.SetActive(true);
        dialogueNameText.gameObject.SetActive(true);
        dialoguePanel.SetActive(true);
        dialogueE.SetActive(true);

        dialogueBoxText.text = dialogue;
        dialogueNameText.color = nameColor;
        dialogueNameText.text = name;
    }

    public void EndDialogue()
    {
        playerScript.SetInteractPressed(false);
        playerScript.SetInputOverride(false);

        dialogueBoxText.gameObject.SetActive(false);
        dialogueNameText.gameObject.SetActive(false);
        dialoguePanel.SetActive(false);
        dialogueE.SetActive(false);

        dialogueBoxText.text = "";
        dialogueNameText.text = "";
    }
}
