using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class destroyCandy : MonoBehaviour {

	//Note: In the full game, the candies are also disabled (gameObject.Setactive(false);) when the player eats one.
	//Eating a candy does not actually destroy the gameobject. It is disabled so that it may be recycled into
	//the Object Pool, making garbage collection unneccessary and reducing memory overhead.

	void OnEnable () 
	{
		Invoke ("selfDestruct", 30f); // After a candy is enabled, count to 30, then disable the candy.
	}

	void Destroy ()
	{
		gameObject.SetActive(false);
	}

	void OnDisable ()
	{
		CancelInvoke();
	}

	void selfDestruct() 
	{
			gameObject.SetActive(false);
	}
}
