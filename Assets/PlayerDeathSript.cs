using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeathSript : MonoBehaviour
{
	 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < -9.5f){
		   SceneManager.LoadScene("GameOver");
		   LevelGenerator.mazeLevel=0;
	   }
    }
}
