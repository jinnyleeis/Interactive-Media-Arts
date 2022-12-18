using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerAnimation : MonoBehaviour
{
    public float speed = 8f; // 이동 속력
    public float rotationSpeed;
    public GameObject player1;
    private GameObject player;
    private bool lastspeed;
    
    private followcam changemethodscript;

    [SerializeField]
    protected Vector3 _destPos;//목적지

    //[SerializeField]
   // protected Define.State _state = Define.State.Idle;//기본 state

    [SerializeField]
    protected GameObject _lockTarget;//target 구해야하는!

    public Define.WorldObject WorldObjectType { get; protected set; } = Define.WorldObject.Unknown;

  

    private void Start()
    {
        player = player1;
        changemethodscript = FindObjectOfType<followcam>();
        //Init();
        //여기서, mouseclicked 이벤트 이따가 받아오자!
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력 값과 이동 속력을 통해 결정
        float xSpeed = -xInput * speed;
        float zSpeed = -zInput * speed;
        float _speed;
        
        if (Mathf.Abs(xSpeed) > 0 || Mathf.Abs(zSpeed) > 0)
        {
            _speed = 10;
        }
        else
        {
            _speed = 0;
        }

        // Vector3 destination = new Vector3 (35770, -6850, -2632);

        // Vector3 속도를 (xSpeed, 0, zSpeed)으로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity를 할당
        
      //  if(lastspeed==false)



        if (xSpeed < 0)
        {
            lastspeed = true;

            player.transform.rotation = Quaternion.LookRotation(Vector3.left);
        }
        else if (xSpeed > 0)
        {
            lastspeed = true;
            player.transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else if (zSpeed < 0)
        {
            lastspeed = true;
            player.transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        else if(zSpeed>0)
        {
            lastspeed = true;
            player.transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        player.transform.position += newVelocity * Time.deltaTime;
        
        //만약, x,z인풋이 없다면, speed 도 없을 것이다! 
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("speed",_speed);//움직이는 값 보내주면 된다!! 
    /// switch (State)
       // {
         //   case Define.State.Die:
         //      UpdateDie();
          //     break;
          //  case Define.State.Moving:
          //     UpdateMoving();
          //      break;
           // case Define.State.Idle:
           //     UpdateIdle();
            //    break;
          //  case Define.State.Skill:
            //    UpdateSkill();
           //     break;
     //   }///
    }

    

    void UpdateDie() { }

    void UpdateMoving()
    {
      //  Vector3 dir = _destPos - transform.position;
        //dir.y = 0;

       // if (dir.magnitude < 0.1f)
        ////{
           // State = Define.State.Idle;
        //}
        //else
        //{
            
       // }
      


    }

    void UpdateIdle()
    {
        //Animator anim = GetComponent<Animator>();
       // anim.SetFloat("speed",0);//움직이는 값 보내주면 된다!! 
        
    }
   void UpdateSkill() { }
   
   void OnTriggerEnter(Collider other)
   {
       // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
       if (other.tag == "wall")
       {


           print("player1");
           SceneManager.LoadScene("Studio");
           //StartCoroutine(COROUTINE());


       }
   }
}