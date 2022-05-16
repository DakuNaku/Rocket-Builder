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
    }
    //Spawner region's
    #region Thruster Spawn
    //spawns small thruster
    void GenerateST()
    {
        Instantiate(SmallT, spawnPointST.transform);
    }

    //spawns regular thruster
    void GenerateRT()
    {
        Instantiate(RegularT, spawnPointRT.transform);
    }

    //spawns large thruster
    void GenerateLT()
    {
        Instantiate(LargeT, spawnPointLT.transform);
    }
    #endregion

    #region Connecter Spawn
    //spawns small connecter
    void GenerateSC()
    {
        Instantiate(SmallC, spawnPointSC.transform);
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
}