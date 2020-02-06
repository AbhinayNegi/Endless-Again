using UnityEngine;

public class Player : MonoBehaviour
{
    public SpawnHandler spawnHandler;

    public float speed;
    public float reducedSpeed;
    private float tempSpeed;
    public float jumpSpeed;
    public float maxJump;
    public float maxPull = 0.5f;
    public float gravityPullDownForce;

    public static bool canJump;
    public bool inAir;
    private bool canPullDown;
    private bool isObstacleNear;
    public static bool canStop = false;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!canJump && !canPullDown && !isObstacleNear && !canStop) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        
        if(canJump) {
           
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            canJump = false;
            isObstacleNear = false;
        }

        if(isObstacleNear) {
            canJump = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "Cube") {
            canJump = true;
        }
        if(other.tag == "Obstacles") {
            isObstacleNear = true;
        }
    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "FPlat" || other.gameObject.tag == "SPlat" || other.gameObject.tag == "TPlat") {
            //spawnHandler.RunSpawner();
        }
        FollowPlayer.changeFOV = false;
    }
    private void OnCollisionExit(Collision collision) {
        FollowPlayer.changeFOV = true;
    }
}
