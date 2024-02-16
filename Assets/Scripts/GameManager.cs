using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 1.0f;
    public List<GameObject> targets;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
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
