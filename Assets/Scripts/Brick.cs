﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	// Use this for initialization
	void Start ()
	{
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timesHit >= maxHits) {
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D brick)
	{
		timesHit++;
		//SimulateWin ();
	}
	
	// TODO Remove this method once we can actually win
	
	void SimulateWin ()
	{
		levelManager.loadNextLevel ();
	}
}
