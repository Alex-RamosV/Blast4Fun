using UnityEngine;
using TMPro;

namespace AlterunaFPS
{
    public partial class Ammunition : MonoBehaviour
    {
        TMP_Text textAmmo;
        [SerializeField]
        PlayerController playerController;

        void Awake()
        {
            textAmmo = GetComponent<TMP_Text>();

            playerController = GetComponent<PlayerController>();
            GameObject gameObjectPlayer = GameObject.FindGameObjectWithTag("Player");
            if (playerController == null)
            {
                Debug.LogError("PlayerController component not found on the GameObject.");  
            }
            //textAmmo = GetComponent<TMP_Text>();
            //playerController = GetComponent<PlayerController>();
        }

        void Update()
        {
            if (textAmmo != null && playerController != null)
            {
                textAmmo.text = playerController._gunMagazine + "/" + playerController.GunMagazineSize;
            }
            //textAmmo.text = playerController._gunMagazine + "/" + playerController.GunMagazineSize;
        }
    }
}