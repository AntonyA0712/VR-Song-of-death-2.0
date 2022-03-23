using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram_Fade : MonoBehaviour
{
    public SkinnedMeshRenderer _HologramObj;

    public GameObject _Weapon;
    
    //public MeshRenderer _Handle;
   // public MeshRenderer _Nozzle;
    //public MeshRenderer _Barrel;
    //public MeshRenderer _Silencer;

    

    private void Start()
    {
        _HologramObj = GetComponent<SkinnedMeshRenderer>();

        //_Handle = GetComponent<MeshRenderer>();
        //_Nozzle = GetComponent<MeshRenderer>();
        //_Barrel = GetComponent<MeshRenderer>();
        //_Silencer = GetComponent<MeshRenderer>();

        //makes the hologram material be invisible when the game starts
        GetComponent<SkinnedMeshRenderer>().enabled = false;
        //GetComponent<MeshRenderer>().enabled = false;
        _Weapon.SetActive(false);
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //  makes the materal appear back into scene when player collides with it, fixed problem meant to be oncollisionenter not trigger
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SkinnedMeshRenderer>().enabled = true;
            //GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("Appeared");
            _Weapon.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        // makes material of hologram disappear again when player is out of collision radius
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SkinnedMeshRenderer>().enabled = false;
            //GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("Disappeared");
            _Weapon.SetActive(false);
        }
    }







}
