using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace PHDGame
{
	public class TerrainUnit 
	{
		//unit info
		string compressedString = "";
		string id = "";
		string type = "";
		int temperature = 0;
		int pressure = 0;
		int flowDirection = 0;
		string[] composition = new string[4];
		float[] compositionPercentages = new float[4];
		int radiationSource = 0;
		int radiationPropogationDirection = 0;
		int radiation = 0;
		int slope = 0;

	

		public TerrainUnit ()
		{
				

		}

		public string ID
		{
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public string[] Composition
		{
			get {
				return composition;
			}
			set {
				composition = value;
			}
		}

		public float[] CompositionPercentages
		{
			get {
				return compositionPercentages;
			}
			set {
				compositionPercentages = value;
			}
		}

		// Exapnd a TerrainUnit string into a TerrainUnit 
		public void Expand()
		{
		}

		public void Compress()
		{
		}

		public void Draw()
		{
			
		}
	}
}


