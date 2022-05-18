using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    #region Buttons,GameObjets&SpawnPoints
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
    public Button lauch;

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

    //In Game Objects;
    GameObject smallThruster;
    GameObject mediumThruster;
    GameObject largeThruster;
    GameObject smallConnector;
    GameObject mediumConnector;
    GameObject largeConnector;
    GameObject smallFuel;
    GameObject mediumFuel;
    GameObject largeFule;
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
    #endregion
    // Start is called before the first frame update
    //Just says if a button x is clicked spawn the conrasponding gameobject
    void Start()
    {
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

        largeThruster = Instantiate(LargeT, spawnPointLT.transform);
    }
    #endregion

    #region Connecter Spawn
    //spawns small connecter
    void GenerateSC()
    {

        smallConnector = Instantiate(SmallC, spawnPointSC.transform);
       // Debug.Log("connector working");
    }
    //spawns regular connecter
    void GenerateRC()
    {
        Instantiate(RegularC, spawnPointRC.transform);
    }
    //spawns Large connecter
    void GenerateLC()
    {
        Instantiate(LargeC, spawnPointLC.transform);
    }
    #endregion

    #region Fuel Spawn
    //spawns small fuel
    void GenerateSF()
    {
        Instantiate(SmallF, spawnPointSF.transform);
       // Debug.Log("fuel working");
    }
    //spawns regular fuel
    void GenerateRF()
    {
        Instantiate(RegularF, spawnPointRF.transform);
    }
    //spawns large fuel
    void GenerateLF()
    {
        Instantiate(LargeF, spawnPointLF.transform);
    }
    #endregion

    #region Tip Spawn
    //spawns small tip
    void GenerateSTi()
    {
        Instantiate(SmallTi, spawnPointSTi.transform);
        //Debug.Log("tip working");
    }
    //spawns regular tip
    void GenerateRTi()
    {
        Instantiate(RegularTi, spawnPointRTi.transform);
    }
    //spawns large tip
    void GenerateLTi()
    {
        Instantiate(LargeTi, spawnPointLTi.transform);
    }
    #endregion

    #region Rocket Control Spawn
    //spawns small rocket control
    void GenerateSR()
    {
        Destroy(mediumRocketControl, 0.0f);
        smallRocketControl = Instantiate(SmallR, spawnPointSR.transform);

        //Debug.Log("rocket control is working");
    }
    //spawns regular rocket control
    void GenerateRR()
    {
        Destroy(smallRocketControl, 0.0f);
        mediumRocketControl = Instantiate(RegularR, spawnPointRR.transform);
    }
    //spawns small rocket control
    void GenerateLR()
    {
        Instantiate(LargeR, spawnPointLR.transform);
    }
    #endregion

    // launch shit
    void Launch()
    {
        smallConnector.transform.parent = smallRocketControl.transform;

      
    }
}