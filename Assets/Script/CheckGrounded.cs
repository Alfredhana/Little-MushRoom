using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour {
    private MushRoomAction2 player;

    public bool checkground;

    private void Start()
    {
        player = gameObject.GetComponentInParent<MushRoomAction2>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.grounded = true;
        checkground = player.grounded;
    }

    private void OnTriggerExit2D(Collider other)
    {
        player.grounded = true;
        checkground = player.grounded;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        player.grounded = false;
        checkground = player.grounded;
    }
}
