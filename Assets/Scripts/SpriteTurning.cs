using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTurning : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
