using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class followcam : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;
    public CinemachineVirtualCamera vCam3;
    //public CinemachineBlendListCamera blendListCam;
    //public CinemachineFreeLook freeLookCam;
    public GameObject[] gobs;

    public void farspot()
    {
        vCam1.MoveToTopOfPrioritySubqueue();
    }

    public void nearspot()
    {
        vCam2.MoveToTopOfPrioritySubqueue();
        foreach (GameObject obj in gobs)
        {
            obj.SetActive(true);
        }
    }

    public void buttonVirtual3()
    {
        vCam3.MoveToTopOfPrioritySubqueue();
    }
}