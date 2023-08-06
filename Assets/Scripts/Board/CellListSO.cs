using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CellList", menuName = "Custom/Cell List")]
public class CellListSO : ScriptableObject
{
    [System.Serializable]
    public class Cell
    {
        public Sprite sprite;
      
        // public int ID;
    }

    public List<Cell> cellList = new List<Cell>();
}
