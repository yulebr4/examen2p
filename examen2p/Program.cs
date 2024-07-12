using System;

public class MaterialBibliografico
{

    public string Titulo;
    public string Autor;

    public MaterialBibliografico(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;

    }

    public static void MostrarInformacion()
    {
        Console.WriteLine(($"Título: {Titulo}, Autor: {Autor}"));
    }
}

//Aqui derivo

public class Libro : MaterialBibliografico
{
    public int NumeroDePaginas;

    public Libro (string titulo, string autor, string numeroDePaginas)
        : base(titulo, autor);

        public void MostrarInformacion();

}

public class Revista : MaterialBibliografico
{
    public int NumeroDePaginas;

    public Libro(string titulo, string autor, string numeroDePaginas,string revista)
        : base(titulo, autor)

        public void MostrarInformacion();

