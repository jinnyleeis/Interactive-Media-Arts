using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;


public class TimelineManager : MonoBehaviour
{
    public PlayableDirector pd0;
    public PlayableDirector pd1;

    private bool pd1play = false;
    //감독 역할 옵젝컴포넌트들 받아와라.
    //이걸 여기서 
    

    //public Camera targetCam;
    //public bool isfirsttimeline;
    //씬마다, 초기화해서 이 스크립트를 재활용하자!! 
    //첫 타임라인을 pd로 받고, 나머지를 이용하자 
    //앞의 타임라인의 시간이 다 되었다면, 
    //파라미터로 앞 타임라인 변수를 받는다!! 
    //이전것, 자기것 - 함수 각 조건에 맞게 실행!! 
    
    
    // Start is called before the first frame update
    void Start()
    {
       
       
       // pd = GetComponent<PlayableDirector>();
       
            pd0.Play();
            pd1.Stop();
    }

    // Update is called once per frame
    void Update()
    {
       playbyduration(pd0,pd1);

       
    }

    void timelinecounting(PlayableDirector pd0,PlayableDirector pd1)
    {
        if (pd0.time >= pd0.duration)
        {
           // if (Camera.main == targetCam)
            //{

             //   targetCam.GetComponent<CinemachineBrain>().enabled = false;
                
          //  }
            //씨네머신 이용한 카메라 비활성화! -씨네머신에서 벗어나 카메라 제어하기 위해!! 
           // targetCam.gameObject.SetActive(false);
            
        }
        //gameObject.SetActive(false);
        
    }

    public void playbyduration(PlayableDirector pd0,PlayableDirector pd1)
    {
        if (pd0.time >= pd0.duration)
        {
            // if (Camera.main == targetCam)
            //{

            //   targetCam.GetComponent<CinemachineBrain>().enabled = false;

            // }
            //씨네머신 이용한 카메라 비활성화! -씨네머신에서 벗어나 카메라 제어하기 위해!! 
            // targetCam.gameObject.SetActive(false);
            if (pd1play == false)
            {
                pd1.Play();
            }

            
        }

    }
        //gameObject.SetActive(false);
        
        
        
        
        
    

    public void playbyinteraction(PlayableDirector pd0,PlayableDirector pd1)
    {
        pd1.Play();
    }
}
