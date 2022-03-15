using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram_Fade : MonoBehaviour
{
    public SkinnedMeshRenderer _HologramObj;

    private void Start()
    {
        _HologramObj = GetComponent<SkinnedMeshRenderer>();

        //makes the hologram material be invisible when the game starts
        GetComponent<SkinnedMeshRenderer>().enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //  makes the materal appear back into scene when player collides with it, fixed problem meant to be oncollisionenter not trigger
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SkinnedMeshRenderer>().enabled = true;
            Debug.Log("Appeared");

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // makes material of hologram disappear again when player is out of collision radius
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SkinnedMeshRenderer>().enabled = false;
            Debug.Log("Appeared");

        }
    }







}
