using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

	public void LoadLevel (string name)
	{
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel (name);
	}
	
	public void loadNextLevel ()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	
	public void quitRequest ()
	{
		Debug.Log ("Quit has been requested");
		Application.Quit ();
	}
	
}
