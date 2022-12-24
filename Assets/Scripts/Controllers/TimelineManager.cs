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
    //감독 역할 옵젝컴포넌트들 받아와라.
    //이걸 여기서 

    public Button button0;
    public Camera targetCam;
    //public bool isfirsttimeline;
    //씬마다, 초기화해서 이 스크립트를 재활용하자!! 
    //첫 타임라인을 pd로 받고, 나머지를 이용하자 
    //앞의 타임라인의 시간이 다 되었다면, 
    //파라미터로 앞 타임라인 변수를 받는다!! 
    //이전것, 자기것 - 함수 각 조건에 맞게 실행!! 
    
    
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
        //if (pd0.time >= pd0.duration)
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
