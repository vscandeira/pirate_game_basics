using UnityEngine;
public class Idle: State {
    private PlayerController controller;
    public Idle(PlayerController controller) : base("Idle") {
        this.controller = controller;
    }

    public override void Enter() {
        base.Enter();
        Debug.Log("Idle in.");
    }
    public override void Exit() {
        base.Exit();
        Debug.Log("Idle out.");
    }
    public override void Update() {
        base.Update();
    }
    public override void LateUpdate() {
        base.LateUpdate();
    }
    public override void FixedUpdate() {
        base.FixedUpdate();
    }
}