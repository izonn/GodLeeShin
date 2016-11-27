using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public string sceneName;
    public float waitSec = 0;

    public void Start()
    {
        Screen.SetResolution(480, 800, true);
        StartCoroutine(ChangeScene(waitSec, sceneName));
    }

    IEnumerator ChangeScene(float num, string sceneNm)
    {
        Debug.Log("==ChangeScene==");
        Debug.Log("Scene Name : " + sceneNm);
        Debug.Log("Waiting Seconds : " + num);

        yield return new WaitForSeconds(num);
        SceneManager.LoadScene(sceneNm);
    }

    public void ChangeScene(string sceneNm)
    {
        Debug.Log("==ChangeScene==");
        Debug.Log("Scene Name : " + sceneNm);

        SceneManager.LoadScene(sceneNm);
    }
}