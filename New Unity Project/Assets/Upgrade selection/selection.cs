using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selection : MonoBehaviour {
	public GameObject[] sel = new GameObject[3];
	public Sprite[] weapons ;
	private selcted s0,s1,s2; 
	// Use this for initialization
	private int w1 = -1, w2 = -1 ,w3 = -1;
	void Start () {
		if ((s0 == null) && (s1 == null) && (s2 == null) && (GetComponent<selcted>() != null))
		{
			s0 = sel[0].GetComponent<selcted>();
			s1 = sel[1].GetComponent<selcted>();
			s2 = sel[2].GetComponent<selcted>();
			sel[0].GetComponent<Image>();
			sel[1].GetComponent<Image>();
			sel[2].GetComponent<Image>();
		}
		else
		{
			Debug.LogWarning("Missing selcted component. Please add one");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Disappear(){
		
		if ((s0 == null) && (s1 == null) && (s2 == null) && (GetComponent<selcted> () != null)) {
			s0.enabled = false;
			s1.enabled = false;
			s2.enabled = false;
		}
	}
		
	public void Appear(){
		if ((s0 == null) && (s1 == null) && (s2 == null) && (GetComponent<selcted> () != null)) {
			s0.enabled = true;
			s1.enabled = true;
			s2.enabled = true;
		}
		w1 = -1; 
		w2 = -1;
		w3 = -1;
		w1 = Random.Range (0,weapons.Length);
		sel [0].GetComponent<Image> ().sprite = weapons[w1];
		while (true) {
			w2 = Random.Range (0,weapons.Length);
			if (w1 != w2)
				break;
		}
		sel[1].GetComponent<Image>().sprite = weapons[w2];
		while (true) {
			w3 = Random.Range (0,weapons.Length);
			if (w1 != w3 && w2 != w3)
				break;
		}
		sel[2].GetComponent<Image>().sprite = weapons[w3];
		//
		sel[0].GetComponent<selcted>().Open ();
		sel[1].GetComponent<selcted>().Open ();
		sel[2].GetComponent<selcted>().Open ();
	}

	public int[] GetWvalue()
	{
		int[] we = {w1,w2,w3};
		return we;
	}
}
