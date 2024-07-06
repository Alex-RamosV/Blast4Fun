using AlterunaFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarLife : MonoBehaviour
{
    // Start variables
    Image image;
    private GameObject currentPlayer;

    //Use this for Offline Gameplay
    //[SerializeField]
    //PlayerController playerController;

    void Awake()
    {
        image = GetComponent<Image>();
    }
    
    void Update()
    {
        currentPlayer = GameObject.FindGameObjectWithTag("Player");

        if(currentPlayer != null )
        {
            Debug.Log("Player fouind: " + currentPlayer.name);
            //image.fillAmount = currentPlayer.GetComponent<PlayerController>().MaxHealth / 100;
            image.fillAmount = currentPlayer.GetComponent<Health>().HealthPoints / 100;
        }
        else
        {
            Debug.LogError("Player not found!");
        }

        //print(playerController.MaxHealth);
        //image.fillAmount = playerController.MaxHealth / 100;
    }
}
