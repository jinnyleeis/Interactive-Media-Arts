using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class bookcontroller: MonoBehaviour
{

 
        
        private SPACESCENEMANAGER spmanager;
        private bool isbookopen = false;
        public AudioClip[] clips;
        public int number = 0;
        private AudioSource audio;
      
      
        private void Start()
        {
           audio = GetComponent<AudioSource>();
            spmanager = FindObjectOfType<SPACESCENEMANAGER>();
           
           
            
        }

        private void OnMouseEnter()
        {
           if(!audio.isPlaying)
           {audio.PlayOneShot(clips[number]);}
           
           
          
           
           
        }
        
       // private void OnMouseDown()
       // {
            // 마우스로 클릭해서 인식 후 대화
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

           // if (Physics.Raycast(ray, out hit))
            //{
             //   Debug.Log(hit.transform.gameObject);
                //1. 한번만 재생될 수 있게.
                //2. 마우스 위로 가져다 놓기만 해도. 클릭 말고는????
                

               // if (hit.transform.gameObject.tag == "Book")
               // {
                //   if (!isbookopen)
                 //   {
                  //      SceneManager.LoadScene("destinybookscene");
                   //     isbookopen = true;

                  //  }
                


            //    }

            
          //  }
      //  }

      
    }
