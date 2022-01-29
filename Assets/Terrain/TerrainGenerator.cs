using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TerrainGenerator : MonoBehaviour {
    private void Start(){
        
    }

    private void Update(){
        
    }

    /*
    public int depth = 20;
    
    public int width = 256;
    public int height = 256;

    public float scale = 20f;

    private float totalHeightMax = 0;

    public float offsetX = 100f;
    public float offsetY = 100f;
    // Start is called before the first frame update

    private void Start(){
        offsetX = Random.Range(0f, 9999f);
        offsetY = Random.Range(0f, 9999f);
    }

    void Update(){
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    TerrainData GenerateTerrain(TerrainData terrainData){

        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
        
        terrainData.SetHeights(0, 0, GenerateHeights());
        //terrainData.SetHoles(0, 0);
        return terrainData;
    }

    private float[,] GenerateHeights(){
        float[,] heigts = new float[width, height];
        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                float height_ = CalculateHeight(x, y);
                
                if(height_ > totalHeightMax){
                    totalHeightMax = height_;
                    Debug.Log("Max height: " + height_);
                }
                heigts[x, y] = height_;
            }    
        }

        return heigts;
    }

    float CalculateHeight(int x, int y){
        float xCoord = (float) x / width * scale + offsetX;
        float yCoord = (float) y / height * scale + offsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }

    // Update is called once per frame*/
}
