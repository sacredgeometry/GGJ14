using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NoiseProcessor : MonoBehaviour
{
	
		
//	public Texture2D noiseTex;
//	public static Color[] pxList = new Color [4096];
//
//	public GameObject eObject;
//
//	
//	// INIT
//	void Start ()
//	{
//		pxList = noiseTex.GetPixels();
//		TextureTranslator();
//	}
//	
//	//CubeGrid.GridArray[i].gridColumn[i].name
//	void TextureTranslator(){	
//		
//		int counter = 0;
//		
//		for ( int row = 0; row <= 63; row++ ){
//			for (int col = 0; col <= 63; col++ ){
//				
//				//Debug.Log(row + "_" + col);
//				
//				// This checks for non_black and creates the lev by destroying the black cubes
//				if(isNotBlack(counter)){
//					// Deletes Cubes from cube grid ifNotBlack
//					if(pxList[counter] == Color.white){
//						Cube.destroyBlock((GameObject)CubeGrid.GridArray[row].gridColumn[col].gameObject);
//					} else if (pxList[counter] == Color.red){
//						Cube.destroyBlock((GameObject)CubeGrid.GridArray[row].gridColumn[col].gameObject);
////						CubeGrid.GridArray[row].gridColumn[col].gameObject.renderer.material.color = Color.red;
////						print("working");
//						
//						GameObject tempTest = (GameObject) Instantiate(eObject, 
//						            CubeGrid.GridArray[row].gridColumn[col].gameObject.transform.position, 
//						            Quaternion.Euler(0,90,0));
//						
//						tempTest.transform.parent = GameObject.FindGameObjectWithTag("InstanceBinNPCEnemies").transform;
//					}
//					
//				}
////				
////				if (isRed(counter)){
////					// Spawn Enemy
////					//EnemySpawn.spawnEnemy((float)row, (float)-col, eObject);
////					
////				}
//				counter++;			
//			}
//		}
//	}
//	
//	// is not black fuction ~ levelpopulation
//	bool isNotBlack(int i){
//		if(pxList[i] == Color.black){
//			return false;
//		} else {
//			return true;
//		}
//
//	}
//	
////	// idRed function ~ 
////	bool isRed (int i){
////		if(pxList[i] == Color.red){
////			return true;
////		} else {
////			return false;
////		}
////	}

}