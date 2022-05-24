using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLaunch : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //A physics hit object to store info im going to get about where the ray hit
            RaycastHit hitinfo;

            //the distance of the ray the i'm using
            float distanceofRay = 100;

            //Makes the ray from ray cast the mouse loctaion (hopefully)
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Raycast to where the mouse is
            Physics.Raycast(ray, out hitinfo, distanceofRay);

            if (hitinfo.transform.tag == "tip")
            {
                //Debug.Log("raycast HIT");
                
            }
            else if (hitinfo.transform.tag == "conneter")
            {
                Debug.Log("conneter online");
            }
            else if (hitinfo.transform.tag == "rocket control")
            {
                Debug.Log("Rocket control online");
            }
            else if (hitinfo.transform.tag == "fuel")
            {
                Debug.Log("fuel online");
            }
            else if (hitinfo.transform.tag == "thruster")
            {
                Debug.Log("thruster's are a go for launch");
            }
        }

    }
}
