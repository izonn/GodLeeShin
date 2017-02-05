using UnityEngine;
using System.Collections;

public class LogoFade : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime * 2;
            yield return null;
        }
        canvasGroup.interactable = true;
        yield return null;
    }
}
