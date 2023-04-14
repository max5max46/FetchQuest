using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    int peopleHelped;
    public GameObject winPanel;
    public GameObject winText;
    public GameObject winTextTwo;
    // Start is called before the first frame update
    void Start()
    {
        peopleHelped = 0;
        winPanel.SetActive(false);
        winText.SetActive(false);
        winTextTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (peopleHelped == 5 && Input.GetKeyDown(KeyCode.E))
        {
            winPanel.SetActive(true);
            winText.SetActive(true);
            winTextTwo.SetActive(true);
        }
    }

    public void NPCHelped()
    {
        peopleHelped++;
    }
}
