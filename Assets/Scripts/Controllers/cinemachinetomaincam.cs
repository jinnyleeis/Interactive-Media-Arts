using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class cinemachinetomaincam : MonoBehaviour
{

    private SPACESCENEMANAGER spmanager;

    public Transform newmaincampos;
    public GameObject virtualcams;
    // Start is called before the first frame update
    
    void Start()
    {
       
        //all done vcam set: inactive
        //-> for optimization!!!
        //-> mostly for receive and controll maincam again!!**
        spmanager = FindObjectOfType<SPACESCENEMANAGER>();

        
        //position안할뻔.. 걍 newmaincampos라 쓰면, vec3 불가하다고 오류뜬다!!
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


   void  transition()
    {
        if (spmanager.pd1play && spmanager.pd1.state != PlayState.Playing && !spmanager.pd2play)
        {
            Camera.main.transform.position = newmaincampos.position;
            virtualcams.SetActive(false);

        }
        
    }
}
