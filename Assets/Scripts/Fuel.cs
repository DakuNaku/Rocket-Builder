using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fuel", menuName = "Fuel")]
public class Fuel : ScriptableObject
{
    public float FuelCapacity;
    public int FuelTankWieght;
    public GameObject fuel;
}