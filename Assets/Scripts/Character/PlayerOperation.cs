using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOperation : MonoBehaviour
{
    [Tooltip("Vector3です。")]
    public static Vector3 velocity;
    public static float stopf = 1;
    State state;

    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float applySpeed = 0.2f;
    [SerializeField] private PlayerCamera refCamera;

    public enum State {
        Normal,
        IsTalk,
    }

    public void SetState(State state)
    {
        this.state = state;

        if (state == State.Normal) {
            stopf = 1;
        }
        else if(state == State.IsTalk) {
            stopf = 0;
        }
    }
    public State GetState()
    {
        return state;
    }

    void Update() {
        if(stopf == 1) {
            velocity = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) {
                velocity.z += 1;
            }
            if (Input.GetKey(KeyCode.A)) {
                velocity.x -= 1;
            }
            if (Input.GetKey(KeyCode.S)) {
                velocity.z -= 1;
            }
            if (Input.GetKey(KeyCode.D)) {
                velocity.x += 1;
            }

            velocity = velocity.normalized * moveSpeed * Time.deltaTime;

            if (velocity.magnitude > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.LookRotation(refCamera.hRotation * -velocity),
                    applySpeed);

                transform.position += refCamera.hRotation * velocity;
            }
        }
    }
}
