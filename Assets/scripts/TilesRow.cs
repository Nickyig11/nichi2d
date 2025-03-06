using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesRow : MonoBehaviour
{
    public TilesCell[] cells { get; private set; }

    private void Awake()
    {
        cells = GetComponentsInChildren<TilesCell>();
    }
}