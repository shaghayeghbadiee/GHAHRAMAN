using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static string UserName;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
public void GetText(InputField input){//Get Value from Input
    UserName=input.text;
    Application.LoadLevel("main");
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
