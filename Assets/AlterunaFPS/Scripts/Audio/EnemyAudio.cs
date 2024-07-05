using AlterunaFPS;
using UnityEngine;

namespace AlterunaFPS
{
    public class EnemyAudio : MonoBehaviour
    {
        public RandomPitch DiedSfx;
        public RandomPitch RockSfx;

        public void PlayDiedSfx() => DiedSfx.Play();
        public void PlayRockSfx() => RockSfx.Play();
    }
}
