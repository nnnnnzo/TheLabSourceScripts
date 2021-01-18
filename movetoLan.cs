using UnityEngine;
using UnityEngine.SceneManagement;

public class movetoLan : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneLan");
    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(2);
    }
}
