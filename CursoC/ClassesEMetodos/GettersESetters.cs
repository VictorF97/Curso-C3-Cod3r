using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC.ClassesEMetodos;
public class Moto
{
    //só conseguimos acessar atributos privados atraves de metodos
    private string Marca;
    private string Modelo;
    private uint Cilindrada; //cilindrada é sempre positivo

    public Moto(string marca, string modelo, uint cilindrada)
    {
        SetMarca(marca);
        SetModelo(modelo);
        SetCilindrada(cilindrada);
    }   

    public Moto() { }

    public string GetMarca()
    {
        return Marca;
    }

    public void SetMarca(string marca)
    {
        Marca = marca;
    }

    public string GetModelo()
    {
        return Modelo;
    }

    public void SetModelo(string modelo) 
    {
        Modelo = modelo;
    }

    public uint GetCilindrada()
    {
        return Cilindrada;
    }

    public void SetCilindrada(uint cilindrada)
    {
        // 1 OPÇÃO
        // if(cilindrada > 0)
        // {
        //     Cilindrada = cilindrada;
        // }
        // 2 OPÇÃO
        //pega o valor passado e transforma em positivo
        //Cilindrada = Math.Abs(cilindrada);
        // 3 OPÇÃO
        Cilindrada = cilindrada;
    }

}
internal class GettersESetters
{
    public static void Executar()
    {
        var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
        Console.WriteLine(moto1.GetMarca());
        Console.WriteLine(moto1.GetModelo());
        Console.WriteLine(moto1.GetCilindrada());

        var moto2 = new Moto();
        moto2.SetMarca("Honda");
        moto2.SetModelo("CG Titan");
        Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
    }
}
