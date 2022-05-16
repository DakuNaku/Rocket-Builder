using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    public Button thrusterS;
    public GameObject thruster;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        thrusterS.onClick.AddListener(Generatets);
    }

    void Generatets()
    {
        Instantiate(thruster, spawnPoint.transform);
    }

}
