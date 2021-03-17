using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDetailed : Book
{
    private string genre;
    private int year;
    private string condition;
    private string color;

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }


    public int Year
    {
        get { return year; }
        set { year = value; }
    }


    public string Condition
    {
        get { return condition; }
        set { condition = value; }
    }

 
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public BookDetailed(string aTitle, string anAuthor, int aPages, string aGenre, int aYear, string aCondition, string aColor)
    {
        Title = aTitle;
        Author = anAuthor;
        Pages = aPages;
        Genre = aGenre;
        Year = aYear;
        Condition = aCondition;
        Color = aColor;
    }

    public BookDetailed() 
    {
        
    }
}
