using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public Text ChaosText;
    ChaosHandler chaos;


    private void Awake()
    {
        chaos = GameObject.Find("ChaosHandlingOBJ").GetComponent<ChaosHandler>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChaosText.text = Mathf.FloorToInt(chaos.Chaos).ToString();
    }
}
