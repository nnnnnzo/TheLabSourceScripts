using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class SpawnMenu : MonoBehaviour
{
    public Text textClock;
    public GameObject Smenu;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKey(KeyCode.A)) {
            anim.Play("Menu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        if(Input.GetKey(KeyCode.Escape) && Smenu.active) {
            anim.Play("MenuHide");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        DateTime time = DateTime.Now;
        string hour = LeadingZero( time.Hour );
        string minute = LeadingZero( time.Minute );

        textClock.text = hour + ":" + minute;

        string LeadingZero (int n){
            return n.ToString().PadLeft(2, '0');
        }
    }
}
