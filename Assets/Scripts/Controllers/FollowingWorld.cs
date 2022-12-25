using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingWorld : MonoBehaviour
{
    
    [Header("Tweaks")]
    [SerializeField] public Transform lookAt;
    [SerializeField] public Vector3 offset;

    [Header("Logic")] 
    private Camera cam;

    void Start()
    {
        cam=Camera.main;
        //The first enabled Camera component
        //that is tagged "MainCamera" (Read Only).
        
        gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = cam.WorldToScreenPoint(lookAt.position + offset);

        if (transform.position != pos)
        {
            transform.position = pos;
        }
        //for optimization!!

    }
}
