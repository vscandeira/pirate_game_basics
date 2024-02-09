using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUp = Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow);
        bool isDown = Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow);
        bool isLeft = Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow);
        bool isRight = Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow);

        float movementZ = isUp ? 1 : isDown ? -1 : 0;
        float movementX = isRight ? 1 : isLeft ? -1 : 0;
        Vector3 movementVector = new Vector3(movementX, 0, movementZ);

        gameObject.transform.Translate(movementVector * Time.deltaTime * speed);
        
    }
}
