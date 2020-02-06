using UnityEngine;

public class EnemySpawner : MonoBehaviour, IInteractable {

    public GameObject enemy;
    private GameObject newEnemy;
    private Vector3 newPos;

    private void Start() {
    }
    public void Spawn(Transform initialPosition) {
        if(newEnemy == null) {
            newEnemy = Instantiate(enemy) as GameObject;
        }
        newPos = initialPosition.position;
        newPos.y += 0.39f;
        newEnemy.transform.position = newPos;
        newEnemy.SetActive(true);
    }
}
