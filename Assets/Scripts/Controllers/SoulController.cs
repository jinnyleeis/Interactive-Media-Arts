using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SoulController : MonoBehaviour
{
    private Animator anim;
    // 마우스로 클릭해서 인식 후 대화
    private SPACESCENEMANAGER spmanager;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        spmanager = FindObjectOfType<SPACESCENEMANAGER>();
        //there is only one comp of this type in this scene!
    }
    // Update is called once per frame

    private void OnMouseEnter()
    {
        anim.SetBool("Damage", true);
        anim.SetInteger("DamageType", 1);

    }

    private void OnMouseDown()
    {
        // 마우스로 클릭해서 인식 후 대화
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.gameObject);
            //1. 한번만 재생될 수 있게.
            //2. 마우스 위로 가져다 놓기만 해도. 클릭 말고는????

            if (hit.transform.gameObject.tag == "Soul") 
            {
                //conversation timeline start!!
                if(!spmanager.pd2play)
                {spmanager.pd2timelineplay();}
                

            }

            else if (hit.transform.gameObject.tag == "Book")
            {


            }

            
        }
    }
}
