using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Carta : MonoBehaviour {

	public static bool ativada = false;
	public static string IDC;
	public Sprite[] imagens ;
	private Sprite foto;
	private string way = "carros/";
	private Image batata;

	// Use this for initializtion
	void Start () {
		//batata.image = imagens [Random.Range (0, imagens.Length)];
		IDC = gameObject.name;
		imagens = Resources.LoadAll<Sprite> (way);
		batata = GetComponent<Image> ();
		foto = imagens[Random.Range (0, imagens.Length)];
		if (Cards.teams[0].ToString() == IDC || Cards.teams [1].ToString() == IDC ||Cards.teams [2].ToString() == IDC ) {
			Debug.Log("Essa e a parte que vc organiza os spritees");
		}


	}
	public void lol(){
		batata.sprite = foto;

	}
	// Update is called once per frame
	void Update () {

	}
}
