using UnityEngine;
using System.Collections;

public class candyboxopener : MonoBehaviour {
	public static bool candyboxIsOpen;
	private bool openTheCandyBox;
	public float lerpTime = 100f;
	public float rotSpeed = 1;
	public static float currentLerpTime;
	public static bool boxHasBeenHeld;

	void Start () {
		candyboxIsOpen = false; // set to true only for testing! Otherwise set to false!
		boxHasBeenHeld = true;
	}
	
	void FixedUpdate () 
	{
		if (boxHasBeenHeld == true) //boxHasBeenHeld is used in the full game. In this demo, we assume the box has been held.
		{
			openTheCandyBox = true;
		}

		if (candyboxIsOpen == false) 
		{	
			if (openTheCandyBox == true)
			{
				if (transform.eulerAngles.z < 230) // rotate the flap open to a certain point, and then stop.
				{
					float dir = 1f;
					float step = Time.deltaTime * rotSpeed;
					transform.Rotate(new Vector3(0,0,12)*step * dir);
				}
				
				if (transform.eulerAngles.z >= 230) 
				{
					candyboxIsOpen = true;
				}
			}
			
		}
		if (candyboxIsOpen == true) 
		{
			if (openTheCandyBox == false)
			{
				if (transform.eulerAngles.z > 0) // rotate the flap closed to a certain point, and then stop.
				{
					float dir = -1f;
					float step = Time.deltaTime * rotSpeed;
					transform.Rotate(new Vector3(0,0,12)*step * dir);
				}
				
				if (transform.eulerAngles.z <= 0) 
				{
					candyboxIsOpen = false;
				}
			}
		}
	}
}
