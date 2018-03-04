﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : InteractiveBehaviour
{
    private Animator anim;
    private string leverName;
    private int pos = 0;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        if (transform.parent != null)
        {
            leverName = transform.parent.name;
        }
    }

    // Increase lever position
    protected override void OnSelect()
    {
        if (pos == 0)
        {
            anim.Play("Lever_0-1");
            pos = 1;
            print(leverName + " set to " + pos);
        }
        else if (pos == 2)
        {
            anim.Play("Lever_2-0");
            pos = 0;
            print(leverName + " set to " + pos);
        }
    }

    // Decrease lever position
    protected override void OnAltSelect()
    {
        if (pos == 1)
        {
            anim.Play("Lever_1-0");
            pos = 0;
            print(leverName + " set to " + pos);
        }
        else if (pos == 0)
        {
            anim.Play("Lever_0-2");
            pos = 2;
            print(leverName + " set to " + pos);
        }
    }
}
