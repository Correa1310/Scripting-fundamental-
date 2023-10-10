using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
   
{
    private int _PlayerHealthAmount = 100;
    
    public string PlayerName = "Andres";

    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AddTwoNumbers(4, 9));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private int AddTwoNumbers(int num1, int num2)
    {
        return num1 + num2; 
    }

    public void UpdatePlayerHealth(int amount)

    {
        _PlayerHealthAmount -= amount;
    }


    private void IncreaseScore()

    {
        Score = Score + 10;
    }


}
