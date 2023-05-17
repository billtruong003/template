using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator anim;
    public bool PlayAnim = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("PlayAnim", PlayAnim);
    }
    public void trueFCheck()
    {
        if (PlayAnim)
        {
            PlayAnim = false;
        }
        else 
        {
            PlayAnim = true;
        }
    }
}
