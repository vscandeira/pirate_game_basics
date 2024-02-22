using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float ExplosionDelay = 5f;
    public List<GameObject> Exp;
    public float BlastRadius = 2.5f;
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
        // Destroy bomb
        Destroy(gameObject);

        // Create explosion
        Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Quaternion q = new Quaternion(0,0,0,0);
        Instantiate(Exp[0], pos, q);

        // Destroy plataforms
        Collider[] colliders = Physics.OverlapSphere(transform.position, BlastRadius);
        foreach(Collider collider in colliders) {
            GameObject hitObject = collider.gameObject;
            if (hitObject.CompareTag("Plataform")) {
                Destroy(hitObject);
            }
        }
        // SFX
        // Verify player

    }
}
