using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public static int enemyHealth;
    public GameObject gem;

    Vector3 newGemPos;
    private void Start() {
        enemyHealth = health;
        gem = FindObjectOfType<Gem>().gameObject;
    }
    private void Update() {
        if(enemyHealth <= 0) {
            gameObject.SetActive(false);
            newGemPos = transform.position;
            newGemPos.y += 0.2f;
            gem.transform.position = newGemPos;
            gem.SetActive(true);
            
        }
    }
    public static void ChangeHeath(int healthToDeduct) {
        enemyHealth -= healthToDeduct;

        if(enemyHealth <= 0) {
            PlayerShooting.canShoot = false;
            Player.canStop = false;
            UIManager.Instance.ChangeKills();
        }
    }
}
