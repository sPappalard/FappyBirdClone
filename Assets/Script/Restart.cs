using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
  public void ClickRestart()                        //medoto che si scatena al click del bottone restart
    {
        GameController.gameover = false;            // metto a false la variabile gameover
        SceneManager.LoadScene(0);                  //torno alla scena inziale
    }
}
