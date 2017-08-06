using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//Stores properties of the player, to be saved and live throughout all levels
	public string playerName;
	public List<List<int>> objectivesCompleted;	//[level][objective]
}
