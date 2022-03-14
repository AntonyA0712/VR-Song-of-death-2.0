using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram_Fade : MonoBehaviour
{
    [SerializeField]
    public GameObject _HologramObj;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _HologramObj.SetActive(true);
            Debug.Log("Shows Hologram");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _HologramObj.SetActive(false);
            Debug.Log("Shows Hologram");
        }
    }


}
