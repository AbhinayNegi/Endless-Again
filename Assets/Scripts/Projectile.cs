using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    Vector3 move;

    private void Start() {
        Invoke("DestroyProjectile", .6f);
    }
    private void Update() {
        move = new Vector3(0, speed * Time.deltaTime, 0);
        transform.Translate(move); 

        if(Enemy.enemyHealth <= 0) {
            Enemy.enemyHealth = 100;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Enemy") {

            if (other.gameObject.GetComponent<Enemy>()) {
                Enemy.ChangeHeath(50);
            }
        }
        Destroy(gameObject);
    }

    void DestroyProjectile() {
        Destroy(gameObject);
    }
}
