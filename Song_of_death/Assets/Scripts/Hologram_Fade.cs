using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram_Fade : MonoBehaviour
{
    public GameObject _gmObj;
    public static bool IsHide = false;

    // Update is called once per frame
    void Update()
    {
        if (IsHide)
        {
            _gmObj.SetActive(false);
        }
        else
        {
            _gmObj.SetActive(true);
        }
    }
}
