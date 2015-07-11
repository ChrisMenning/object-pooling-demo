using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class newCandyPooler : MonoBehaviour {

	//Note: This script is attached to an empty gameObject named "CandyPooler." The script loads a set number of
	//candy gameObjects into memory upon startup, and those gameObjects are immediately deactivated so that
	//they are invisible to the player until they are called upon to appear, via the SpewCollectable script.

	//In the full game, candies are also set to be deactivated upon being eaten by the player. For the purpose
	//of this demo, candies are deactivated after 30 seconds by the DestroyCandy script, and recycled back
	//into the Object Pool for later use.

	public static newCandyPooler current;
	public GameObject pooledCandy1;
	public GameObject pooledCandy2;
	public GameObject pooledCandy3;
	public GameObject pooledCandy4;
	public GameObject pooledCandy5;
	public int pooledAmount1 = 10; // This value is a static, set amount of candies that we will allow.
	public int pooledAmount2 = 5;
	public int pooledAmount3 = 5;
	public int pooledAmount4 = 2;
	public int pooledAmount5 = 1;
	public bool willGrow = false; //Set this to "true" if you would like the number of pooled objects to grow when needed. Doing so may sacrifice performance.

	List<GameObject> pooledCandys1; // This variable will be referenced to check how many candies 
	List<GameObject> pooledCandys2;
	List<GameObject> pooledCandys3;
	List<GameObject> pooledCandys4;
	List<GameObject> pooledCandys5;

	void Awake ()
	{
		current = this;
	}

	void Start () 
	{
		pooledCandys1 = new List<GameObject> (); //Begin a new list called "pooledCandys1."
		for (int i = 0; i < pooledAmount1; i++)  //For every integer of this list that is less than the set amount declared as "pooledAmount1," do the following...
		{
			GameObject candy1 = (GameObject)Instantiate (pooledCandy1); //Create one instance of the pooledCandy1 GameObject and call it "candy1."
			candy1.SetActive (false); //Disable the candy so that it is intially invisible to the player.
			pooledCandys1.Add (candy1); //Add +1 to the pooledCandys1 list so that an accurate count is reflected when comparing the values of pooledCandys1 to pooledAmount1.
		}
		pooledCandys2 = new List<GameObject> ();
		for (int i = 0; i < pooledAmount2; i++) 
		{
			GameObject candy2 = (GameObject)Instantiate (pooledCandy2);
			candy2.SetActive (false);
			pooledCandys2.Add (candy2);
		}
		pooledCandys3 = new List<GameObject> ();
		for (int i = 0; i < pooledAmount3; i++) 
		{
			GameObject candy3 = (GameObject)Instantiate (pooledCandy3);
			candy3.SetActive (false);
			pooledCandys3.Add (candy3);
		}
		pooledCandys4 = new List<GameObject> ();
		for (int i = 0; i < pooledAmount4; i++) 
		{
			GameObject candy4 = (GameObject)Instantiate (pooledCandy4);
			candy4.SetActive (false);
			pooledCandys4.Add (candy4);
		}
		pooledCandys5 = new List<GameObject> ();
		for (int i = 0; i < pooledAmount5; i++) 
		{
			GameObject candy5 = (GameObject)Instantiate (pooledCandy5);
			candy5.SetActive (false);
			pooledCandys5.Add (candy5);
		}
	}

	public GameObject GetPooledCandy1 () //Create an empty GameObject as a child of the parent object to which this script is attached.
	{
		for (int i =0; i < pooledCandys1.Count; i++)  //For every integer less than the value of the variable value of pooledCandys1 (not the set PooledAmount1 , the actual current amount) do the following...
		{
			if (!pooledCandys1[i].activeInHierarchy) //Check to see one of the candies instantiated by the pooledCandys1 list is set to ACTIVE.
			{
				return pooledCandys1[i]; 
			}
		}
		if (willGrow) //If we set "willGrow" to "true" above, then we will allow instantiating of new candies. But for our purposes we are not doing this.
		{
			GameObject candy1 = (GameObject)Instantiate (pooledCandy1);
			pooledCandys1.Add (candy1);
			return candy1;
		}
		return null;
	}
	public GameObject GetPooledCandy2 ()
	{
		for (int i =0; i < pooledCandys2.Count; i++) 
		{
			if (!pooledCandys2[i].activeInHierarchy)
			{
				return pooledCandys2[i];
			}
		}
		if (willGrow) 
		{
			GameObject candy2 = (GameObject)Instantiate (pooledCandy2);
			pooledCandys2.Add (candy2);
			return candy2;
		}
		return null;
	}
	public GameObject GetPooledCandy3 ()
	{
		for (int i =0; i < pooledCandys3.Count; i++) 
		{
			if (!pooledCandys3[i].activeInHierarchy)
			{
				return pooledCandys3[i];
			}
		}
		if (willGrow) 
		{
			GameObject candy3 = (GameObject)Instantiate (pooledCandy3);
			pooledCandys3.Add (candy3);
			return candy3;
		}
		return null;
	}
	public GameObject GetPooledCandy4 ()
	{
		for (int i =0; i < pooledCandys4.Count; i++) 
		{
			if (!pooledCandys4[i].activeInHierarchy)
			{
				return pooledCandys4[i];
			}
		}
		if (willGrow) 
		{
			GameObject candy4 = (GameObject)Instantiate (pooledCandy4);
			pooledCandys4.Add (candy4);
			return candy4;
		}
		return null;
	}
	public GameObject GetPooledCandy5 ()
	{
		for (int i =0; i < pooledCandys5.Count; i++) 
		{
			if (!pooledCandys5[i].activeInHierarchy)
			{
				return pooledCandys5[i];
			}
		}
		if (willGrow) 
		{
			GameObject candy5 = (GameObject)Instantiate (pooledCandy5);
			pooledCandys5.Add (candy5);
			return candy5;
		}
		return null;
	}
}
