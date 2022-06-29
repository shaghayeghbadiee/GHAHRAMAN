using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{

    void Update()
    {
        
    }

    public void BtnBack() {
       SceneManager.LoadScene("Menu");
    }
}
