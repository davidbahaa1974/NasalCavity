using UnityEngine;

public class SqueezeBox : MonoBehaviour
{
    public SqueezeObject target;
    public float forceMultiplier = 0.005f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == target.gameObject)
        {
            float force = collision.relativeVelocity.magnitude * forceMultiplier;
            target.Squeeze(force);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == target.gameObject)
        {
            target.ResetSqueeze();
        }
    }
}
