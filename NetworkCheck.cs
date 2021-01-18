using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NetworkCheck : MonoBehaviour
{
    public Sprite OK;
    public Sprite NO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            GetComponent<Image>().sprite = NO;
        }
        else {
            GetComponent<Image>().sprite = OK;
        }
        
    }
}
