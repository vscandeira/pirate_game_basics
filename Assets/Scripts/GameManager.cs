using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public bool isGameOver {get;private set;}
    [SerializeField] private AudioSource musicPlayer;
    [SerializeField] private AudioSource gameOverPlayer;
    void Awake() {
        if(Instance != null && Instance != this){
            Destroy(this);
        } else {
            Instance = this;
            isGameOver = false;
        }
    }

    public void EndGame(){
        if(isGameOver) return;
        isGameOver = true;
        musicPlayer.Stop();
        gameOverPlayer.Play();
    }
}
