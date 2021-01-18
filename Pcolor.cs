using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcolor : MonoBehaviour
{
    public GameObject PlayerModel;
    public Material red;
    public Material orange;
    public Material yellow;
    public Material green;
    public Material blue;
    public Material purple;
    public Material Gold;
    public Material Black;

    public void redS(){
        PlayerModel.GetComponent<Renderer>().material = red; 
    }
    public void orangeS(){
        PlayerModel.GetComponent<Renderer>().material = orange; 
    }
    public void yellowS(){
        PlayerModel.GetComponent<Renderer>().material = yellow; 
    }
    public void greenS(){
        PlayerModel.GetComponent<Renderer>().material = green; 
    }
    public void blueS(){
        PlayerModel.GetComponent<Renderer>().material = blue; 
    }
    public void purpleS(){
        PlayerModel.GetComponent<Renderer>().material = purple; 
    }
    public void GoldS(){
        PlayerModel.GetComponent<Renderer>().material = Gold; 
    }
    public void BlackS(){
        PlayerModel.GetComponent<Renderer>().material = Black; 
    }
    
}
