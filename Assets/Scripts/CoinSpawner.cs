using UnityEngine;

public class CoinSpawner : MonoBehaviour,IInteractable
{
    public GameObject coinPrefab;

    public Transform[] coins;

    public void Spawn(Transform initialPos) {
        
        if(initialPos != null) {
            for (int i = 0; i < 4; i++) {
                coins[i].position = initialPos.position + new Vector3(0, 0.39f, i);
                coins[i].gameObject.SetActive(true);
            }
        }
        
    }

    void Start()
    {
        /*coins = new Transform[4];
        for (int i = 0; i < 4; i++) {
            coins[i] = Instantiate(coinPrefab).GetComponent<Transform>();
            coins[i].gameObject.SetActive(false);
        }*/
    }
    private void OnEnable() {
        coins = new Transform[4];
        for (int i = 0; i < 4; i++) {
            coins[i] = Instantiate(coinPrefab).GetComponent<Transform>();
            coins[i].gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
