using System;

class FechaConDatetime
{
    // Internamente usamos un único objeto DateTime privado
    private DateTime fecha;

    // Constructor
    public FechaConDatetime(int dia, int mes, int anio)
    {
        if (EsFechaValida(dia, mes, anio))
        {
            fecha = new DateTime(anio, mes, dia);
        }
        else
        {
            throw new ArgumentException("Fecha inválida.");
        }
    }

    // Método público: formato corto
    public string ObtenerFormatoCorto()
    {
        return fecha.ToString("dd/MM/yyyy");
    }

    // Cambiar la fecha
    public void CambiarFecha(int nuevoDia, int nuevoMes, int nuevoAnio)
    {
        if (EsFechaValida(nuevoDia, nuevoMes, nuevoAnio))
        {
            fecha = new DateTime(nuevoAnio, nuevoMes, nuevoDia);
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es válida.");
        }
    }

    // Validación de fecha
    private bool EsFechaValida(int d, int m, int a)
    {
        try
        {
            DateTime f = new DateTime(a, m, d);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
