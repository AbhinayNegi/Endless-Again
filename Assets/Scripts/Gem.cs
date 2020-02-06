using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            gameObject.SetActive(false);
            UIManager.Instance.ChangeGems();
        }
    }
}
