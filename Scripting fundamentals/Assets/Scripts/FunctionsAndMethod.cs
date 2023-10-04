using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//privates are underscored and publics are not
//intiger are whole numbers
//floats are decimals
public class FunctionsAndMethod : MonoBehaviour
{
    public int Score = 0;

    private int _playerHealthAmount = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //method examples 

    //this method is accessable from other files because it is public
    public void UpdatePlayerHealth(int amount)

    {
        _playerHealthAmount -= amount; 
    }
    //this method is accessable from other files because it is public
    private void IncreseScore()

    {
        Score++; //Score = Score + 1;
    }

    private void MovePlayer()
    {
        transform.Translate(Vector3.forward);
    }
}
