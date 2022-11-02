using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokePrefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SmokeHalfLife());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SmokeHalfLife()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
