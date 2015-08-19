using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {

	public GameObject cartas, canvas;
	public Transform posiçao;
	private GameObject linha;
	public 
	// Use this for initialization
	void Start () {

		for (int ue = 0; ue < 6; ue++) {
			GameObject linha = Instantiate (cartas) as GameObject;
			posiçao.transform.position = new Vector3(posiçao.transform.position.x + ue + 100 , posiçao.transform.position.y , transform.position.z); 
			linha.transform.SetParent (canvas.transform);
			linha.transform.localPosition = posiçao.transform.position;
			linha.transform.rotation = Quaternion.identity;
		}


	}

	// Update is called once per frame
	void Update () {

	}
}
