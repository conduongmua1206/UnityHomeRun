using UnityEngine;
using System.Collections;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;

public class GameController : MonoBehaviour
{
	//singleton instance
	private static GameController instance;
	public Data data;
	private float width = Screen.width;
	private float height = Screen.height;
	
	void Awake ()
	{
		instance = this;
	}
	
	// get instance controller
	public static GameController getInstance ()
	{
		return instance;
		
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	public void throwBall()
	{
		
		
	}
	
	public void hitBall()
	{
		
	}
	
	public void collideGround()
	{
		
	}
	
	public void collideItem(BaseItem item)
	{
		
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
