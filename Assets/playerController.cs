using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
	Animator anim;
	float speedH = 0.5f;
	float speedV = 0.5f;
	
	float yaw = 0.0f;
	float pitch = 0.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");
		
		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
		
		//walking right
		if (Input.GetKey(KeyCode.D)) 
		{
			anim.SetBool("isWalkRight", true);
			transform.Translate(Vector3.right * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.D)) 
		{
			anim.SetBool("isWalkRight", false);
		}
		
		//walking front
		if (Input.GetKey(KeyCode.W)) 
		{
			anim.SetBool("isWalkFront", true);
			transform.Translate(Vector3.forward * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.W)) 
		{
			anim.SetBool("isWalkFront", false);
		}
		
		//walking back
		if (Input.GetKey(KeyCode.S)) 
		{
			anim.SetBool("isWalkBack", true);
			transform.Translate(Vector3.back * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.S)) 
		{
			anim.SetBool("isWalkBack", false);
		}
		
		//walking left
		if (Input.GetKey(KeyCode.A)) 
		{
			anim.SetBool("isWalkLeft", true);
			transform.Translate(Vector3.left * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.A)) 
		{
			anim.SetBool("isWalkLeft", false);
		}
		
		//running right
		if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.LeftShift)) 
		{
			anim.SetBool("isRunRight", true);
			anim.SetBool("isWalkRight", false);
			transform.Translate(Vector3.right * Time.deltaTime * 2);
		}
		if (Input.GetKeyUp(KeyCode.D)) 
		{
			anim.SetBool("isRunRight", false);
		}
		
		//running front
		if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.LeftShift)) 
		{
			anim.SetBool("isRunFront", true);
			anim.SetBool("isWalkFront", false);
			transform.Translate(Vector3.forward * Time.deltaTime * 2);
		}
		if (Input.GetKeyUp(KeyCode.W)) 
		{
			anim.SetBool("isRunFront", false);
		}
		
		//running left
		if (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.LeftShift)) 
		{
			anim.SetBool("isRunLeft", true);
			anim.SetBool("isWalkLeft", false);
			transform.Translate(Vector3.left * Time.deltaTime * 2);
		}
		if (Input.GetKeyUp(KeyCode.A)) 
		{
			anim.SetBool("isRunLeft", false);
		}
		 
    }
	
}
