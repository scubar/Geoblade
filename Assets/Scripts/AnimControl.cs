using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    private Animator mAnimator;
    public float MovementSpeed;
    public float ChaseDistance;
    public float AttackDistance;
    public GameObject Target;

    public AudioSource Sword01;
    public AudioSource Sword02;

    public AudioSource Roar01;



	// Use this for initialization
	void Start ()
	{
	    mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
	{
	   var targetDistance = (Target.transform.position - this.transform.position).sqrMagnitude;
	    mAnimator.SetBool("walking", false);


        if ((targetDistance < ChaseDistance && targetDistance > AttackDistance))
	    {
	        transform.LookAt(Target.transform.position);
	        Roar01.Play();
            mAnimator.SetBool("walking", true);
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, 0.1f);
        }

        if ((targetDistance <= AttackDistance))
	    {
	        Sword01.Play();
	        transform.LookAt(Target.transform.position);
	        mAnimator.SetBool("walking", false);
            mAnimator.SetTrigger("attack");
	    }

	}
}
