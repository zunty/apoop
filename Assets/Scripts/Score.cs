using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public int score;

    // Update is called once per frame
    void Update () {
        score = (int)player.position.x + 37;
        scoreText.text = score.ToString();
	}
}
