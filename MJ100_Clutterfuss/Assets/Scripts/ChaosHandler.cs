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

    public Transform BossSpawn;
    public GameObject BossOBJ;

    PlayerScript player;

    //Have timer here?
    //Will need displaying via Canvas Element.
    public float Timer;

    public IEnumerator CountDown()
    {
        while (true)
        {
            Timer -= Time.deltaTime;
        }
    }


    private void Awake()
    {
        player = GameObject.Find("PersonForGame").GetComponent<PlayerScript>();
    }

    void Start()
    {
        Chaos = 0.0f;
        Score = 0;
        PaperNum = 0;
        Timer = 60f; //* 5; //5 Minutes.
    }

   
    void Update()
    {
        StartCoroutine(CountDown());

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Timer <= 0)
        {
            StopCoroutine(CountDown());
            Instantiate(BossOBJ, BossSpawn.position, Quaternion.identity);
            player.Moving = false;
        }
        
    }

    //Adds all factors together to give final score.
    public void returnScore()
    {

    }
}
