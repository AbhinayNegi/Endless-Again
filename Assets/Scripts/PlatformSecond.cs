using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSecond : MonoBehaviour
{
    public static PlatformStatus platformSecondStatus;
    public SpawnHandler spawnHandler;
    private void Start() {
        platformSecondStatus = PlatformStatus.None;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            platformSecondStatus = PlatformStatus.Current;
            PlatformController.activePlatform = transform;
            PlatformController.canChangePlatform = true;
            spawnHandler.RunSpawner();
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            platformSecondStatus = PlatformStatus.Previous;
        }
    }
}
