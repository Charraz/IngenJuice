using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarsDeathAnimation : MonoBehaviour
{
    public GameObject onDeathCoin;
    private SFXController sfxController;
    private bool DeathIminent;

    void Start()
    {
        sfxController = SFXController.InstanceOfSFX;
        DeathIminent = true;
    }


    void Update()
    {
        if(DeathIminent == true)
        {
            sfxController.PlayGhostDeathSound();
            Invoke("Death", 0.3f);
            DeathIminent = false;
        }
    }

    private void Death()
    {
        Instantiate(onDeathCoin, transform.position, Quaternion.identity);
    }
}
