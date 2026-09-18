using UnityEngine;

public class TrainLandscapeScroll : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetX = 15f;
    private Vector3 startPos;

    void Start() => startPos = transform.localPosition;

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        if (transform.localPosition.x <= startPos.x - resetX)
            transform.localPosition = startPos;
    }
}