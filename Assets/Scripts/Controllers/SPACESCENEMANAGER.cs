using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;
using Cinemachine;
using GameObject = UnityEngine.GameObject;

public class SPACESCENEMANAGER : MonoBehaviour
{
    public GameObject[] effects;
    private VisualEffect[] vfxs;
    public int currentEffect = 0;
    public int nextEffect = 1;
    public bool pd1play;
    public bool pd2play = false;
    public bool isvfxuse = false;
    public GameObject[] pd2setactivefalse;
    public Camera cam;

    public PlayableDirector pd0, pd1, pd2;
    // Start is called before the first frame update
    void Start()
    {
        vfxs = new VisualEffect[effects.Length];
        for (int i = 0; i < effects.Length; ++i)
        {
            effects[i].SetActive(false);
            vfxs[i] = effects[i].GetComponent<VisualEffect>();
        }
        
     
        
        pd0.Play();
        if (isvfxuse)
        {

            effects[currentEffect].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (pd0.state != PlayState.Playing && !pd1play)
        {
            if (isvfxuse)
            {

                vfxs[currentEffect].Stop();
                effects[currentEffect].SetActive(false);
                effects[nextEffect].SetActive(true);
                vfxs[nextEffect].Play();
            }

            pd1play = true;
            pd1.Play();

           
        }

    }

    public void pd2timelineplay()
    {
        //only conditions about timeline are left in this manager script
        
        if (pd0.state != PlayState.Playing && pd1.state != PlayState.Playing&&pd1play)
        {
           
            
            for (int i = 0; i < pd2setactivefalse.Length; ++i)
            {
                pd2setactivefalse[i].SetActive(false);
            }
           cam.GetComponent<CinemachineBrain>().enabled = true;
            
            pd2.Play();
            pd2play = true;//wow this variable's  postition is very important

           
        }
    }
}
