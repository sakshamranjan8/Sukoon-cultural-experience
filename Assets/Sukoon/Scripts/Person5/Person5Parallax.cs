using UnityEngine;

public class Person5Parallax : MonoBehaviour
{
    [System.Serializable]
    public class Layer
    {
        public Transform layerTransform;
        [Range(0f, 1f)] public float speed = 0.3f;
        private Vector3 startPos;
        private float startCamX;

        public void Init(float camX)
        {
            startPos = layerTransform.position;
            startCamX = camX;
        }

        public void Apply(float camX)
        {
            float delta = (camX - startCamX) * speed;
            layerTransform.position = new Vector3(startPos.x + delta, startPos.y, startPos.z);
        }
    }

    public Transform cameraTransform;
    public Layer[] layers;

    void Start()
    {
        if (cameraTransform == null && Camera.main != null)
            cameraTransform = Camera.main.transform;

        foreach (var l in layers)
            if (l.layerTransform != null)
                l.Init(cameraTransform.position.x);
    }

    void LateUpdate()
    {
        if (cameraTransform == null) return;
        float camX = cameraTransform.position.x;
        foreach (var l in layers)
            if (l.layerTransform != null)
                l.Apply(camX);
    }
}