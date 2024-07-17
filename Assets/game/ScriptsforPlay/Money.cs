using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
            void OnCollisionEnter(Collision other) {
                PlayerStarts pStats;
                if (other.collider.TryGetComponent<PlayerStarts>(out pStats)){
                    pStats.coinCount+=1;
                    Debug.Log(pStats.coinCount + " " + pStats.gameObject);
                    Destroy(gameObject); 
                }
                else{
                    Debug.Log("No");
                }
                 
                
            
        }
}