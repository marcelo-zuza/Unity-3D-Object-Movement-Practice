using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float boundsLimitUp = 30.0f;
    private float boundsLimitDown = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > boundsLimitUp)
        {
            Destroy(gameObject);
        }else if(transform.position.z < boundsLimitDown)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
