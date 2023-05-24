using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject m_tilePrefab;
    [SerializeField] int m_boardWidth, m_boardHeight;

    Tile[,] m_tileGrid;

    private void Start()
    {
        InitializeTileGrid();
    }

    private void InitializeTileGrid()
    {
        m_tileGrid = new Tile[m_boardWidth, m_boardHeight];

        for (int i = 0; i < m_boardWidth; i++)
        {
            for (int j = 0; j < m_boardHeight; j++)
            {
                var tile = Instantiate(m_tilePrefab);
                tile.transform.position = new Vector3(i, j, 0);
                tile.transform.rotation = Quaternion.identity;
                tile.transform.parent = transform;
                m_tileGrid[i, j] = tile.GetComponent<Tile>();
            }
        }
    }
}
