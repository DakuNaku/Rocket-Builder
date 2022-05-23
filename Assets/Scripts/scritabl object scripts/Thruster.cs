using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Thruster", menuName = "Thruster")]
public class Thruster : ScriptableObject
{
    public int ThrusterSpeed;
    public float ThrusterDrain;
    public int ThrusterWieght;
    public GameObject thruster;
}

  
