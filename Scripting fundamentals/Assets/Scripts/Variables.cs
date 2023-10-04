using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Public Global/Member Variables
    public int Score = 0; // declare a whole number
    public float ItemAmount = 19.95f; //decimal number
    public string PlayerName = "Frazbear"; // declare a text 
    public bool IsPlayerActive = true; //declare a true/false statement 

    //private global/member variables 
    private int _colletctibleAmount = 0; //total amount of score
    private float _horizontalInput =  0f; 
    private string _username = "rizzbear"; //Username that cant be changed 
    private bool _isGameOver = false;  //declare if the game is true/false


    // Start is called before the first frame update
    void Start()
    {
       //make sure score is equal to zero
       Score = 0; //assinging a Global/Member variable

        // declare a local variable to track start position
        Vector3 startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //trying to update a local variables value 
        //we cannot update a local variable 
        //startPosition = new Vector3 (Vector3.right);

        //create a variable to determine object key movement
        float verticalInput = Input.GetAxis("vertical");

    }
}
