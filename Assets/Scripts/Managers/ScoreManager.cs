using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int round;
    public string winner;

    public void Awake() 
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWinner() 
    {
        // winner += m_GameWinner;
    }

    public void updateHighScore()
    {
        
    }
}
