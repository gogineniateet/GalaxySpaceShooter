using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score;
       

    public void Score(int value)
    {
        score = score + value;
        Debug.Log("Score : " + score);
    }

}
