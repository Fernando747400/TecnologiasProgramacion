using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapesController : MonoBehaviour
{
    [Header("Canvas Groups")]
    [SerializeField] CanvasGroup rectangleCanvas;
    [SerializeField] CanvasGroup circleCanvas;
    [SerializeField] CanvasGroup triangleCanvas;

    [Header ("Rectangle Input and Output Fields")]
    [SerializeField] InputField rectangleXOneInput;
    [SerializeField] InputField rectangleYOneInput;
    [SerializeField] InputField rectangleXTwoInput;
    [SerializeField] InputField rectangleYTwoInput;
    [SerializeField] Text rectangleBaseText;
    [SerializeField] Text rectangleHeightText;
    [SerializeField] Text rectanglePerimeterText;
    [SerializeField] Text rectangleAreaText;

    [Header("Circle Input and Output Fields")]
    [SerializeField] InputField circleXInput;
    [SerializeField] InputField circleYInput;
    [SerializeField] InputField circleRadiusInput;
    [SerializeField] Text circleDiameterText;
    [SerializeField] Text circlePerimeterText;
    [SerializeField] Text circleAreaText;

    [Header("Triangle Input and Output Fields")]
    [SerializeField] InputField triangleXAInput;
    [SerializeField] InputField triangleYAInput;
    [SerializeField] InputField triangleXBInput;
    [SerializeField] InputField triangleYBInput;
    [SerializeField] InputField triangleXCInput;
    [SerializeField] InputField triangleYCInput;
    [SerializeField] Text trianglePerimeterText;
    [SerializeField] Text triangleAreaText;
    [SerializeField] Text triangleTypeText;
    [Header("Drop Down")]
    [SerializeField] Dropdown selectedShape;
    void Start()
    {
        prepare();
    }

    public void calculateRectangle()
    {
        float xOne, yOne, xTwo, yTwo;
        float.TryParse(rectangleXOneInput.text, out xOne);
        float.TryParse(rectangleYOneInput.text, out yOne);
        float.TryParse(rectangleXTwoInput.text, out xTwo);
        float.TryParse(rectangleYTwoInput.text, out yTwo);
        Vector2 coordinatesOne = new Vector2(xOne,yOne);
        Vector2 coordinatesTwo = new Vector2(xTwo, yTwo);
        Rectangle rectangle = new Rectangle(coordinatesOne,coordinatesTwo);
        rectangleBaseText.text = rectangle.getBase().ToString();
        rectangleHeightText.text = rectangle.getHeight().ToString();
        rectanglePerimeterText.text = rectangle.getPerimeter().ToString();
        rectangleAreaText.text = rectangle.getArea().ToString();
    }

    public void calculateCircle()
    {
        float xCenter, yCenter, radius;
        float.TryParse(circleXInput.text, out xCenter);
        float.TryParse(circleYInput.text, out yCenter);
        float.TryParse(circleRadiusInput.text, out radius);
        Vector2 center = new Vector2(xCenter,yCenter);
        Circle circle = new Circle(center, radius);
        circleDiameterText.text = circle.getDiametter().ToString();
        circlePerimeterText.text = circle.getPerimeter().ToString();
        circleAreaText.text = circle.getArea().ToString();
    }

    public void calculateTriangle()
    {
        float xA, yA, xB, yB, xC, yC;
        float.TryParse(triangleXAInput.text, out xA);
        float.TryParse(triangleYAInput.text, out yA);
        Vector2 pointA = new Vector2(xA, yA);
        float.TryParse(triangleXBInput.text, out xB);
        float.TryParse(triangleYBInput.text, out yB);
        Vector2 pointB = new Vector2(xB, yB);
        float.TryParse(triangleXCInput.text, out xC);
        float.TryParse(triangleYCInput.text, out yC);
        Vector2 pointC = new Vector2(xC, yC);
        Triangle triangle = new Triangle(pointA,pointB,pointC);
        trianglePerimeterText.text = triangle.Perimeter.ToString();
        triangleAreaText.text = triangle.Area.ToString();
        triangleTypeText.text = triangle.Type.ToString();
    }

    void changeUI(Dropdown dropdown)
    {
        int index = dropdown.value + 1;

        switch (index)
        {
            case 1:
                activateCanvas(rectangleCanvas);
                deactivateCanvas(circleCanvas);
                deactivateCanvas(triangleCanvas);
                break;

            case 2:
                deactivateCanvas(rectangleCanvas);
                activateCanvas(circleCanvas);
                deactivateCanvas(triangleCanvas);
                break;
            case 3:
                deactivateCanvas(rectangleCanvas);
                deactivateCanvas(circleCanvas);
                activateCanvas(triangleCanvas);
                break;
        }          
    }

    void deactivateCanvas(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
    void activateCanvas(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    void prepare()
    {
        if (rectangleCanvas == null) rectangleCanvas.GetComponent<CanvasGroup>();
        if (circleCanvas == null) circleCanvas.GetComponent<CanvasGroup>();
        if (triangleCanvas == null) triangleCanvas.GetComponent<CanvasGroup>();

        if (rectangleXOneInput == null) rectangleXOneInput.GetComponent<InputField>();
        if (rectangleYOneInput == null) rectangleYOneInput.GetComponent<InputField>();
        if (rectangleXTwoInput == null) rectangleXTwoInput.GetComponent<InputField>();
        if (rectangleYTwoInput == null) rectangleYTwoInput.GetComponent<InputField>();
        if (rectangleBaseText == null) rectangleBaseText.GetComponent<Text>();
        if (rectangleHeightText == null) rectangleHeightText.GetComponent<Text>();
        if (rectanglePerimeterText == null) rectanglePerimeterText.GetComponent<Text>();
        if (rectangleAreaText == null) rectangleAreaText.GetComponent<Text>();

        if (circleXInput == null) circleXInput.GetComponent<InputField>();
        if (circleYInput == null) circleYInput.GetComponent<InputField>();
        if (circleRadiusInput == null) circleRadiusInput.GetComponent<InputField>();
        if (circleDiameterText == null) circleDiameterText.GetComponent<Text>();
        if (circlePerimeterText == null) circlePerimeterText.GetComponent<Text>();
        if (circleAreaText == null) circleAreaText.GetComponent<Text>();

        if (triangleXAInput == null) triangleXAInput.GetComponent<InputField>();
        if (triangleYAInput == null) triangleYAInput.GetComponent<InputField>();
        if (triangleXBInput == null) triangleXBInput.GetComponent<InputField>();
        if (triangleYBInput == null) triangleYBInput.GetComponent<InputField>();
        if (triangleXCInput == null) triangleXCInput.GetComponent<InputField>();
        if (triangleYCInput == null) triangleYCInput.GetComponent<InputField>();
        if (trianglePerimeterText == null) trianglePerimeterText.GetComponent<Text>();
        if (triangleAreaText == null) triangleAreaText.GetComponent<Text>();
        if (triangleTypeText == null) triangleTypeText.GetComponent<Text>();

        if (selectedShape == null) selectedShape.GetComponent<Dropdown>();
        selectedShape.onValueChanged.AddListener(delegate { changeUI(selectedShape); });
        changeUI(selectedShape);
    }
}
