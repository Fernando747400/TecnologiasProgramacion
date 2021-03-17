using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraryController : MonoBehaviour
{
    [Header("Textos Salida")]
    [SerializeField] private Text titleText;
    [SerializeField] private Text authorText;
    [SerializeField] private Text pagesText;
    [SerializeField] private Text genreText;
    [SerializeField] private Text yearText;
    [SerializeField] private Text conditionText;
    [SerializeField] private Text colorText;
    [SerializeField] private Text statusText;
    [Header("Input Field")]
    [SerializeField] private InputField titleInputField;
    [SerializeField] private InputField authorInputField;
    [SerializeField] private InputField pagesInputField;
    [SerializeField] private InputField genreInputField;
    [SerializeField] private InputField yearInputField;
    [SerializeField] private InputField conditionInputField;
    [SerializeField] private InputField colorInputField;
    [Header("Drop Down")]
    [SerializeField] private Dropdown dropdownSelection;
    [Header("Buttons")]
    [SerializeField] private Button addBookButton;
    [SerializeField] private Button deleteBookButton;
    private string title;
    private string author;
    private int pages;
    private string genre;
    private int year;
    private string condition;
    private string color;
    private static int capacity = 10;
    private BookDetailed temporal;

    private List<BookDetailed> Libros = new List<BookDetailed>(capacity);
    BookDetailed TestBook = new BookDetailed("La pirámide roja", "Rick Ryordan", 471, "Fantasía", 2016, "Excelente", "Amarillo");
    void Start()
    {
        Libros.Add(TestBook);
        prepare();       
    }

    // Update is called once per frame
    void Update()
    {
        checkCapacity();
    }

    public void addNewBook()
    {
        readInput();
        if (Libros.Count != capacity)
        {
            temporal = new BookDetailed(title,author,pages,genre,year,condition,color);
            Libros.Add(temporal);
            poblateDropDown();
            statusText.text = "Libro añadido correctamente";
        } 
    }

    public void deleteSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        if (Libros.Count > 1)
        {
            Libros.RemoveAt(index);
            poblateDropDown();
            statusText.text = "Libro eliminado correctamente";
        }
        else Debug.Log("Se neceista mínimo 1 libro");

    }

    void readInput()
    {
        title = titleInputField.text;
        if (title == "") title = "Título genérico"; 
        author = authorInputField.text;
        int.TryParse(pagesInputField.text,out pages);
        genre = genreInputField.text;
        int.TryParse(yearInputField.text,out year);
        condition = conditionInputField.text;
        color = colorInputField.text;
    }

    public void poblateTexts(Dropdown dropdown)
    {
        int index = dropdown.value;
        BookDetailed selected = Libros[index];
        titleText.text = selected.Title;
        authorText.text = selected.Author;
        pagesText.text = selected.Pages.ToString();
        genreText.text = selected.Genre;
        yearText.text = selected.Year.ToString();
        conditionText.text = selected.Condition;
        colorText.text = selected.Color;
    }


    void firstPoblateDropDown()
    {
        if (Libros.Count != 0)
        {
            foreach (var Libro in Libros)
            {
                dropdownSelection.options.Add(new Dropdown.OptionData() { text = Libro.Title.ToString() });
            }
            dropdownSelection.RefreshShownValue();
            poblateTexts(dropdownSelection);
        }
    }

    void poblateDropDown()
    {
        if (Libros.Count != 0)
        {
            dropdownSelection.ClearOptions();
            foreach (var Libro in Libros)
            {
                dropdownSelection.options.Add(new Dropdown.OptionData() { text = Libro.Title.ToString() });
            }
            dropdownSelection.RefreshShownValue();
            poblateTexts(dropdownSelection);
        }
    }

    void checkCapacity()
    {
        if (Libros.Count == capacity)
        {
            addBookButton.gameObject.SetActive(false);
            deleteBookButton.gameObject.SetActive(true);
        }
        else
        {
            addBookButton.gameObject.SetActive(true);
            deleteBookButton.gameObject.SetActive(false);
        }
    }

    void prepare()
    {
        if (titleText == null) titleText = GetComponent<Text>();
        if (authorText == null) authorText = GetComponent<Text>();
        if (pagesText == null) pagesText = GetComponent<Text>();
        if (genreText == null) genreText = GetComponent<Text>();
        if (yearText == null) yearText = GetComponent<Text>();
        if (conditionText == null) conditionText = GetComponent<Text>();
        if (colorText == null) colorText = GetComponent<Text>();
        if (statusText == null) statusText = GetComponent<Text>();
        if (titleInputField == null) titleInputField = GetComponent<InputField>();
        if (authorInputField == null) authorInputField = GetComponent<InputField>();
        if (pagesInputField == null) pagesInputField = GetComponent<InputField>();
        if (genreInputField == null) genreInputField = GetComponent<InputField>();
        if (yearInputField == null) yearInputField = GetComponent<InputField>();
        if (conditionInputField == null) conditionInputField = GetComponent<InputField>();
        if (colorInputField == null) colorInputField = GetComponent<InputField>();
        if (dropdownSelection == null) dropdownSelection = GetComponent<Dropdown>();
        if (addBookButton == null) addBookButton = GetComponent<Button>();
        if (deleteBookButton == null) deleteBookButton = GetComponent<Button>();
        firstPoblateDropDown();
    }

}
