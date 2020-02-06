using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private Player player;
    public static bool canShoot;

    private float coolDownTimer;
    public float timeToWait;

    public Transform gunMuzzle;
    public GameObject projectiles;
    private void Start() {
        player = GetComponent<Player>();
    }

    private void Update() {
     
        if(canShoot && Enemy.enemyHealth > 0) {
            if(Time.time > coolDownTimer) {
                Instantiate(projectiles, gunMuzzle.position, Quaternion.Euler(new Vector3(90, 0, 0)));
                coolDownTimer = Time.time + timeToWait;
            }
        }
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.tag == "Enemy") {
            
            Player.canStop = true;
            canShoot = true;
        }
    }
}
