/*
 Componente da dare all'enigma per popolare le posizioni vuote
 */

using System.Collections.Generic;
using UnityEngine;

public class Enigma6Controller : MonoBehaviour
{
    private List<GameObject> _cubes = new();

    public Transform[] cubesPositions;

    private int positionsIndex = 0;

    public void AddCube(GameObject cube)
    {
        _cubes.Add(cube);
        cube.transform.position = cubesPositions[positionsIndex].position;
        positionsIndex++;
    }
}
