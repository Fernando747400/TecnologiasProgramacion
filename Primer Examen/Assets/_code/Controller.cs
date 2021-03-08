using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class Controller : MonoBehaviour
{
    public InputField squareVerticesInput;
    public InputField squareSizeInput;
    public InputField rectangleVerticesInput;
    public InputField rectangleLargeSideInput;
    public InputField rectangleSmallSideInput;
    public InputField triangleVerticesInput;
    public InputField rectangleSizeInput;
    public InputField circleVerticesInput;
    public InputField circleRadiusInput;
    int squareVertices;
    double squareSize;
    int rectangleVertices;
    double rectangleSmallSide;
    double rectangleBigSide;
    int triangleVertices;
    double triangleSize;
    int circleVertices;
    double circleRadius;
    // Start is called before the first frame update
    void Start()
    {
        if (squareVerticesInput == null) squareVerticesInput = GetComponent<InputField>();
        if (squareSizeInput == null) squareSizeInput = GetComponent<InputField>();
        if (rectangleVerticesInput == null) rectangleVerticesInput = GetComponent<InputField>();
        if (rectangleLargeSideInput == null) rectangleLargeSideInput = GetComponent<InputField>();
        if (rectangleSmallSideInput == null) rectangleSmallSideInput = GetComponent<InputField>();
        if (triangleVerticesInput == null) triangleVerticesInput = GetComponent<InputField>();
        if (rectangleSizeInput == null) rectangleSizeInput = GetComponent<InputField>();
        if (circleVerticesInput == null) circleVerticesInput = GetComponent<InputField>();
        if (circleRadiusInput == null) circleRadiusInput = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
