using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowCuisine : MonoBehaviour {

	Button b;

	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener(() => clicked());
	}

	void Update () {

	}

	void clicked(){
		SceneManager.LoadScene("CuisineScene", LoadSceneMode.Single);
	}
}
