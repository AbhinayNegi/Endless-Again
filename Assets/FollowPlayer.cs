using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraPos;
    Vector3 newPos;
    public float smoothSpeed;
    public float smoothSpeedCamera;
    Camera mainCamera;

    public static bool changeFOV = false;
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ChangeFOV();
        newPos = player.transform.position - cameraPos;
        transform.LookAt(player.transform);

        transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed * Time.deltaTime);
    }

    void ChangeFOV() {
        if(changeFOV) {
            mainCamera.fieldOfView = Mathf.Lerp(60, 80, smoothSpeedCamera * Time.deltaTime);
        } else {
            mainCamera.fieldOfView = 60;
        }
        
    }
}
