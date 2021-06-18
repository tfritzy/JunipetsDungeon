using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    public const int BOARD_RADIUS = 4;
    public const float HEXAGON_r = 0.866f;
    public const float HEXAGON_R = 1.066f;
    public const float HorizontalDistanceBetweenHexagons = HEXAGON_R + HEXAGON_r / 2;
    public const float VerticalDistanceBetweenHexagons = HEXAGON_r * 2;
}
