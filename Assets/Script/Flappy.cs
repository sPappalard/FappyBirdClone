using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public AudioClip[] audioClips;          //dato che qui mi servono 2 suoni, creo una lista di AudioClip 
    AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !GameController.gameover)            //ogni click sinistro del mouse 
        {
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, 7f);      //faccio fare un salto verticale di 7f
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)      //metodo attivato quando un oggetto entra in collisione
    {
        audioSource.PlayOneShot(audioClips[1]);
        GameController.gameover = true;
        gameover.SetActive(true);       //attivo la scritta gameover    
        restart.SetActive(true);        //attivo pulsante restart
    }
}
