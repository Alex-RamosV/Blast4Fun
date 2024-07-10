using UnityEngine;
using TMPro;
using AlterunaFPS;

public partial class Ammunition : MonoBehaviour
    {
    // Start variables
    TMP_Text textAmmo; 

    // Reference to the currentPlayer
    private GameObject currentPlayer;
    
    // Reference to the Avatar
    private PlayerController currentPlayerController;

    //Use this for Offline Gameplay
    //[SerializeField]
    //PlayerController playerController;

    void Awake()
    {
        // Get textAmmo
        textAmmo = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // Get the GameObject with the tag
        currentPlayer = GameObject.FindGameObjectWithTag("Player");

        // Get Avatar 
        // currentPlayerController = GetComponent<PlayerController>().Avatar.IsMe;

        if (currentPlayer != null)
        {
            //Debug.Log("Player fouind: " + currentPlayer.name);
            //textAmmo.text = currentPlayer._gunMagazine + "/" + playerController.GunMagazineSize;

            textAmmo.text = currentPlayer.GetComponent<PlayerController>().Avatar.GetComponent<PlayerController>()._gunMagazine + 
                "/" + currentPlayer.GetComponent<PlayerController>().Avatar.GetComponent<PlayerController>().GunMagazineSize;
            
            // Nombre del jugador instanciado
            print(currentPlayer.GetComponent<PlayerController>().Avatar.name);
            
            // Access to PlayerController attributes
            // currentPlayer.GetComponent<PlayerController>()._gunMagazine;
            // currentPlayer.GetComponent<PlayerController>().GunMagazineSize;

            // Access to Avatar attributes
            // currentPlayer.GetComponent<PlayerController>().Avatar.name; 
            // currentPlayer.GetComponent<PlayerController>().Avatar.GetComponent<PlayerController>()._gunMagazine;
        }
        else
        {
            //Debug.LogError("Player not found!");
        }

    }
}