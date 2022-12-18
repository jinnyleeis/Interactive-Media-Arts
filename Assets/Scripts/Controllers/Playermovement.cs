using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour {
    
    public float speed = 8f; // 이동 속력
    public float rotationSpeed;
  //  private TimelineManager tm;
    public GameObject player1;
    private GameObject player;
    Vector3 _destPos;
    
    private followcam changemethodscript;

    private void Start()
    {
        player = player1;
        changemethodscript = FindObjectOfType<followcam>();
       // tm = FindObjectOfType<TimelineManager>();
    }





    void Update() {
       
        // 수평과 수직 축 입력 값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력 값과 이동 속력을 통해 결정
       float xSpeed = xInput * speed;
       float zSpeed = zInput * speed;
       //Vector3 dir = _destPos - transform.position;
        // Vector3 destination = new Vector3 (35770, -6850, -2632);
        //Vector3 dir = _destPos - transform.position;

        // Vector3 속도를 (xSpeed, 0, zSpeed)으로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity를 할당
        
        float angle = Mathf.Atan2(newVelocity.x, newVelocity.z) * Mathf.Rad2Deg;
            
        //뒤를 바라볼 때는 이동만
        if(Mathf.Abs(angle) < 180)
        {
            angle = angle * rotationSpeed * Time.deltaTime;
            player.transform.Rotate(Vector3.up, angle);
        }
      
        player.transform.position += newVelocity * Time.deltaTime;
     

        
        
       
       

        //만약, x,z인풋이 없다면, speed 도 없을 것이다! 

    }
    
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
      //  if (other.tag == "wall")
       // {

        //    print("player1");
           // tm.blackholetimeline();
           // SceneManager.LoadScene("Studio");
            //StartCoroutine(COROUTINE());


       // }
    }

    public void Die() {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}