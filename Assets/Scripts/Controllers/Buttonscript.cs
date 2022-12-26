using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttonscript : MonoBehaviour
{

    public bool isloaded = false;

    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(onclicked);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclicked()
    {
        if (!isloaded)
        {
            SceneManager.LoadScene("earthscene");
            isloaded = true;

        }
        
    }
}
