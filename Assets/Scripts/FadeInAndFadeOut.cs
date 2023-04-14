using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInAndFadeOut : MonoBehaviour
{
    double timeStamp;
    bool beginEnd;
    // Start is called before the first frame update
    void Start()
    {
        beginEnd = false;
        timeStamp = -2.1;
        gameObject.GetComponent<RawImage>().CrossFadeAlpha(0, 4, false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !beginEnd)
        {
            gameObject.GetComponent<RawImage>().CrossFadeAlpha(1, 2, false);
            beginEnd = true;
            timeStamp = Time.time;
        }

        if (timeStamp + 2 < Time.time && beginEnd)
        {
            Application.Quit();
        }
    }

}
