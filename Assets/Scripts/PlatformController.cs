using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Transform firstPlatform; // to be deleted if 2nd approach works
    public Transform secondPlatform;
    public Transform thirdPlatform;

    public PlatformFirst platformFirst;
    public PlatformSecond platformSecond;
    public PlatformThird platformThird;

    public static Transform activePlatform;

    Vector3 newPos;
    Vector3 currenPos;
    float randomValueY;

    public static PlatformNumbers currentPlatform;
    public static PlatformStatus platformStatus;

    public static bool canChangePlatform = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canChangePlatform) {
            CheckForNextPlatform();
            SetPlatform();
            canChangePlatform = false;
        }
        
    }

    void SetPlatform() {
        /*if(currentPlatform == PlatformNumbers.FPlat) {
            Debug.Log(currentPlatform);
            newPosS = thirdPlatform.position + Vector3.forward * 30f;
            randomValueY = newPosS.y = Random.Range(0.03f, 2f);

            activePlatform = firstPlatform;
            activePlatform.position += new Vector3(0, randomValueY, 0);

            secondPlatform.position = newPosS;
        } else if(currentPlatform == PlatformNumbers.SPlat) {
            Debug.Log("2nd");
            newPosS = secondPlatform.position + Vector3.forward * 30f;
            randomValueY = newPosS.y = Random.Range(0.03f, 2f);

            activePlatform = secondPlatform;
            activePlatform.position += new Vector3(0, randomValueY, 0);

            firstPlatform.position = newPosT;
        } else if(currentPlatform == PlatformNumbers.TPlat) {
            Debug.Log("3rd");
            newPosS = firstPlatform.position + Vector3.forward * 30f;
            activePlatform = thirdPlatform;

            randomValueY = newPosS.y = Random.Range(0.03f, 2f);
            activePlatform.position += new Vector3(0, randomValueY, 0);

            secondPlatform.position = newPosS;
        }*/

        if(PlatformFirst.platformFirstStatus == PlatformStatus.Previous) {
            newPos = thirdPlatform.position + Vector3.forward * 28f;
            randomValueY = newPos.y = Random.Range(0.03f, 2f);
            firstPlatform.position = newPos;
        } else if(PlatformSecond.platformSecondStatus == PlatformStatus.Previous) {
            newPos = firstPlatform.position + Vector3.forward * 28f;
            randomValueY = newPos.y = Random.Range(0.03f, 2f);
            secondPlatform.position = newPos;
        } else if(PlatformThird.platformThirdStatus == PlatformStatus.Previous) {
            newPos = secondPlatform.position + Vector3.forward * 28f;
            randomValueY = newPos.y = Random.Range(0.03f, 2f);
            thirdPlatform.position = newPos;
        }
    }

    void CheckForNextPlatform() {
        
        if(PlatformFirst.platformFirstStatus == PlatformStatus.Current && 
            PlatformThird.platformThirdStatus == PlatformStatus.None) {
            PlatformSecond.platformSecondStatus = PlatformStatus.Next;
        }
        if(PlatformFirst.platformFirstStatus == PlatformStatus.Current && 
            PlatformThird.platformThirdStatus == PlatformStatus.Previous) {
            PlatformSecond.platformSecondStatus = PlatformStatus.Next;
        } else if(PlatformSecond.platformSecondStatus == PlatformStatus.Current &&
            PlatformFirst.platformFirstStatus == PlatformStatus.Previous) {
            PlatformThird.platformThirdStatus = PlatformStatus.Next;
        } else if(PlatformThird.platformThirdStatus == PlatformStatus.Current &&
            PlatformSecond.platformSecondStatus == PlatformStatus.Previous) {
            PlatformFirst.platformFirstStatus = PlatformStatus.Next;
        }
    }
}

public enum PlatformNumbers {

    FPlat,
    SPlat,
    TPlat,
}

public enum PlatformStatus {

    Previous,
    Current,
    Next,
    None
}
