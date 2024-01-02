using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pouse : MonoBehaviour
{
	[SerializeField]
	private GameObject Panel;

	private void OnEnable()
	{
		Time.timeScale = 0f;
	}
	private void OnDisable()
	{
		Time.timeScale = 1f;
	}
	public void YenidenOyna()
	{
		Panel.SetActive(true);
		//pusepanelAc();
	}
	public void menuyeDön()
	{
		SceneManager.LoadScene("Anamenu");
	}

	public void pusepanelAc()
	{
		Panel.SetActive(true);
	}
}
