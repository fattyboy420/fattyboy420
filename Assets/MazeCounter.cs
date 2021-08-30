using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class MazeCounter : MonoBehaviour
{
   public Text Score_UIText; // assign it from inspector
   
    
 void Start()
 {
		
	 
    Score_UIText.text ="Maze: " + LevelGenerator.mazeLevel;
 }

    // Update is called once per frame
    void Update()
    {
        
    }
}
