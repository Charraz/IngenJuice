using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Death", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
