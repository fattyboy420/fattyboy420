using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyOnGameOver : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         Scene scene = SceneManager.GetActiveScene();
if (scene.name=="GameOver"){
			Destroy(gameObject);
			Debug.Log("Audio Destroyed");
			}
			
			
    }
}
