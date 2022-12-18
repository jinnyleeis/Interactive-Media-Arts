using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminput : MonoBehaviour
{
    private followcam changemethodscript;

    private Playermovement playermovement;

    public GameObject player1;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        changemethodscript = FindObjectOfType<followcam>();
        changemethodscript.farspot();
        playermovement=FindObjectOfType<Playermovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(player1.transform.position.x>35770)
        // {
        //    player1.transform.position.y = 6805;
        // changemethodscript.nearspot();
    }
    // }
}