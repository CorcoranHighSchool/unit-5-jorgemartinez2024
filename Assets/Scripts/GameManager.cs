using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float spawnRate = 1.0f;
    public List<GameObject> targets;
    private int score;
    public TextMeshProUGUI scoreText;
    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }
    IEnumerator SpawnTarget(){
        while (true){
            yield return new WaitForSeconds(spawnRate);
            //spawn a target
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
