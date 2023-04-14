using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<AudioSource>().volume < 0.18)
            gameObject.GetComponent<AudioSource>().volume += 0.0001f;
    }
}
