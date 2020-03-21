using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour {
	private LevelManager gameLevelManager ;
	public int coinValue;
 public  int score= 0 ;

	// Use this for initialization
	void Start () {
		gameLevelManager = FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag=="player"){
			gameLevelManager.AddCoin(coinValue);
	
		Destroy(gameObject);
		}
	}
}
