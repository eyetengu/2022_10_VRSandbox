using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGrenade : MonoBehaviour
{
    [SerializeField] private GameObject _smokePrefab;

    void Start()
    {
        StartCoroutine(PullSmokeGrenadePin());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PullSmokeGrenadePin()
    {
        
        yield return new WaitForSeconds(2);
        Instantiate(_smokePrefab, transform.position, Quaternion.identity);
        
        yield return new WaitForSeconds(.1f);
        gameObject.SetActive(false);
    }
}
