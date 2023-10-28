using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour         //usato per spawnare i Prefabs(elementi che appaiono casualmente ogni tot, come i Tubi)
{
    float spawnTimer;       //tempo che intercorre tra uno spawn e l'altro
    float spawnRate = 3f;   //frequenza di spawn (3f--> ogni 3 secondi)
    public GameObject tubo;

    public static bool gameover;             //variabile pubblica e statica--> può essere letta e modificata da tutti gli script del gioco



    void Start()
    {
        
    }

    void Update()
    {


        if (!gameover)
        {
            spawnTimer += Time.deltaTime;               //aggiungo la durata del frame appena trascorso--> spawnTimer cresce ad ogni frame

            if (spawnTimer >= spawnRate)
            {               //quando sarà >= a 3 Secondi 
                spawnTimer -= spawnRate;                //sottraggo 3 secondi così sarà circa uguale a 0 e sarà pronto per il prossimo conteggio

                Vector2 spawnPos = new Vector2(7f, UnityEngine.Random.Range(3f, 6f));  //calcolo posizione dove spawnare--> posizione orizzontale = 7f; posizione Verticale --> varia in modo causale Random.Range(valore minimo,valore max) --> posizione sarà un valore casuale tra minimo e massimo

                Instantiate(tubo, spawnPos, Quaternion.identity);  //spawno il tubo in posizione spawnPos, Quaternion.identity--> mi dice che l'oggetto non verrà ruotato

            }
        }
    }
}


