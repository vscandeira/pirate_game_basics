using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    void Update() {
    }

    void OnTriggerEnter(Collider other) {
        GameObject hitObject = other.gameObject;
        if(hitObject.CompareTag("Player")){
            GameManager.Instance.EndGame();
        }
    }
}
