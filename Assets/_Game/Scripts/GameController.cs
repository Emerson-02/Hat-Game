using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int score;

    public float currentTime;
    [SerializeField] private float startTime;

    public bool gameStarted;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        currentTime = startTime;
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        CountdownTime();
    }

    public void CountdownTime()
    {
        if(currentTime > 0f && gameStarted)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {

            return;
        }
    }
}
