using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    
    public GameObject thruster;
    public Transform spawnPoint;


    public void InstantiateCaller(GameObject thruster)
    {
        Instantiate(thruster, spawnPoint.transform);
    }


}
