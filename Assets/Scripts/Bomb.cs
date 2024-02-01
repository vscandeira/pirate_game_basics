using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float ExplosionDelay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExpDelay(ExplosionDelay));   
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator ExpDelay(float delay){
        yield return new WaitForSeconds(delay);
        Explosion();
    }

    private void Explosion(){
        // VFX
        // Destroy plataforms
        // SFX
        // Verify player
        // Destroy Objects
        Destroy(gameObject);
    }
}
