using UnityEngine;

//handles three spawn managers
public class SpawnHandler : MonoBehaviour
{
    public GameObject[] spawners;
    int spawnPointer;

    private void Update() {
        
        //Debug.Log(spawnPointer);
    }
    public void RunSpawner() {
        spawnPointer = Random.Range(-1, 3);
        spawnPointer = Mathf.Abs(spawnPointer);
        //Debug.Log(spawnPointer);
        //spawners[spawnPointer].GetComponent<IInteractable>().Spawn(PlatformController.activePlatform);
        //spawners[1].GetComponent<IInteractable>().Spawn(PlatformController.activePlatform);
        spawners[spawnPointer].GetComponent<IInteractable>().Spawn(PlatformController.activePlatform);
    }
}
