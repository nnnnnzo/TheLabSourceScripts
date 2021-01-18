using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Gun : MonoBehaviour
{
    public GameObject GunModel;
    public Transform GunEnd;
    public Transform Player;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (GunModel.activeSelf == true){
                GunModel.SetActive(false);
            }

            else if (GunModel.activeSelf == false){
                GunModel.SetActive(true);
                    
            }
            
        }
        if (Input.GetMouseButtonDown(0) && GunModel.activeSelf == true) {
            SpawnBulletAndShoot();
        }
        
    }
    void ShootBullet(GameObject bullet)
    {
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        bullet.GetComponent<Rigidbody>().AddForce(Player.forward * 1165f);
    }
    void SpawnBulletAndShoot(){
        var BulletInst = PhotonNetwork.Instantiate ("tinker", GunEnd.position, Player.transform.rotation, 0);
        ShootBullet(BulletInst);

    }
}
