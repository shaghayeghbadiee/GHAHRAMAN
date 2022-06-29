 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{public static int HorseNum =0;
public static int doshmanNum =0;

    void Update()
    {
        
    }

    public void BtnPlay() {
       SceneManager.LoadScene("PlayGame");
    }
}
