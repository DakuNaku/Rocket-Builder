using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    #region Buttons,GameObjets&SpawnPoints

    public Camera main;

    public Text heightReadOut;
    public Text maxHeightReached;

    public float rocketWieght;
    public float thrustValue;
    private float realThrust;
    float rocketHeight;
    float maxHeight = 0;
    bool maxReached = false;

    //UI Button
    public Button thrusterSmall;
    public Button thrusterRegular;
    public Button thrusterLarge;
    public Button connecterSmall;
    public Button connecterRegular;
    public Button connecterLarge;
    public Button fuelSmall;
    public Button fuelRegular;
    public Button fuelLarge;
    public Button tipSmall;
    public Button tipRegular;
    public Button tipLarge;
    public Button rocketcontrolSmall;
    public Button rocketcontrolRegular;
    public Button rocketcontrolLarge;
    public Button launch;
    public Button menu;
    public Button restart;
    public Button quit;

    //GameObjects
    public GameObject SmallT;
    public GameObject RegularT;
    public GameObject LargeT;
    public GameObject SmallC;
    public GameObject RegularC;
    public GameObject LargeC;
    public GameObject SmallF;
    public GameObject RegularF;
    public GameObject LargeF;
    public GameObject SmallTi;
    public GameObject RegularTi;
    public GameObject LargeTi;
    public GameObject SmallR;
    public GameObject RegularR;
    public GameObject LargeR;

    public GameObject ParentObject;

    //In Game Objects;
    GameObject smallThruster;
    GameObject mediumThruster;
    GameObject largeThruster;
    GameObject smallConnector;
    GameObject mediumConnector;
    GameObject largeConnector;
    GameObject smallFuel;
    GameObject mediumFuel;
    GameObject largeFuel;
    GameObject smallRocketControl;
    GameObject mediumRocketControl;
    GameObject largeRocketControl;
    GameObject smallTip;
    GameObject mediumTip;
    GameObject largeTip;

    //Spawn Points
    public Transform spawnPointST;
    public Transform spawnPointRT;
    public Transform spawnPointLT;
    public Transform spawnPointSC;
    public Transform spawnPointRC;
    public Transform spawnPointLC;
    public Transform spawnPointSF;
    public Transform spawnPointRF;
    public Transform spawnPointLF;
    public Transform spawnPointSTi;
    public Transform spawnPointRTi;
    public Transform spawnPointLTi;
    public Transform spawnPointSR;
    public Transform spawnPointRR;
    public Transform spawnPointLR;

    private Transform rocket;
    #endregion
    // Start is called before the first frame update
    //Just says if a button x is clicked spawn the conrasponding gameobject
    void Start()
    {
        realThrust = thrustValue - rocketWieght;
        rocket = ParentObject.transform;
        maxHeightReached.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);

        thrusterSmall.onClick.AddListener(GenerateST);
        thrusterRegular.onClick.AddListener(GenerateRT);
        thrusterLarge.onClick.AddListener(GenerateLT);
        connecterSmall.onClick.AddListener(GenerateSC);
        connecterRegular.onClick.AddListener(GenerateRC);
        connecterLarge.onClick.AddListener(GenerateLC);
        fuelSmall.onClick.AddListener(GenerateSF);
        fuelRegular.onClick.AddListener(GenerateRF);
        fuelLarge.onClick.AddListener(GenerateLF);
        tipSmall.onClick.AddListener(GenerateSTi);
        tipRegular.onClick.AddListener(GenerateRTi);
        tipLarge.onClick.AddListener(GenerateLTi);
        rocketcontrolSmall.onClick.AddListener(GenerateSR);
        rocketcontrolRegular.onClick.AddListener(GenerateRR);
        rocketcontrolLarge.onClick.AddListener(GenerateLR);
        launch.onClick.AddListener(Launch);
    }

    void Update()
    {
        if (rocket.position.y >= maxHeight)
        {
            maxHeight = rocket.position.y;
        }
        else
        {
            //has reached max height
            maxReached = true;
        }

        if(maxReached == true)
        {
            //call code that will happen once after reaching max height

            maxReached = false;
            //Debug.Log(" max hight reached good to go for other code");
            ParentObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            maxHeightReached.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
        }

        rocketHeight = rocket.position.y;
        heightReadOut.text = rocketHeight.ToString();


       // if(rocketHeight <= )

    }

    //Spawner region's
    #region Thruster Spawn
    //spawns small thruster
    void GenerateST()
    {
        Destroy(mediumThruster, 0.0f);
        Destroy(largeThruster, 0.0f);
        smallThruster = Instantiate(SmallT, spawnPointST.transform);
       // Debug.Log("thruster working");
    }

    //spawns regular thruster
    void GenerateRT()
    {
        Destroy(smallThruster, 0.0f);
        Destroy(largeThruster, 0.0f);
        mediumThruster = Instantiate(RegularT, spawnPointRT.transform);
    }
    //spawns large thruster
    void GenerateLT()
    {
        Destroy(smallThruster, 0.0f);
        Destroy(mediumThruster, 0.0f);
        largeThruster = Instantiate(LargeT, spawnPointLT.transform);
    }
    #endregion

    #region Connecter Spawn
    //spawns small connecter
    void GenerateSC()
    {
        Destroy(mediumConnector, 0.0f);
        Destroy(largeConnector, 0.0f);
        smallConnector = Instantiate(SmallC, spawnPointSC.transform);
       // Debug.Log("connector working");
    }
    //spawns regular connecter
    void GenerateRC()
    {
        Destroy(smallConnector, 0.0f);
        Destroy(largeConnector, 0.0f);
        mediumConnector = Instantiate(RegularC, spawnPointRC.transform);
    }
    //spawns Large connecter
    void GenerateLC()
    {
        Destroy(smallConnector, 0.0f);
        Destroy(mediumConnector, 0.0f);
        largeConnector = Instantiate(LargeC, spawnPointLC.transform);
    }
    #endregion

    #region Fuel Spawn
    //spawns small fuel
    void GenerateSF()
    {
        Destroy(mediumFuel, 0.0f);
        Destroy(largeFuel, 0.0f);
        smallFuel = Instantiate(SmallF, spawnPointSF.transform);
       // Debug.Log("fuel working");
    }
    //spawns regular fuel
    void GenerateRF()
    {
        Destroy(smallFuel, 0.0f);
        Destroy(largeFuel, 0.0f);
        mediumFuel = Instantiate(RegularF, spawnPointRF.transform);
    }
    //spawns large fuel
    void GenerateLF()
    {
        Destroy(smallFuel, 0.0f);
        Destroy(mediumFuel, 0.0f);
        largeFuel = Instantiate(LargeF, spawnPointLF.transform);
    }
    #endregion

    #region Tip Spawn
    //spawns small tip
    void GenerateSTi()
    {
        Destroy(mediumTip, 0.0f);
        Destroy(largeTip, 0.0f);
        smallTip = Instantiate(SmallTi, spawnPointSTi.transform);
        //Debug.Log("tip working");
    }
    //spawns regular tip
    void GenerateRTi()
    {
        Destroy(smallTip, 0.0f);
        Destroy(largeTip, 0.0f);
        mediumTip = Instantiate(RegularTi, spawnPointRTi.transform);
    }
    //spawns large tip
    void GenerateLTi()
    {
        Destroy(smallTip, 0.0f);
        Destroy(mediumTip, 0.0f);
        largeTip = Instantiate(LargeTi, spawnPointLTi.transform);
    }
    #endregion

    #region Rocket Control Spawn
    //spawns small rocket control
    void GenerateSR()
    {
        Destroy(mediumRocketControl, 0.0f);
        Destroy(largeRocketControl, 0.0f);
        smallRocketControl = Instantiate(SmallR, spawnPointSR.transform);
        smallRocketControl.transform.parent = ParentObject.transform;

        //Debug.Log("rocket control is working");
    }
    //spawns regular rocket control
    void GenerateRR()
    {
        Destroy(smallRocketControl, 0.0f);
        Destroy(largeRocketControl, 0.0f);
        mediumRocketControl = Instantiate(RegularR, spawnPointRR.transform);
        mediumConnector.transform.parent = ParentObject.transform;
    }
    //spawns small rocket control
    void GenerateLR()
    {
        Destroy(smallRocketControl, 0.0f);
        Destroy(mediumRocketControl, 0.0f);
        largeRocketControl = Instantiate(LargeR, spawnPointLR.transform);
        largeRocketControl.transform.parent = ParentObject.transform;
    }
    #endregion

    // launch shit
    void Launch()
    {
        //Debug.Log("im working");

        if (smallConnector != null) { smallConnector.transform.parent = smallRocketControl.transform; }
        if (smallFuel != null) { smallFuel.transform.parent = smallRocketControl.transform; }
        if (smallThruster != null) { smallThruster.transform.parent = smallRocketControl.transform; }
        if (smallTip != null) { smallTip.transform.parent = smallRocketControl.transform; }

        if (mediumConnector != null) { mediumConnector.transform.parent = mediumRocketControl.transform; }
        if (mediumFuel != null) { mediumFuel.transform.parent = mediumRocketControl.transform; }
        if (mediumThruster != null) { mediumThruster.transform.parent = mediumRocketControl.transform; }
        if (mediumTip != null) { mediumTip.transform.parent = mediumRocketControl.transform; }


        if (largeConnector != null) { largeConnector.transform.parent = largeRocketControl.transform; }
        if (largeFuel != null) { largeFuel.transform.parent = largeRocketControl.transform; }
        if (largeThruster != null) { largeThruster.transform.parent = largeRocketControl.transform; }
        if (largeTip != null) { largeTip.transform.parent = largeRocketControl.transform; }

        #region Camera follow
        if (smallRocketControl != null)
        {
            Debug.Log("camera being called");
            main.transform.parent = smallRocketControl.transform;
        }
        else if (mediumRocketControl != null)
        {
            main.transform.parent = mediumRocketControl.transform;
        }
        else if (largeRocketControl != null)
        {
            main.transform.parent = largeRocketControl.transform;
        }
        #endregion

        ParentObject.GetComponent<Rigidbody>().velocity = Vector3.up * realThrust;

        #region UI buttons off 
        thrusterSmall.gameObject.SetActive(false);
        thrusterRegular.gameObject.SetActive(false);
        thrusterLarge.gameObject.SetActive(false);
        connecterSmall.gameObject.SetActive(false);
        connecterRegular.gameObject.SetActive(false);
        connecterLarge.gameObject.SetActive(false);
        fuelSmall.gameObject.SetActive(false);
        fuelRegular.gameObject.SetActive(false);
        fuelLarge.gameObject.SetActive(false);
        rocketcontrolSmall.gameObject.SetActive(false);
        rocketcontrolRegular.gameObject.SetActive(false);
        rocketcontrolLarge.gameObject.SetActive(false);
        tipSmall.gameObject.SetActive(false);
        tipRegular.gameObject.SetActive(false);
        tipLarge.gameObject.SetActive(false);
        launch.gameObject.SetActive(false);
        #endregion
    }
}