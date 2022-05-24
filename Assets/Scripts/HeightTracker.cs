using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightTracker : MonoBehaviour
{
    private Transform rocket;
    public GameObject Rocket;
    public Text heightReadOut;
    float rocketHeight;
    // Start is called before the first frame update
    void Start()
    {
        rocket = Rocket.transform;
    }

    // Update is called once per frame
    void Update()
    {
        rocketHeight = rocket.position.y;

        heightReadOut.text = rocketHeight.ToString();
        //Debug.Log(rocketHeight);
    }
}
