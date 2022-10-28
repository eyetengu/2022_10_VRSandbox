using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedReticles : MonoBehaviour
{
    public int _rotateSpeed= 2;

    void Start()
    {
        StartCoroutine(ReticlePulseTimer());
        transform.Rotate(90, 90, 90);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    

    IEnumerator ReticlePulseTimer()
    {
        yield return new WaitForSeconds(.2f);
        transform.localScale = Vector3.one;
        yield return new WaitForSeconds(.2f);
        transform.localScale = new Vector3(1.05f, 1f, 1.05f);
        StartCoroutine(ReticlePulseTimer());
        //_canPulse = true;
    }

}
