using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour, IInteractable {
    Vector3 newPos;
    public Transform obstacles;
    public void Spawn(Transform initialPosition) {
        newPos = initialPosition.position;
        newPos.z += 1;
        obstacles.position = newPos;
    }
}
