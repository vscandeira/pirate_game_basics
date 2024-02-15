using UnityEngine;
public class Idle: State {
    private PlayerController controller;
    private bool fixedExecuted;
    public Idle(PlayerController controller) : base("Idle") {
        this.controller = controller;
        fixedExecuted = false;
    }

    public override void Enter() {
        base.Enter();
    }
    public override void Exit() {
        base.Exit();
    }
    public override void Update() {
        base.Update();
        if(!controller.movementVector.IsZero()){
            controller.stateMachine.ChangeState(controller.walkingState);
            controller.thisRigidbody.constraints = controller.originalConstraints;
            fixedExecuted = false;
            return;
        }
    }
    public override void LateUpdate() {
        base.LateUpdate();
    }
    public override void FixedUpdate() {
        base.FixedUpdate();
        if(!fixedExecuted){
            //Vector3 walkVector = controller.CreateWalk(-controller.pastMovementVector/5);
            //controller.thisRigidbody.AddForce(walkVector, ForceMode.VelocityChange);
            controller.thisRigidbody.constraints = RigidbodyConstraints.FreezePosition;
            fixedExecuted = true;
        }
    }
}