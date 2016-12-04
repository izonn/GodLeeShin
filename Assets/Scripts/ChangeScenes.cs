using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public Object Scene;
    //public string sceneName;
    public float waitSec = 0;

    public void Start()
    {
        //Screen.SetResolution(480, 800, true);
        StartCoroutine(ChangeScene(waitSec, Scene));
    }

    public IEnumerator ChangeScene(float num, Object Scene)
    {
        Debug.Log("==ChangeScene==");
        Debug.Log("Scene Name : " + Scene.name);
        Debug.Log("Waiting Seconds : " + num);

        yield return new WaitForSeconds(num);
        SceneManager.LoadScene(Scene.name);
    }

    public void ChangeScene(Scene Scene)
    {
        Debug.Log("==ChangeScene==");
        Debug.Log("Scene Name : " + Scene.name);

        SceneManager.LoadScene(Scene.name);
    }
}