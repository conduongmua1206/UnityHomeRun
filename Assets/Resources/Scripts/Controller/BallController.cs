using UnityEngine;
using System.Collections;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;

public class BallController : MonoBehaviour {
	public BallState state;
	private GameController controller;
	private static BallController instance;
	private Body body;
	void Awake ()
		
	{
	   instance = this;	
	   body = transform.GetComponent<FSBodyComponent>().PhysicsBody;
	}
	
	public static BallController getInstance()
	{
		return instance;	
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
