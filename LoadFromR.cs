using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LoadFromR : MonoBehaviour
{
    public Transform Spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void F1(){
        PhotonNetwork.Instantiate ("DREAM_FERRARI_F40_Alexander_Schick_6_j7kD0viYB", Spawner.position, Quaternion.identity, 0);
    }

    public void JusticeS(){
        PhotonNetwork.Instantiate ("Justice_Shark_Emyvel_Tibangin_a2NdViELo4n", Spawner.position, Quaternion.identity, 0);
    }

    public void Virus(){
        PhotonNetwork.Instantiate ("Human_Immunodeficiency_Virus_Karen_Vanderpool_8uc_D0CWIbl", Spawner.position, Quaternion.identity, 0);
    }
    
    public void Boom(){
        PhotonNetwork.Instantiate ("Dynamite_with_Timer_Hunter_Paramore_0q9sW5qkUuS", Spawner.position, Quaternion.identity, 0);
    }

    public void soda(){
        PhotonNetwork.Instantiate ("Vending_Machine_Don_Carson_0CX6wj64Swu", Spawner.position, Quaternion.identity, 0);
    }

    public void canon(){
        PhotonNetwork.Instantiate ("Simple_canon_Baptiste_SCHUTZ_8aM5_uKbHx0", Spawner.position, Quaternion.identity, 0);
    }

    public void Poke(){
        PhotonNetwork.Instantiate ("Low_Poly_Pokeball_Tipatat_Chennavasin_5XpesCyaPe_", Spawner.position, Quaternion.identity, 0);
    }
    public void Snow(){
        PhotonNetwork.Instantiate ("__Takeshi_NAGATA_bwP6lVEu351", Spawner.position, Quaternion.identity, 0);
    }

    public void Water(){
        PhotonNetwork.Instantiate ("Water_Cooler_Alex_SAFFY_Safayan_6zon_acGTIu", Spawner.position, Quaternion.identity, 0);
    }
    public void WallE(){
        PhotonNetwork.Instantiate ("TB_ch_prod_walle_5_P_Robert_Mark_fy6mNrmPpRH", Spawner.position, Quaternion.identity, 0);
    }
    public void Delorean(){
        PhotonNetwork.Instantiate ("Trans_Space_Time_Vessel_Anonymous_2DsxC1nrUiQ", Spawner.position, Quaternion.identity, 0);
    }
    public void Wash(){
        PhotonNetwork.Instantiate ("Washing_Machine_Alex_SAFFY_Safayan_aGuzGh2FJPa", Spawner.position, Quaternion.identity, 0);
    }
    public void Destroy(){
        GameObject[] Bullets = GameObject.FindGameObjectsWithTag("NerfBullets");
        foreach(GameObject NerfBullets in Bullets) {
            PhotonNetwork.Destroy (NerfBullets);
        }
    }
}
