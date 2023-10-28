using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punti : MonoBehaviour
{
    public static int valorePunti;
    void Start()
    {
        valorePunti = 0;
    }

    void Update()
    {
        GetComponent<Text>().text = valorePunti.ToString(); 
    }
}
