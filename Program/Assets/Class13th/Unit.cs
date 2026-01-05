using System;
using UnityEngine;

public enum AniType
{
    Idle,
    Die,
    Attack,
    Walk
}

public class Unit : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AniType index;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();    
    }

    private void OnEnable()
    {
        index = 0;
    }

    private void Update()
    {

    }



    public void Transtion(AniType _count)
    {
        index = _count;
    }

    public void Emit()
    {
        AudioClip loadClip = Resources.Load<AudioClip>(index.ToString());
        audioSource.PlayOneShot(loadClip);
        Debug.Log($"audioSource.PlayOneShot(clip) : {loadClip.name}");
    }


}
