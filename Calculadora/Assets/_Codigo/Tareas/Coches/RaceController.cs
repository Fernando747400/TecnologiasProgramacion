using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RaceController : MonoBehaviour
{
    private VehicleDetailed Enzo = new VehicleDetailed("Rojo",1470,1.14,9.56857,2,2,12,110,351,6,"Ferrari Enzo"); //color, peso, altura, area, puertas, pasajeros, cilindros, gasolina, velocidad máxima, velocidades, nombre
    private VehicleDetailed Veyron = new VehicleDetailed("Negro", 1990, 1.20, 8.915076, 2, 2, 16, 100, 407, 7, "Buggati Veyron");
    private VehicleDetailed Aventador = new VehicleDetailed("Negro", 1740, 1.13, 9.73791, 2, 2, 12, 85, 350, 7, "Lamborghini Aventador");
    private VehicleDetailed GTR = new VehicleDetailed("Blanco", 1827, 1.37, 8.92545, 2, 4, 6, 74, 315, 6, "Nissan GT-R");
    private VehicleDetailed Quattroporte = new VehicleDetailed("Gris", 1995, 1.18, 10.254272, 4, 5, 6, 80, 288, 6, "Maserati Quattroporte");
    private VehicleDetailed Agera = new VehicleDetailed("Rojo", 1435, 1.12, 6.289, 2, 2, 8, 82, 447, 7, "Koenigsegg Agera");
    private VehicleDetailed Urus = new VehicleDetailed("Amarillo", 2272, 1.63, 10.305792, 4, 5, 8, 85, 305, 8, "Lamborghini Urus");
    private VehicleDetailed Carrera = new VehicleDetailed("Blanco", 1590, 1.30, 8.369188, 2, 4, 12, 64, 308, 6, "Porsche 911 Carrera");
    private VehicleDetailed Chiron = new VehicleDetailed("Azul", 2070, 1.21, 9.281052, 2, 2, 16, 100, 420, 7, "Buggati Chiron");
    private VehicleDetailed GT = new VehicleDetailed("Azul", 1460, 1.10, 9.572337, 2, 2, 6, 58, 347, 7, "Ford GT");
    private List<VehicleDetailed> carList = new List<VehicleDetailed>(10);
    private double raceLength = 200;
    [Header("Drop Down List")]
    [SerializeField] private Dropdown firstCarDropDown;
    [SerializeField] private Dropdown secondCarDropDown;
    [Header("Textos primer coche")]
    [SerializeField] Text firstNameText;
    [SerializeField] Text firstColorText;
    [SerializeField] Text firstWeightText;
    [SerializeField] Text firstHeightText;
    [SerializeField] Text firstAreaText;
    [SerializeField] Text firstDoorsText;
    [SerializeField] Text firstPassengersText;
    [SerializeField] Text firstCylindersText;
    [SerializeField] Text firstGasolineText;
    [SerializeField] Text firstTopspeedText;
    [SerializeField] Text firstGearboxText;
    [Header ("Textos segundo coche")]
    [SerializeField] Text secondNameText;
    [SerializeField] Text secondColorText;
    [SerializeField] Text secondWeightText;
    [SerializeField] Text secondHeightText;
    [SerializeField] Text secondAreaText;
    [SerializeField] Text secondDoorsText;
    [SerializeField] Text secondPassengersText;
    [SerializeField] Text secondCylindersText;
    [SerializeField] Text secondGasolineText;
    [SerializeField] Text secondTopspeedText;
    [SerializeField] Text secondGearboxText;
    [Header("Textos Salidas")]
    [SerializeField] Text textTimeFirstCar;
    [SerializeField] Text textTimeSecondCar;
    [SerializeField] Text winnerText;
    [SerializeField] Text runnerUpText;
    [SerializeField] Text timeDifference;

     void Start()
    {
        initialize();
        prepare();
        poblateDropDown();
    }

    // Update is called once per frame
  


    void race(Dropdown firstDropDown, Dropdown secondDropDown)
    {
        int firstIndex = firstDropDown.value;
        int secondIndex = secondDropDown.value;
        double speedFirst = carList[firstIndex].TopSpeed * 0.277778;
        double speedSecond = carList[secondIndex].TopSpeed * 0.277778;
        double timeFirst = speedFirst / raceLength;
        double timeSecond = speedSecond / raceLength;
        textTimeFirstCar.text = timeFirst.ToString() + " segundos";
        textTimeSecondCar.text = timeSecond.ToString() + " segundos";

        if(timeFirst > timeSecond)
        {
            winnerText.text = "Ganó el: " + carList[firstIndex].Name + " en: " + timeFirst + " segundos";
            runnerUpText.text = "Quedó en segundo lugar el: " + carList[secondIndex].Name + " en: " + timeSecond + " segundos";
            timeDifference.text = "Diferencia de: " + (timeFirst - timeSecond) + " segundos";
        } else if (timeFirst < timeSecond)
        {
            winnerText.text = "Ganó el: " + carList[secondIndex].Name + " en: " + timeFirst + " segundos";
            runnerUpText.text = "Quedó en segundo lugar el: " + carList[firstIndex].Name + " en: " + timeSecond + " segundos";
            timeDifference.text = "Diferencia de: " + (timeSecond - timeFirst) + " segundos";
        } else if (timeFirst == timeSecond)
        {
            winnerText.text = "Empate";
            runnerUpText.text = "Empate";
            timeDifference.text = "Empate";
        }
    }


    void populateText(Dropdown firstDropDown, Dropdown secondDropDown)
    {
        int firstIndex = firstDropDown.value;
        int secondIndex = secondDropDown.value;
        firstNameText.text = carList[firstIndex].Name;
        firstColorText.text = carList[firstIndex].Color;
        firstWeightText.text = carList[firstIndex].Weight.ToString();
        firstHeightText.text = carList[firstIndex].Height.ToString();
        firstAreaText.text = carList[firstIndex].Area.ToString();
        firstDoorsText.text = carList[firstIndex].Doors.ToString();
        firstPassengersText.text = carList[firstIndex].Passenger.ToString();
        firstCylindersText.text = carList[firstIndex].Cylinders.ToString();
        firstGasolineText.text = carList[firstIndex].Gasoline.ToString();
        firstTopspeedText.text = carList[firstIndex].TopSpeed.ToString();
        firstGearboxText.text = carList[firstIndex].Gearbox.ToString();

        secondNameText.text = carList[secondIndex].Name;
        secondColorText.text = carList[secondIndex].Color;
        secondWeightText.text = carList[secondIndex].Weight.ToString();
        secondHeightText.text = carList[secondIndex].Height.ToString();
        secondAreaText.text = carList[secondIndex].Area.ToString();
        secondDoorsText.text = carList[secondIndex].Doors.ToString();
        secondPassengersText.text = carList[secondIndex].Passenger.ToString();
        secondCylindersText.text = carList[secondIndex].Cylinders.ToString();
        secondGasolineText.text = carList[secondIndex].Gasoline.ToString();
        secondTopspeedText.text = carList[secondIndex].TopSpeed.ToString();
        secondGearboxText.text = carList[secondIndex].Gearbox.ToString();
    }

    void poblateDropDown()
    {
            foreach (var car in carList)
            {
                firstCarDropDown.options.Add(new Dropdown.OptionData() { text = car.Name.ToString() });
                secondCarDropDown.options.Add(new Dropdown.OptionData() { text = car.Name.ToString() });
            }
            firstCarDropDown.RefreshShownValue();
            secondCarDropDown.RefreshShownValue();
    }

    void prepare()
    {
        carList.Add(Enzo);
        carList.Add(Veyron);
        carList.Add(Aventador);
        carList.Add(GTR);
        carList.Add(Quattroporte);
        carList.Add(Agera);
        carList.Add(Urus);
        carList.Add(Carrera);
        carList.Add(Chiron);
        carList.Add(GT);

        firstCarDropDown.onValueChanged.AddListener(delegate { dropDownItemChanged(); });
        secondCarDropDown.onValueChanged.AddListener(delegate { dropDownItemChanged(); });
        populateText(firstCarDropDown, secondCarDropDown);
        populateText(firstCarDropDown, secondCarDropDown);
    }
    void dropDownItemChanged()
    {
        Debug.Log("estoy funcionando");
        race(firstCarDropDown, secondCarDropDown);
        populateText(firstCarDropDown, secondCarDropDown);
    }

    public void initialize()
    {
        if (firstCarDropDown == null) firstCarDropDown.GetComponent<Dropdown>();
        if (secondCarDropDown == null) secondCarDropDown.GetComponent<Dropdown>();
        if (firstNameText == null) firstNameText.GetComponent<Text>();
        if (firstColorText == null) firstColorText.GetComponent<Text>();
        if (firstWeightText == null) firstWeightText.GetComponent<Text>();
        if (firstHeightText == null) firstHeightText.GetComponent<Text>();
        if (firstDoorsText == null) firstDoorsText.GetComponent<Text>();
        if (firstPassengersText == null) firstPassengersText.GetComponent<Text>();
        if (firstCylindersText == null) firstCylindersText.GetComponent<Text>();
        if (firstGasolineText == null) firstGasolineText.GetComponent<Text>();
        if (firstTopspeedText == null) firstTopspeedText.GetComponent<Text>();
        if (firstGearboxText == null) firstGearboxText.GetComponent<Text>();
        if (secondNameText == null) secondNameText.GetComponent<Text>();
        if (secondColorText == null) secondColorText.GetComponent<Text>();
        if (secondWeightText == null) secondWeightText.GetComponent<Text>();
        if (secondHeightText == null) secondHeightText.GetComponent<Text>();
        if (secondDoorsText == null) secondDoorsText.GetComponent<Text>();
        if (secondPassengersText == null) secondPassengersText.GetComponent<Text>();
        if (secondCylindersText == null) secondCylindersText.GetComponent<Text>();
        if (secondGasolineText == null) secondGasolineText.GetComponent<Text>();
        if (secondTopspeedText == null) secondTopspeedText.GetComponent<Text>();
        if (secondGearboxText == null) secondGearboxText.GetComponent<Text>();
    }

    public VehicleDetailed raceTest(int firstCar, int secondCar)
    {
        carList.Add(Enzo);
        carList.Add(Veyron);
        carList.Add(Aventador);
        carList.Add(GTR);
        carList.Add(Quattroporte);
        carList.Add(Agera);
        carList.Add(Urus);
        carList.Add(Carrera);
        carList.Add(Chiron);
        carList.Add(GT);

        int firstIndex = firstCar;
        int secondIndex = secondCar;
        double speedFirst = carList[firstIndex].TopSpeed * 0.277778;
        double speedSecond = carList[secondIndex].TopSpeed * 0.277778;
        double timeFirst = speedFirst / raceLength;
        double timeSecond = speedSecond / raceLength;

        if (timeFirst > timeSecond)
        {
            return carList[firstIndex];
        }
        else if (timeFirst < timeSecond)
        {
            return carList[secondIndex];
        }
        else if (timeFirst == timeSecond)
        {
            return null;
        }
        return null;
    }

}
