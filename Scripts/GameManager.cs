using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;
    public float speedMultiplier;
    public TextMeshProUGUI distanceUI;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceUI.text = "Distance : " + distance.ToString("F2");
        speedMultiplier += Time.deltaTime * 0.1f;


        timer += Time.deltaTime;

        distance += Time.deltaTime * 0.8f;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 1);
            Instantiate(spawnObject,spawnPoints[randNum].transform.position,Quaternion.identity);
        }
    }
}
