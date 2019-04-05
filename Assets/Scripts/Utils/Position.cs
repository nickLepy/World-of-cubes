using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position {

    private int x;
    private int y;

    public int X { get { return x;  } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
	
}
