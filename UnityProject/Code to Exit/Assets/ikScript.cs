using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikScript : MonoBehaviour {

	// Use this for initialization

	protected Animator animator;

	public bool ikActive = false;
	//public Transform rightHandObj = null;
	private Transform lookObj = null;

	private Transform computer;
	private Transform exitSpere;

	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void OnAnimatorIK()
	{
		if(animator) {

			//if the IK is active, set the position and rotation directly to the goal. 
			if(ikActive) {

				// Set the look target position, if one has been assigned

				computer = GameObject.Find ("computer").transform;
				exitSpere = GameObject.Find ("SphereExit").transform;

				lookObj = Vector3.Distance (computer.position, transform.position)*2 < Vector3.Distance (exitSpere.position, transform.position) ? computer : exitSpere;

				//GameObject.Find ("computer").transform;
				if(lookObj != null) {
					animator.SetLookAtWeight(1);
					animator.SetLookAtPosition(lookObj.position);
				}    

				// Set the right hand target position and rotation, if one has been assigned
				/*if(rightHandObj != null) {
					animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
					animator.SetIKRotationWeight(AvatarIKGoal.RightHand,1);  
					animator.SetIKPosition(AvatarIKGoal.RightHand,rightHandObj.position);
					animator.SetIKRotation(AvatarIKGoal.RightHand,rightHandObj.rotation);
				}        
				*/
			}

			//if the IK is not active, set the position and rotation of the hand and head back to the original position
			else {          
				animator.SetIKPositionWeight(AvatarIKGoal.RightHand,0);
				animator.SetIKRotationWeight(AvatarIKGoal.RightHand,0); 
				animator.SetLookAtWeight(0);
			}
		}
	}    
}
