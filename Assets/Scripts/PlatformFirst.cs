using UnityEngine;

public class PlatformFirst : MonoBehaviour
{
    public static PlatformStatus platformFirstStatus;
    public SpawnHandler spawnHandler;
    private void Start() {
        platformFirstStatus = PlatformStatus.None;
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            platformFirstStatus = PlatformStatus.Current;
            PlatformController.activePlatform = transform;
            PlatformController.canChangePlatform = true;
            spawnHandler.RunSpawner();
        }
    }

    private void OnCollisionExit(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            platformFirstStatus = PlatformStatus.Previous;
        }
    }
}
