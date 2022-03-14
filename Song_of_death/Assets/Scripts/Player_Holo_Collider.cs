using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Holo_Collider : MonoBehaviour
{
    Rigidbody _PlayerRB;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerRB = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enable")
        {
            Hologram_Fade.IsHide = false;

        }
        else if (other.gameObject.tag == "Disable")
        {
            Hologram_Fade.IsHide = true;
        }
    }
}
