using System;
using System.Collections;
using UnityEngine;

public class EntityFX : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator anim;
    
    [Header("Flash FX")] 
    private Material originalMat;
    [SerializeField] private Material hitMat;
    [SerializeField] private float flashDuration;

    private void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
        originalMat = sr.material;
    }

    private IEnumerator flashFX()
    {
         anim.enabled = false;
        
         sr.material = hitMat;
         yield return new WaitForSeconds(flashDuration);
         sr.material = originalMat;
         
         anim.enabled = true;
    }
}
