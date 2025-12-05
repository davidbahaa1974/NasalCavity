using UnityEngine;
using System.Collections;

public class BlendshapeSqueeze : MonoBehaviour {
    public SkinnedMeshRenderer smr;
    public int blendIndex = 0;
    public float speed = 1f;
    public float targetWeight = 100f;

    void Start(){
        if(smr == null) smr = GetComponent<SkinnedMeshRenderer>();
    }

    public void StartSqueeze(){
        StartCoroutine(SqueezeCoroutine());
    }

    IEnumerator SqueezeCoroutine(){
        float start = smr.GetBlendShapeWeight(blendIndex);
        float t = 0f;
        while(t < 1f){
            t += Time.deltaTime * speed;
            float w = Mathf.Lerp(start, targetWeight, t);
            smr.SetBlendShapeWeight(blendIndex, w);
            yield return null;
        }
    }
}

