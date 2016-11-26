using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

    public string sceneName;
    public float waitSec = 0;

    public void Start()
    {
        StartCoroutine(WaitSeconds(waitSec));
    }

    public void ChangeScene (string sceneNm) {
        Debug.Log("==ChangeScene==");
        Debug.Log("Scene Name : " + sceneNm);

        SceneManager.LoadScene(sceneNm);
    }

    IEnumerator WaitSeconds(float num)
    {
        Debug.Log("Waiting Seconds : " + num);
        yield return new WaitForSeconds(num);
        ChangeScene(sceneName);
    }
}
