using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book
{
    private string title;
    private string author;
    private int pages;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Pages
    {
        get { return pages; }
        set { pages = value; }
    }



    public Book(string aTitle, string anAuthor, int aPages)
    {
        title = aTitle;
        author = anAuthor;
        pages = aPages;
    }

    public Book()
    {

    }

}
