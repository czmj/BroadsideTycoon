using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCycle : MonoBehaviour
{
    public Animator anim;
    public float startTime;
    private bool started;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update () {
        if (!started && Time.time >= startTime)
        {
            anim.enabled = true;
        }
		
	}
}
