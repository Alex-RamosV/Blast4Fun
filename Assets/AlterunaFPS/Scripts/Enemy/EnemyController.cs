using Alteruna;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace AlterunaFPS
{

    // Class split into multiple files for clarity
    public class EnemyController : MonoBehaviour
    {
        [Header("Player Controller")]
        PlayerController playerController;

        [Header("Audio")]
        public AudioSource diedSFX;
        public AudioSource rockSFX;

        [Header("Animation")]
        Animator myAnimator;

        [Header("3D Models")]
        public GameObject piedraMasa;

        [Header("Health")]
        //public int myHealth;
        public Health realHealth;
        public float timeToDispawn;

        void Awake()
        {
            playerController = GetComponent<PlayerController>();
            myAnimator = GetComponent<Animator>();
            //enemyAudio = GetComponent<EnemyAudio>();

            //InitializeOnLoadMethodAttribute();
            //playerController.FireBullet();
        }


        void OnDeath()
        {
            
        }

        void Update()
        {

            /*
            if (Input.GetKeyDown("1"))
            {
                piedraMasa.SetActive(true);
            }
            else if (Input.GetKeyDown("2"))
            {
                piedraMasa.SetActive(false);
            }
            */


            if (realHealth.HealthPoints <= 25)
            {
                piedraMasa.SetActive(true);
            } 
            
            if (realHealth.HealthPoints <= 0)
            {
                myAnimator.SetTrigger("Death");
                piedraMasa.SetActive(false);
                Destroy(gameObject, timeToDispawn);
            }

        }


    }
}
