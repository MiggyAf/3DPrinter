using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void PrintMode()
   {
        SceneManager.LoadScene(1);
   }

   public void FreeRoam()
   {
        SceneManager.LoadScene(2);
   }

   public void QuitGame()
   {
        Application.Quit();
   }

   public void ReturnMenu()
   {
     SceneManager.LoadScene(0);
   }
}
