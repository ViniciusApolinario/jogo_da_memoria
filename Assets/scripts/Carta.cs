using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Carta : MonoBehaviour {

	public Sprite[] imagens ;
	private string way = "carros/";
	private Button batata;

	// Use this for initializtion
	void Start () {
		imagens = Resources.LoadAll<Sprite> (way);
		batata = GetComponent<Button> ();
		//batata.image = imagens [Random.Range (0, imagens.Length)];
		//batata.sprite = imagens [Random.Range (0, imagens.Length)];

	}
	
	// Update is called once per frame
	void Update () {

	}
}
