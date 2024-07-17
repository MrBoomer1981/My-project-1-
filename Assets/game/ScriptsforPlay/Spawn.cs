using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject template;
    public Vector3 offset;
    public int objectCount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<objectCount; i++){
            Vector3 newPosition = transform.position+offset*i;
            Instantiate(template, newPosition, Quaternion.identity);
        }
    }

   
  
}
