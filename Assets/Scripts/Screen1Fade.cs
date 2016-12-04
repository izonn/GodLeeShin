using UnityEngine;
using System.Collections;

public class Screen1Fade : MonoBehaviour
{
    public void Fade() { StartCoroutine(DoFade()); }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime * 2; yield return null;
        }
        canvasGroup.interactable = false; yield return null;

        GameManager.instance.Screen2_Active();
    }
}