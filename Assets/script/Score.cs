using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Score : MonoBehaviour
{
    
   
    public GameObject Horse1; 
    public GameObject Horse2;
   public GameObject doshman1;
      public GameObject doshman2;
public GameObject gamemanager;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.CompareTag("Ghahraman"))
        {

            if (Horse1 )
            {
                MainMenu.HorseNum = 1;
                gamemanager.GetComponent<Gamemanager>().Horse();
            }

            if (Horse2 )
            {
                MainMenu.HorseNum = 2;
                gamemanager.GetComponent<Gamemanager>().Horse();
            }


              if (doshman1)
            {
                MainMenu.doshmanNum = 1;
                gamemanager.GetComponent<Gamemanager>().doshman();
            }

 if (doshman2 )
            {
                MainMenu.doshmanNum = 2;
                gamemanager.GetComponent<Gamemanager>().doshman();
            }

        }


         if(collision.CompareTag("Floor"))
        {

            
           
            if (Horse1 )
            {
                MainMenu.HorseNum = 1;
                gamemanager.GetComponent<Gamemanager>().lostHorse();
            }

 if (Horse2 )
            {
                MainMenu.HorseNum = 2;
                gamemanager.GetComponent<Gamemanager>().lostHorse();
            }






              if (doshman1)
            {
                MainMenu.doshmanNum = 1;
                gamemanager.GetComponent<Gamemanager>().lostdoshman();
            }

 if (doshman2 )
            {
                MainMenu.doshmanNum = 2;
                gamemanager.GetComponent<Gamemanager>().lostdoshman();
            }
          
    }
 }   
}