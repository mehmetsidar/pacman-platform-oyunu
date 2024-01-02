using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SahneGecişi : MonoBehaviour
{// Start is called before the first frame update
	/*public AudioSource anases;*/
	[SerializeField]
	private GameObject Panel;
	void Start()
	{
	//	anases.Play();
	}

	// Update is called once per frame
	void Update()
	{

	}
	public void oyunagec()
	{
		// İstenilen sahneye geçiş yapılır
		SceneManager.LoadScene("Pacman");
	}
	public void oyundancik()
	{
		// Oyunu kapatma komutu
		Application.Quit();
	}
	public void menuyeDön()
	{
		SceneManager.LoadScene("Anamenu");
	}
}
