using UnityEngine;
using TMPro;
using AlterunaFPS;

public partial class Ammunition : MonoBehaviour
    {
    // Start variables
    TMP_Text textAmmo;
    private GameObject currentPlayer;

    //Use this for Offline Gameplay
    //[SerializeField]
    //PlayerController playerController;

    void Awake()
    {
        textAmmo = GetComponent<TMP_Text>();
        //print(playerController.GunMagazineSize);
        //print(playerController.GunMagazineSize);
    }

    void Update()
    {
        
        currentPlayer = GameObject.FindGameObjectWithTag("Player");

        if (currentPlayer != null)
        {
            Debug.Log("Player fouind: " + currentPlayer.name);
            //textAmmo.text = currentPlayer._gunMagazine + "/" + playerController.GunMagazineSize;
            textAmmo.text = currentPlayer.GetComponent<PlayerController>()._gunMagazine + "/" + currentPlayer.GetComponent<PlayerController>().GunMagazineSize;
        }
        else
        {
            Debug.LogError("Player not found!");
        }

    }
}