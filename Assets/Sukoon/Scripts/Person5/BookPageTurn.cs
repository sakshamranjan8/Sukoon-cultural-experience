using UnityEngine;
using System.Collections;

public class BookPageTurn : MonoBehaviour
{
    public Transform pageArea;
    public float turnDuration = 0.4f;

    public void OpenBook()
    {
        StopAllCoroutines();
        StartCoroutine(ScaleY(0f, 1f));
        pageArea.gameObject.SetActive(true);
    }

    public void CloseBook()
    {
        StartCoroutine(ScaleY(1f, 0f));
    }

    IEnumerator ScaleY(float from, float to)
    {
        float t = 0f;
        Vector3 scale = pageArea.localScale;
        while (t < turnDuration)
        {
            t += Time.deltaTime;
            scale.y = Mathf.Lerp(from, to, t / turnDuration);
            pageArea.localScale = scale;
            yield return null;
        }
    }
}