using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TintScreen : MonoBehaviour
{
    [SerializeField] Image screenCover;
    [SerializeField] Color untintedColor;
    [SerializeField] Color tintedColor;
    float tint;
    [SerializeField] float speed;

    [ContextMenu("Tint")]
    public void Tint()
    {
        StopAllCoroutines();
        tint = 0f;
        StartCoroutine(TintScreenCoroutine());
    }
    [ContextMenu("Untint")]

    public void UnTint()
    {
        StopAllCoroutines();
        tint = 0f;
        StartCoroutine(UntintScreenCoroutine());
    }

    IEnumerator TintScreenCoroutine()
    {
        while(tint < 1f)
        {
            tint += Time.deltaTime * speed;
            tint = Mathf.Clamp01(tint);

            Color color = screenCover.color;
            color = Color.Lerp(untintedColor,tintedColor, tint);
            screenCover.color = color;

            yield return new WaitForEndOfFrame();

        }
    }

    IEnumerator UntintScreenCoroutine()
    {
        while(tint < 1f)
        {
            tint += Time.deltaTime * speed;
            tint = Mathf.Clamp01(tint);

            Color color = screenCover.color;
            color = Color.Lerp(tintedColor,untintedColor, tint);
            screenCover.color= color;

            yield return new WaitForEndOfFrame();
        }
    }
}
