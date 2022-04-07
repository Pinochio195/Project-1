using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    [SerializeField]int Width,Height;
    [SerializeField] Tile tile;
    [SerializeField] Transform Cam;
    private void Start()
    {
        GridView();
    }
    void GridView()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                var spawnTile  = Instantiate(tile,new Vector3(x,y),Quaternion.identity);
                spawnTile.name = $"Tile {x} {y}";
                //var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                //var isOffset = ( (x+y) % 2 == 1 );
                //spawnTile.Init(isOffset);
            }
        }
        Cam.transform.position = new Vector3(Width/2 -.5f,Height/2+2.5f,-10);
    }
   

}
