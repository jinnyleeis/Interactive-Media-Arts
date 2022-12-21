using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;

public class SPACESCENEMANAGER : MonoBehaviour
{
    public GameObject[] effects;
    private VisualEffect[] vfxs;
    public int currentEffect = 0;
    public int nextEffect = 1;
    private bool pd1play;
    public bool isvfxuse = false;

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
}
