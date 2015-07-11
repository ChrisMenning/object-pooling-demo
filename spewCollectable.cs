	public static bool looper2; //A boolean switch so that certain processes may be disabled when not in use.
	public Vector3 scaler1; //A variable range of acceptable sizes for one kind of candy.
	public Vector3 scaler2; //Ditto for another kind of candy.
	public Vector3 scaler3; //Ditto for a third kind of candy.
	private float diceRoll1; //A floating point variable for randomization purposes.
	private bool currentlySpewing; //A boolean switch so that certain processes may be disabled when not in use.

	void Start () 
	{
		scaler1 = new Vector3(0.05F, 0.05f, 0.05F); //Declare starting X, Y, and Z vector sizes for scaler1.
		scaler2 = new Vector3(0.025F, 0.04f, 0.025F); //Declare starting X, Y, and Z vector sizes for scaler2.
		scaler3 = new Vector3(0.025F, 0.1f, 0.025F); //Declare starting X, Y, and Z vector sizes for scaler3.
		currentlySpewing = false;
		looper2 = false;
	}

	void Update ()
	{
		if (candyboxopener.candyboxIsOpen == true) //Check that the script responsible for opening the box has opened the box.
		{
			if (currentlySpewing == false) //Check to see if this script is currently spewing candies out. If not, then do so.
			{
				looper2 = true;
				StartCoroutine ("startSpewing");
				currentlySpewing = true;
			}
		}
		if (candyboxopener.candyboxIsOpen == false) //If the box is not open, we should not be spewing candies.
		{
			looper2 = false;
			currentlySpewing = false;
		}
	}

	IEnumerator startSpewing()
	{
		print ("initializing spew"); //Used for debugging purposes.
		yield return new WaitForSeconds (1);
		StartCoroutine ("diceRoller"); //Roll the dice.
		StartCoroutine (Spew(1.0F)); //Begin spewing candies of three types.
		StartCoroutine (Spew2 (1.0F));
		StartCoroutine (SpewBad (1.0F));
	}

	IEnumerator diceRoller ()
	{
		do 
		{
			diceRoll1 = Random.Range (0.25F, 0.55F);
			yield return new WaitForSeconds (5); //We are only rolling the dice once every 5 seconds to save on overhead.
		}while (looper2 == true);
	}

	IEnumerator Spew(float waitTime) 
	{
	do 
		{
			yield return new WaitForSeconds(waitTime * Random.Range(1.0F, 5.0F)); //Randomized wait time so that spewing is not too predictable.
			StartCoroutine ("FetchCandy1");

		}while (looper2 == true);
	}

	IEnumerator Spew2(float waitTime) 
	{
		do 
		{
			yield return new WaitForSeconds(waitTime * Random.Range(10.0F, 15.0F));

			StartCoroutine ("FetchCandy2");
		}while (looper2 == true);
	}

	IEnumerator SpewBad(float waitTime) 
	{
		do 
		{
			yield return new WaitForSeconds(waitTime * Random.Range(5F, 10.0F));

			StartCoroutine ("FetchCandy3");

		}while (looper2 == true);
	}

	void FetchCandy1 ()
	{
		GameObject candy1 = newCandyPooler.current.GetPooledCandy1 (); //locate a GameObject declared as "Candy1" in the "GetPooledCandy1" section of the newCandyPooler script.
		if (candy1 == null) return; //If there are no candy1's allowable at the moment, do nothing, otherwise do the following.
		
		candy1.transform.position = new Vector3(transform.position.x, (transform.position.y + 0.1f), transform.position.z); //Move the currently disabled candy to a point just above the bottom of the box.
		candy1.GetComponent<Rigidbody>().velocity = transform.up * speed * (Random.Range(0.015F, 0.04F)); //Give the candy an upward trajectory and a semi-randomized speed.
		candy1.transform.localScale = (scaler1 * diceRoll1); //Give the candy a size determined by the acceptable starting value multiplied by the most recent diceroll.
		candy1.SetActive (true); //Make the candy visibile and active!
	}

	void FetchCandy2 ()
	{
		GameObject candy2 = newCandyPooler.current.GetPooledCandy2 ();
		
		if (candy2 == null) return;
		
		candy2.transform.position = new Vector3(transform.position.x, (transform.position.y + 0.1f), transform.position.z);
		candy2.GetComponent<Rigidbody>().velocity = transform.up * speed * (Random.Range(0.03F, 0.02F));
		candy2.transform.localScale = (scaler1 * diceRoll1);
		candy2.SetActive (true);
	}

	void FetchCandy3 ()
	{
		GameObject candy3 = newCandyPooler.current.GetPooledCandy3 ();
		
		if (candy3 == null) return;
		
		candy3.transform.position = new Vector3(transform.position.x, (transform.position.y + 0.1f), transform.position.z);
		candy3.GetComponent<Rigidbody>().velocity = transform.up * speed * (Random.Range(0.025F, 0.076F));
		candy3.transform.localScale = (scaler2 * diceRoll1);
		candy3.SetActive (true);
	}
}
