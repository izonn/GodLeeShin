using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

    public string sceneName;

    void Start()
    {
        Debug.Log("Start");
        ChangeScene("f");
    }

    public void ChangeScene (string nm) {
        Debug.Log("화면 전환");
        Debug.Log(sceneName.ToString());
        //new WaitForSeconds(5);
        SceneManager.LoadScene(sceneName.ToString());
    }
}
