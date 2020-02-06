using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        gameObject.SetActive(false);
        UIManager.Instance.ChangeScore();
        //play sound
    }
}
