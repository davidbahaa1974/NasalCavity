using UnityEngine;

public class SqueezeObject : MonoBehaviour
{
    public float squeezeAmount = 0.2f;  
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void Squeeze(float force)
    {
        float newScaleX = Mathf.Clamp(originalScale.x - force, originalScale.x - squeezeAmount, originalScale.x);
        transform.localScale = new Vector3(newScaleX, originalScale.y, originalScale.z);
    }

    public void ResetSqueeze()
    {
        transform.localScale = originalScale;
    }
}
