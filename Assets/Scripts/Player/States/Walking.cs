using UnityEngine;
public class Walking : State {
    private PlayerController controller;
    public Walking(PlayerController controller) : base("Walking") {
        this.controller = controller;
    }
    public override void Enter() {
        base.Enter();
        Debug.Log("Walk enter.");
    }
    public override void Exit() {
        base.Exit();
        Debug.Log("Walk exit.");
    }
    public override void Update() {
        base.Update();
        if(controller.movementVector.IsZero()){
            controller.stateMachine.ChangeState(controller.idleState);
            return;
        }

        Vector3 walkVector = controller.movementVector * Time.deltaTime * controller.speed;
        controller.transform.Translate(walkVector);
    }
    public override void LateUpdate() {
        base.LateUpdate();
    }
    public override void FixedUpdate() {
        base.FixedUpdate();
    }
}