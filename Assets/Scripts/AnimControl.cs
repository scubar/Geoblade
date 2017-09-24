using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    private Animator mAnimator;
    public float movementSpeed;

	// Use this for initialization
	void Start ()
	{
	    mAnimator = GetComponent<Animator>();
	    mAnimator.SetBool("walking",true);
    }

    // Update is called once per frame
    void Update ()
	{
	    transform.position += transform.forward * Time.deltaTime * movementSpeed;


        if (Input.GetKeyDown(KeyCode.M))
	    {
	        mAnimator.SetTrigger("attack");
	    }
	}
}
