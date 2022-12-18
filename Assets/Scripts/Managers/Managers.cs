using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성이 보장된다
    static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고온다

	#region Contents
    #endregion

	#region Core
	
    ResourceManager _resource = new ResourceManager();
    SoundManager _sound = new SoundManager();
    UIManager _ui = new UIManager();
    PoolManager _pool = new PoolManager();

//여기서 instance를 이용하는구나!!! 
//매니저도 맨위에서 이와 같이, 자기 불러주면 이용하도록!! 
   
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static SoundManager Sound { get { return Instance._sound; } }
    public static UIManager UI { get { return Instance._ui; } }
    public static PoolManager Pool { get { return Instance._pool; } }
	#endregion

	void Start()
    {
        Init();
	}

    void Update()
    {
      //  _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
			GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
            
            s_instance._sound.Init();
            s_instance._pool.Init();
        }		
	}

    public static void Clear()
    {
        //Input.Clear();
        Sound.Clear();
        //Scene.Clear();
       // UI.Clear();
       Pool.Clear();
    }
}
