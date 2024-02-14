using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private StateMachine stateMachine;
    public Idle idleState;
    public Walking walkingState;
    public float speed = 10f;
    void Start() {
        stateMachine = new StateMachine();
        idleState = new Idle(this);
        walkingState = new Walking(this);
        stateMachine.ChangeState(walkingState);
    }

    // Update is called once per frame
    void Update() {
        stateMachine.Update();
    }
}
