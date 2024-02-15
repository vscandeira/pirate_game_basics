using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public StateMachine stateMachine;
    [HideInInspector] public Idle idleState;
    [HideInInspector] public Walking walkingState;
    [HideInInspector] public Vector3 movementVector;
    [HideInInspector] public Rigidbody thisRigidbody;
    public float speed = 10f;

    void Awake() {
        thisRigidbody = GetComponent<Rigidbody>();
    }
    void Start() {
        stateMachine = new StateMachine();
        idleState = new Idle(this);
        walkingState = new Walking(this);
        stateMachine.ChangeState(idleState);
    }

    // Update is called once per frame
    void Update() {
        bool isUp = Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow);
        bool isDown = Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow);
        bool isLeft = Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow);
        bool isRight = Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow);
        float inputZ = isUp ? 1 : isDown ? -1 : 0;
        float inputX = isRight ? 1 : isLeft ? -1 : 0;

        movementVector = new Vector3(inputX, 0, inputZ);

        stateMachine.Update();
    }
    void FixedUpdate() {
        stateMachine.FixedUpdate();
    }
    void LateUpdate() {
        stateMachine.LateUpdate();
    }

    public Quaternion GetFoward() {
        Camera camera = Camera.main;
        float eulerY = camera.transform.eulerAngles.y;
        return Quaternion.Euler(0,eulerY,0);
    }

    void OnGUI() {
        GUI.Label(new Rect(5,5,400,100), stateMachine.currentStateName);
    }
}
