using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform Player;

    [SerializeField] private float distance = 10.0f;
    [SerializeField] private float turnSpeed = 10.0f;
    [SerializeField] private Quaternion vRotation;
    [SerializeField] public Quaternion hRotation;

    // Start is called before the first frame update
    void Start()
    {
        vRotation = Quaternion.Euler(30, 0, 0);
        hRotation = Quaternion.identity;
        transform.rotation = hRotation * vRotation;

        transform.position = Player.position - transform.rotation * Vector3.forward * distance;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            hRotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * turnSpeed, 0);

            transform.rotation = hRotation * vRotation;

            transform.position = Player.position + new Vector3(0, 3, 0) - transform.rotation * Vector3.forward * distance;
        }

        transform.position = Player.position - transform.rotation * Vector3.forward * distance;
    }
}
