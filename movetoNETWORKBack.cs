using UnityEngine;
using UnityEngine.SceneManagement;

public class movetoNETWORKBack : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneL2");
    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(0);
    }
}
