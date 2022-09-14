using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridSystem
{
    private int width;
    private int height;
    private int cellSize;
    private int spaceBetweenCells;
    // private int numberOfCells;
    private int[,] array;


    gridSystem(int width, int height){
        this.width = width;
        this.height = height;
        // this.numberOfCells = numberOfCells;
        array = new int[width, height];

        for (int i=0; i<array.GetLength(0);i++){
            for (int y=0; y<array.GetLength(1);y++){
                
            }
        }
    }



}
