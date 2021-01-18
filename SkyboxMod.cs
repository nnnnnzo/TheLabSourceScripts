using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxMod : MonoBehaviour
{
    public Material Day;
    public Material Night;
    // Start is called before the first frame update
    public void DayS(){
        RenderSettings.skybox = Day;
    }
    public void NightS(){
        RenderSettings.skybox = Night;
    }
}
