using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    public void Emit()
    {
        AudioClip loadClip = Resources.Load<AudioClip>("Attack");
        audioSource.PlayOneShot(loadClip);
        Debug.Log($"audioSource.PlayOneShot(clip) : {loadClip.name}");
    }


}
