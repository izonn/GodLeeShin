using UnityEngine;
using System.Collections;

public class LogoFade : MonoBehaviour {

    public double logoSpeed;
	// Use this for initialization
	void Start () {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime * (float)logoSpeed;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
    }
}
