using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
