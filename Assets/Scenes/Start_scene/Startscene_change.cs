using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscene_change : MonoBehaviour
{
	public void StartScene_change()
	{
		SceneManager.LoadScene("1ship_scene");
	}
}
