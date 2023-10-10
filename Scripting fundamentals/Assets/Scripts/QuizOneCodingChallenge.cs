using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    private int Health = 100;
    public string PlayerName = "Andres";
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DeacreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void UpdatePlayerHealth()

    {
        Health -= 20;
    }


    private void IncreaseScore()

    {
        Score += 10;
        //Score = Score + 10;
    }

    private void PrintPlayerName()

    {
        Debug.Log(PlayerName);
    }

    private void DeacreaseHealth()

    {
        Health -= 20;
    }
}


