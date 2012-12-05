using UnityEngine;
using System.Collections;

public enum ItemType{
	None = 0,
	Car,
	FlyBall,
	House
}
public class BaseItem : MonoBehaviour {
	
	public ItemType type;
	public int bonus;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
