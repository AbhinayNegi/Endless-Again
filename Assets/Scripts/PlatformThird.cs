using UnityEngine;

public class PlatformThird : MonoBehaviour
{
    public static PlatformStatus platformThirdStatus;
    public SpawnHandler spawnHandler;
    private void Start() {
        platformThirdStatus = PlatformStatus.None;
    }

    
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            platformThirdStatus = PlatformStatus.Current;
            PlatformController.activePlatform = transform;
            PlatformController.canChangePlatform = true;
            spawnHandler.RunSpawner();
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            platformThirdStatus = PlatformStatus.Previous;
        }
    }
}
