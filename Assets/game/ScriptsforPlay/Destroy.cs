using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string DestroyTag;
    public GameObject DestroyedPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Collider col = collision.collider;
        GameObject other = col.gameObject;

        if(other.tag == DestroyTag)
        {
            Instantiate(DestroyedPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

