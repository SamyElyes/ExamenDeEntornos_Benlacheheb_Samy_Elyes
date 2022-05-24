
using System;


//namespace EDexamenT6a8

/// <summary>
/// <para>La clase cafetera deberia estar en mayuscula.</para>
/// <para>La clase cafetera tiene varios atributos de una cafetera con la adiccion de otros métodos que rellenan agua/capsulas de una cafetera.</para>
/// </summary>
class Cafetera
{
    /// <summary>
    /// <para>En este caso las variables marcaCafetera y modelo no estaban bien escritas ya que no eran nombres intuitivos.</para>
    /// <para>El constructor siguiente asigna los valores que se pasan por parámetro a las propiedades automáticas.</para>
    /// </summary>
    /// <param name="marca">El nombre de la variable ha sido cambiado a marca.</param>
    /// <param name="modelo">El nombre de la variable ha sido cambiado a modelo.</param>
    /// <param name="cantidadAgua">No se ha cambiado el nombre de la variable.</param>
    /// <param name="totalDeCapsulas">El nombre de la variable ha sido cambiado a totalDeCapsulas.</param>


    public Cafetera(string marca, string modelo, double cantidadAgua, double totalDeCapsulas)
    {
        this.Marca = marca; //marca de la máquina cafetera
        this.Modelo = modelo; //referencia del modelo
        this.TotalCapsulas = totalDeCapsulas; //Total de cápsulas en la máquina. 
        this.Agua = cantidadAgua; //Cantidad de agua en el recipiente. 
    }




    /// <permission>
    /// las propiedades automaticas no se pueden cambiar desde otra clase que no sea heredera de la actual, solo por un constructor o un método que tenga acceso.
    /// </permission>
    /// <remarks>La clase cafetera no puede tener los campos publicos deberia tenerlos privados o protegidos.</remarks>
    public string Marca { get; set; } //La marca de la cafetera
    public string Modelo { get; set; } //El modelo de la cafetera
    public double Agua { get; set; } //Cantidad De agua
    public double TotalCapsulas { get; set; } //El numero de capsulas que posee

    /// <summary>
    /// <para>El siguente método consiste en devolver el numero de cafés a hacer.</para>
    /// <para>Se ha cambiado el nombre del método porque no estaba en mayusculas la primera letra.</para>
    /// </summary>
    /// <param name="numeroDeCafe">Se ha cambiado el nombre de la variable</param>
    /// <returns>si falta agua o si queda y cuanto</returns>
    public string ConsumoAgua(double numeroDeCafe) //numero de cafés a hacer
    {
        
        const double Constante = 0.1;     ///<remarks>La constante debe estar en mayusculas, se ha añadido (const) para especificar que es una constante.</remarks>

        this.Agua = this.Agua - numeroDeCafe * Constante; //Constante de consumo de agua 0.1l por cada unidad de café. 
        if (this.Agua < 0.1)
        {
            this.Agua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else 
        { 
            return "Quedan" + this.Agua + " centilitros"; //la colocación de las llaves se debe hacer en líneas reservadas para cada una de ellas, sin ninguna otra instrucción en la línea
        }
    }

    /// <summary>
    /// <para>El método consume capsulas de café, en el caso de que no queden avisa que no hay.</para>
    /// <para>Se ha cambiado el nombre del método siguiente a ConsumoCapsulas porque la primera letra no estaba en mayuscula.</para>
    /// </summary>
    /// <param name="numeroDeCafe">Cambio de la variable de numerodecafe a NumeroDeCafé.</param>
    /// <returns>Si faltan cápsulas o si quedan y cuanto quedan</returns>
    public string ConsumoCapsulas(double numeroDeCafe) //Hacer un café 
    {
        this.TotalCapsulas = this.TotalCapsulas - numeroDeCafe;
        if (this.TotalCapsulas < 0)
        {
            this.TotalCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else
        {
            return "Quedan" + this.TotalCapsulas + "unidades";
        }
    }
    /// <summary>
    /// <para>En el caso de que no quden capsulas para hacer café, este método rellena x capsulas.</para>
    /// <para>Cambio del nombre del método porque no estaba escrito en mayusculas.</para>
    /// </summary>
    /// <param name="cantidadCapsulas">Modificación del nombre de la variable.</param>
    /// <returns>El numero de capsulas que hay.</returns>
    public double ReponerCapsulas(double cantidadCapsulas)
    {
        this.TotalCapsulas = this.TotalCapsulas + cantidadCapsulas;
        return this.TotalCapsulas;
    }
    /// <summary>
    /// <para>En el caso de que no quede agua, esta función se encarga de rellenar el depósito de agua.</para>
    /// <para>Cambio del nombre del método porque no estaba escrito en mayusculas.</para>
    /// </summary>
    /// <param name="litros"></param>
    /// <returns></returns>
    public double LLenarDepositorio(double litros)
    {
        this.Agua = this.Agua + litros;
        return this.Agua;
    }

    /// <summary>
    /// Cambio del nombre del método porque no estaba escrito en mayusculas.
    /// <remark>El codigo siguiente no cumple su funcionamiento.
    /// <code>
    ///     Console.WriteLine(this.Marca);
    ///     Console.WriteLine(this.Modelo);
    /// </code>
    /// </remark>
    /// </summary>
    /// <param name="modelo">Modificación del nombre de la variable.</param>
    /// <param name="marca">Modificación del nombre de la variable.</param>
    public void VerEspecificacion(string modelo, string marca)
    {
        this.Marca = marca;
        this.Modelo = modelo;
    }

}

/// <summary>
/// <para>La clase cafetera deberia estar en mayuscula</para>
/// </summary>
class EjemploDeMiCafetera
{

    static void main()
    {


        Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7); //Instancia de una cafetera.

        //Todo lo que se verá por pantalla.
        Console.WriteLine(mi_cafetera_ejemplo.Agua); //0.6
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5)); // "Quedan 2 unidades";
        Console.WriteLine(mi_cafetera_ejemplo.TotalCapsulas); //2
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5)); //"Quedan 0.1 centilitros"
        Console.WriteLine(mi_cafetera_ejemplo.Agua); //0.1
        mi_cafetera_ejemplo.LLenarDepositorio(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.Agua); //0.6
        mi_cafetera_ejemplo.ReponerCapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.TotalCapsulas); //5


    }

}