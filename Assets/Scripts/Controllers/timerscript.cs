using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;


public class timerscript : MonoBehaviour
{
    private bool is_active = true;
    public Text[] text_time;
    public float time;
   // public PlayableDirector pd1,pdbus;
   // private bool pd1played;
    
    // Start is called before the first frame update
    void Start()
    {
       // pd1.Play();
       // pd1played = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (is_active) {
            time -= Time.deltaTime;
            text_time[0].text = ((int)time / 3600).ToString();
            text_time[1].text = ((int)time / 60%60).ToString();
            text_time[2].text = ((int)time % 60 ).ToString();

           // if (time <= 0&&pd1.state!=PlayState.Playing&&pd1played)
           // {
                
            //    pdbus.Play();
                
                
           // }
        }
        
    }
}
