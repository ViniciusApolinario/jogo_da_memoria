using UnityEngine;
using System.Collections;

public class Carta : MonoBehaviour {
	public GameObject[] imagens;
	// Use this for initializtion
	void Start () {
		for (int tw = 1; tw < 9; tw++) {
			imagens[] = Resources.Load("carros1") as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
