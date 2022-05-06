using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public AnimationCurve animationCurve;
    Animation animations;
    float curveTime = 3f;
    private float playerSpeed=3f;

    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<Animation>();
        animationCurve.Evaluate(curveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z += playerSpeed * Time.deltaTime;
        curveTime = Mathf.PingPong(curveTime,1f);
        currentPosition.y = animationCurve.Evaluate(curveTime);
        Debug.Log(currentPosition.y);
        transform.position = currentPosition;
        
    }
}
