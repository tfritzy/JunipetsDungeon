using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private Tile[,] tiles;

    void Start()
    {
        tiles = new Tile[Constants.BOARD_RADIUS * 2, Constants.BOARD_RADIUS * 2];
        InstantiateFloorTiles();
    }

    void Update()
    {

    }

    private void InstantiateFloorTiles()
    {
        for (int y = 0; y < tiles.GetLength(1); y++)
        {
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                Instantiate(M.Prefabs.FloorTile, Helpers.GridToWorldPosition(x, y), new Quaternion(), this.transform);
            }
        }
    }
}
