using UnityEngine;
using UnityEngine.Playables;

public class AnimationTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector; // Referencja do PlayableDirector, kt�ry kontroluje timeline

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.CompareTag("Player"))
        {
            // Wywo�aj funkcj� rozpoczynaj�c� animacj� w timeline
            StartAnimation();
        }*/
    }

    public void StartAnimation()
    {
        // Sprawd�, czy PlayableDirector jest dost�pny
        if (playableDirector != null)
        {
            // Odtw�rz timeline
            playableDirector.Play();
        }
    }
}

