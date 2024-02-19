using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float ExplosionDelay = 5f;
    public List<GameObject> Exp;
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
        // Destroy plataforms
        // SFX
        // Verify player
        Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Quaternion q = new Quaternion(0,0,0,0);
        Instantiate(Exp[0], pos, q);
        // Destroy Objects
        Destroy(gameObject);
    }
}
