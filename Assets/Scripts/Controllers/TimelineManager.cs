using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimelineManager : MonoBehaviour
{
    public PlayableDirector pd0;
    public PlayableDirector pd1;
    public PlayableDirector pd2;

    private bool pd1play = false;
    private bool sceneload=false;

    private bool pd2play=false;
    private bool pass=false;
    public Button button0;
    public Camera targetCam;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
       
    
       
            pd0.Play();
          
            //접근 & 이벤트 등록
            button0.onClick.AddListener(Clicked0);
            
            
    }

    // Update is called once per frame
    void Update()
    {
        if(pd0.state!=PlayState.Playing && !pd1play)
        {
             if (Camera.main == targetCam)
            {
                targetCam.GetComponent<CinemachineBrain>().enabled = false;
            }
             pd1play = true;
            pd1.Play();
        }
        if(pd2.state != PlayState.Playing &&pd2play && pd1play&&!sceneload)
        {
            SceneManager.LoadScene("Studio");
            sceneload = true;
        }
    }
    public void blackholetimeline()
    {
        if(pd0.state!=PlayState.Playing && pd1play&&pd2play&&!pass)
        {
            pass = true;
            if (pd1.state == PlayState.Playing)
            {
                pd1.Stop();
            } 
            pd2.Play();
        }
    }
    void Clicked0() {
            //여기서 재생시키자. 
            if (pd1.state == PlayState.Playing)
            {
                pd1.Stop();
            }
            pd2.Play();
            pd2play = true;
    }


    
    
        
        
        
        
        
    

    public void playbyinteraction(PlayableDirector pd0,PlayableDirector pd1)
    {
        pd1.Play();
    }
}
