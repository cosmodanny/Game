﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to represent static data for link actions
 * 
 * Author: Daniel Brunelle 
 */
public class LinkData : MonoBehaviour
{

	//State struct to represent the movement variables of each direction
	public struct MoveState
	{
		public string name;
		public string idle;
		public int paramMove;
		public string[] keys;
		public Vector2 direction;
		public bool flip;
	}

	/*
	 * All possible abbreviated movements
	 * ur = Up Right
	 * ul = Up Left
	 * dr = Down Right
	 * dl = Down Left
	 * rt = Right
	 * lt = Left
	 * up = Up
	 * dn = Down
	 */
	public static string[] moveDirections = new string[] { "ur", "ul", "dr", "dl", "rt", "lt", "up", "dn" };

	//Define states for each type of movement
	public static Dictionary<string, MoveState> moveStateDict = new Dictionary<string, MoveState>(){
		//Up Right
		{moveDirections[0], new MoveState{
			name = "LinkUpRight",
			idle = "urIdle",
			paramMove = 3,
			keys = new string[]{"Up", "Right"},
			direction = new Vector2(1,1).normalized,
			flip = false
		}},
		//Up Left
		{moveDirections[1], new MoveState{
			name = "LinkUpRight",
			idle = "urIdle",
			paramMove = 3,
			keys = new string[]{"Up", "Left"},
			direction = new Vector2(-1,1).normalized,
			flip = true
		}},
		//Down Right
		{moveDirections[2], new MoveState{
			name = "LinkDownLeft",
			idle = "dlIdle",
			paramMove = 4,
			keys = new string[]{"Down", "Right"},
			direction = new Vector2(1,-1).normalized,
			flip = true
		}},
		//Down Left
		{moveDirections[3], new MoveState{
			name = "LinkDownLeft",
			idle = "dlIdle",
			paramMove = 4,
			keys = new string[]{"Down", "Left"},
			direction = new Vector2(-1,-1).normalized,
			flip = false
		}},
		//Right
		{moveDirections[4], new MoveState{
			name = "Link Right",
			idle = "rtIdle",
			paramMove = 0,
			keys = new string[]{"Right"},
			direction = Vector2.right,
			flip = false
		}},
		//Left
		{moveDirections[5], new MoveState{
			name = "Link Right",
			idle = "urIdle",
			paramMove = 0,
			keys = new string[]{"Left"},
			direction = Vector2.left,
			flip = true
		}},
		//Up
		{moveDirections[6], new MoveState{
			name = "Link Up",
			idle = "upIdle",
			paramMove = 2,
			keys = new string[]{"Up"},
			direction = Vector2.up,
			flip = false
		}},
		//Down
		{moveDirections[7], new MoveState{
			name = "Link Down",
			idle = "dnIdle",
			paramMove = 1,
			keys = new string[]{"Down"},
			direction = Vector2.down,
			flip = false
		}},
	};
}
