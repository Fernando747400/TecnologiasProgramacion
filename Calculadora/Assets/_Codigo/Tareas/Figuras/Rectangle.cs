using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle 
{
    private Vector2 bottomLeft;

    public Vector2 BottomLeft
    {
        get { return bottomLeft; }
        set { bottomLeft = value; }
    }

    private Vector2 bottomRight;

    public Vector2 BottomRight
    {
        get { return bottomRight; }
        set { bottomRight = value; }
    }

    private Vector2 topLeft;

    public Vector2 TopLeft
    {
        get { return topLeft; }
        set { topLeft = value; }
    }

    private Vector2 topRight;

    public Vector2 TopRight
    {
        get { return topRight; }
        set { topRight = value; }
    }

    public Rectangle()
    {

    }
    public Rectangle(Vector2 bottomLeft, Vector2 topRight)
    {
        BottomLeft = bottomLeft;
        TopRight = topRight;
        TopLeft = getTopLeft(bottomLeft,topRight);
        BottomRight = getBottomRight(bottomLeft, topRight);
    }

    public Rectangle(Vector2 bottomLeft, Vector2 bottomRight, Vector2 topLeft, Vector2 topRight) : this(bottomLeft, bottomRight)
    {
        TopLeft = topLeft;
        TopRight = topRight;
    }

    public float getBase()
    {
        float answer;
        answer = Vector2.Distance(this.BottomLeft, this.bottomRight);
        return answer;
    }

    public float getHeight()
    {
        float answer;
        answer = Vector2.Distance(this.bottomLeft, this.topLeft);
        return answer;
    }

    public float getPerimeter()
    {
        float answer;
        answer = (getBase()*2) + (getHeight()*2);
        return answer;
    }

    public float getArea()
    {
        float answer;
        answer = getBase() * getHeight();
        return answer;
    }

    private Vector2 getTopLeft(Vector2 bottomLeft, Vector2 topRight)
    {
        Vector2 answer;
        answer.x = bottomLeft.x;
        answer.y = topRight.y;
        return answer;
    }

    private Vector2 getBottomRight(Vector2 bottomLeft, Vector2 topRight)
    {
        Vector2 answer;
        answer.x = topRight.x;
        answer.y = bottomLeft.y;
        return answer;
    }
}
