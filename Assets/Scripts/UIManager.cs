using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI killText;
    public TextMeshProUGUI gemText;

    public GameObject gem;

    int score;
    int kills;
    int gems;
    public static UIManager Instance { get { return _instance; } }

    private void Awake() {
        
        if(_instance != null && _instance != this) {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    public void ChangeScore() {
        ++score;
        scoreText.text = score.ToString();
    }

    public void ChangeKills() {
        ++kills;
        killText.text = kills.ToString();
    }

    public void ChangeGems() {
        gemText.text = kills.ToString();
    }
}
