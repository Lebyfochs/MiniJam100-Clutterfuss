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
    
    void Start()
    {
        Chaos = 0.0f;
        Score = 0;
        PaperNum = 0;
    }

   
    void Update()
    {
        
    }
}
