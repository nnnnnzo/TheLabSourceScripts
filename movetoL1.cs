using UnityEngine;
using UnityEngine.SceneManagement;

public class movetoL1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneL1");
    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(1);
    }
}
