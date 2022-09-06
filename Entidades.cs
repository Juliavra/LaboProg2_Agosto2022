using System;
using System.Text;

namespace Biblioteca
{

public class Producto
{
   private string _codigoDeBarras;
   private string _marca;
   private float _precio;
    
    
    public static explicit operator string (Producto p)
    {
        return p._codigoDeBarras.ToString();
    }
    
    public string GetMarca()
    {
        return _marca;
    }
    
    public float GetPrecio()
    {
        return _precio;
    }
    
    public static string MostrarProducto (Producto p)
    {
        
          StringBuilder sb = new StringBuilder();
     /*     sb.Append("Codigo");
            sb.Append("\t");
            sb.Append("Marca");
            sb.Append("\t");
            sb.Append("Precio");
            sb.Append("\n");
    */    
            sb.Append("Codigo: ");
            sb.Append(p._codigoDeBarras.ToString());
            sb.Append("\t");
            sb.Append("Marca: ");
            sb.Append(p._marca.ToString());
            sb.Append("\t");
            sb.Append("Precio: ");
            sb.Append(p._precio.ToString());
            sb.Append("\n");

            //Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
   
   
   #region SOBRECARGA OPERADORES

    public static bool operator == (Producto p1, Producto p2)
        {
            bool result=false;
            if ((p1._marca==p2._marca) && (p1._codigoDeBarras==p2._codigoDeBarras))
            {result=true;}
            return result;
        }

    public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1==p2);
        }
    
    public static bool operator ==(Producto p, string marca)
        {
            bool result=false;
            
            if (p._marca==marca)
            {
                result=true;
            }
            
            return result;
        }
    
    public static bool operator !=(Producto p,  string marca)
        {
            return !(p == marca); // Sobrecarga ==
        }
    
    #endregion SOBRECARGA OPERADORES
    public Producto()
    {
        _codigoDeBarras="empty";
        _marca="No Brand";
        _precio=0;
    }
    
    public Producto (string marca, string codigo, float precio)
    {
        this._marca=marca;
        this._codigoDeBarras=codigo;
        this._precio=precio;
    }

}//cLOSES Producto


public class Estante
{
    private Producto[] _productos;
    private int _ubicacionEstante;
    
    private Estante (int capacidad)
    {
        _productos = new Producto[capacidad];
    }
    
    public Estante (int capacidad, int ubicacion):this(capacidad)
    {
        this._ubicacionEstante=ubicacion;
    }
    
    public Producto[] GetProductos()
    {
        return _productos;
    }
    
    public static string MostrarEstante (Estante e) //FLOJITO
    {
         StringBuilder sb = new StringBuilder();

       foreach (Producto p in e._productos)
        {
	        Biblioteca.Producto.MostrarProducto(p);
        }

        return sb.ToString();
    }

    #region SOBRECARGA OPERADORES

    
    public static bool operator == (Estante e, Producto p)
    {
        bool result = false;
        if (e._productos!=null)
        {
            foreach (Producto pe in e._productos)
            {
                if (p==pe)
                {
                    result = true;
                    break;
                }
            }
        }
        return result;
    }

    public static bool operator != (Estante e, Producto p)
    {
        return !(e==p);
    }

    public static bool operator + (Estante e, Producto p)
    {
        bool result = false;

        if (e._productos!=null)
        {
           if (e==p)
           {
               
           }
            
            
        }
        
        
        return result;
    }


    
    /*
    
    
    
    public static Estante operator - (Estante e, Producto p)
    {
        return e==e;
    }
    


    
    */
    # endregion SOBRECARGA OPERADORES
    
    
    
}//CLOSES Estante


}//CLOSES Biblioteca

