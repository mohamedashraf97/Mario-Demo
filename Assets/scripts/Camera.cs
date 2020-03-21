using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	public GameObject player ;
	public float offset ;
	private Vector3 playerposition ;
	public float offsetsmoothing ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	playerposition =new Vector3(player.transform.position.x,transform.position.y,transform.position.z);
		//transform.position= new Vector3(player.transform.position.x,transform.position.y,transform.position.z);
		if(player.transform.localScale.x>0f)
		{
	playerposition =new Vector3(player.transform.position.x+offset,transform.position.y,transform.position.z); }
	else
	{
		playerposition =new Vector3(player.transform.position.x-offset,transform.position.y,transform.position.z); 
	}

		
		transform.position= Vector3.Lerp (transform.position,playerposition,offsetsmoothing*Time.deltaTime);

	}
}
