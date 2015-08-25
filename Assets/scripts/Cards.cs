using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {

	public GameObject cartas, canvas;
	public Transform posiçao;
	public static GameObject[] linha;
	//public static int ue;
	// Use this for initialization
	void Start () {
		linha = new GameObject[6];
		for (int ue = 0; ue < 6; ue++) {
			linha[ue] = Instantiate (cartas) as GameObject;
			posiçao.transform.position = new Vector3(posiçao.transform.position.x + ue + 100 , posiçao.transform.position.y , transform.position.z); 
			linha[ue].transform.SetParent (canvas.transform);
			linha[ue].transform.localPosition = posiçao.transform.position;
			linha[ue].transform.rotation = Quaternion.identity;
			linha[ue].name = ue.ToString();

		}


	}

	// Update is called once per frame
	void Update () {

	}
}
