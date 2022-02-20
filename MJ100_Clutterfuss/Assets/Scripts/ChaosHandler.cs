using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Use this for handling chaos levels/scoring?
//Chaos level determines score (alongside other factors?).
//Attach to an empty object in the scene?
public class ChaosHandler : MonoBehaviour
{

    public float Chaos;
    public int Score;
    public int PaperNum;

    //Have timer here?
    //Will need displaying via Canvas Element.
    public float Timer;
    
    void Start()
    {
        Chaos = 0.0f;
        Score = 0;
        PaperNum = 0;
        Timer = 60f * 5; //5 Minutes.
    }

   
    void Update()
    {
        Timer -= Time.deltaTime;

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

    //Adds all factors together to give final score.
    public void returnScore()
    {

    }
}
