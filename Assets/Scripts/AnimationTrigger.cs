using UnityEngine;
using UnityEngine.Playables;

public class AnimationTrigger : MonoBehaviour
{
    public PlayableDirector playableDirector; // Referencja do PlayableDirector, który kontroluje timeline
    public PlayableDirector playableDirector1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Wywo³aj funkcjê rozpoczynaj¹c¹ animacjê w timeline
            StartAnimation();
        }
       
    }

    public void StartAnimation()
    {
        // SprawdŸ, czy PlayableDirector jest dostêpny
        if (playableDirector != null || playableDirector1 !=null)
        {
            // Odtwórz timeline
            playableDirector.Play();
            playableDirector1.Play();
        }
    }
}

