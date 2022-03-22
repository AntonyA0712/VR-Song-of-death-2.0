using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TV_Screen : MonoBehaviour
{
    public GameObject _PlayScreen;

    

    private void Start()
    {
        _PlayScreen.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_Hands")
        {
            _PlayScreen.SetActive(true);
            
            Debug.Log("Screen Appears");
        }
    }
}
