//using System.Numerics;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static Unity.Mathematics.math;

public class Gamemanager : MonoBehaviour
{

      
    public GameObject Horse1; 
    public GameObject Horse2;
   public GameObject doshman1;
      public GameObject doshman2;

    public GameObject Ghahraman;


    public Text TextScore;
 

    public static int Score = 0;
   
 

   
       public void Horse()
    {
        Score += 4;
        TextScore.text = Score.ToString()+" / 20";

       
        if (MainMenu.HorseNum == 1){
        Horse1.SetActive(false);
        int x = Random.Range(-7,6);

        Horse1.transform.position = new Vector3(x, 6);
        Horse1.SetActive(true);

        }

         if (MainMenu.HorseNum == 2){
        Horse2.SetActive(false);
        int x = Random.Range(-7,6);

        Horse2.transform.position = new Vector3(x, 6);
        Horse2.SetActive(true);

        }
        MainMenu.HorseNum = 0;
        checkScore();
        
       

    }

    

    public void lostHorse()
    {
        if (MainMenu.HorseNum == 1){
        Horse1.SetActive(false);
        int x = Random.Range(-7,6);

        Horse1.transform.position = new Vector3(x, 6);
        Horse1.SetActive(true);

        }

         if (MainMenu.HorseNum == 2){
        Horse2.SetActive(false);
        int x = Random.Range(-7,6);

        Horse2.transform.position = new Vector3(x, 6);
        Horse2.SetActive(true);

        }
        MainMenu.HorseNum = 0;
        checkScore();
        
       
    

}


  public void doshman()
    {
        Score -= 2;
        TextScore.text = Score.ToString()+" / 20";

       
        if (MainMenu.doshmanNum == 1){
      doshman1.SetActive(false);
        int x = Random.Range(-7,6);

        doshman1.transform.position = new Vector3(x, 6);
        doshman1.SetActive(true);

        }

         if (MainMenu.doshmanNum == 2){
        doshman2.SetActive(false);
        int x = Random.Range(-7,6);

        doshman2.transform.position = new Vector3(x, 6);
        doshman2.SetActive(true);

        }
        MainMenu.doshmanNum = 0;
        checkScore();
        
       

    }

    

    public void lostdoshman()
    {
        if (MainMenu.doshmanNum == 1){
        doshman1.SetActive(false);
        int x = Random.Range(-7,6);

        doshman1.transform.position = new Vector3(x, 6);
        doshman1.SetActive(true);

        }

         if (MainMenu.HorseNum == 2){
        doshman2.SetActive(false);
        int x = Random.Range(-7,6);

        doshman2.transform.position = new Vector3(x, 6);
        doshman2.SetActive(true);

        }
        MainMenu.doshmanNum = 0;
        checkScore();
        
       
    

}


private void checkScore(){

    if (Score >= 20)
    {
        SceneManager.LoadScene("Win")  ;
    }   
    else if (Score < 0)
   
 {
        SceneManager.LoadScene("GameOver");
    }


}

}
    