using UnityEngine;

public class SqueezePart : MonoBehaviour
{
    public Transform mainObject; 
    public Vector3 squeezedScale = new Vector3(1f, 0.5f, 1f);
    public float speed = 5f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = mainObject.localScale;
    }

    void Update()
    {
        // PingPong creates a value that goes from 0 to 1 and back continuously
        float t = Mathf.PingPong(Time.time * speed, 1f);
        
        // Lerp between original scale and squeezed scale based on the pingpong value
        mainObject.localScale = Vector3.Lerp(originalScale, squeezedScale, t);
    }
}
