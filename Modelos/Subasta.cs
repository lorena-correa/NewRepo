using appSubastaTrabajo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

public class Subasta
{
    public string NombreProducto => Producto?.Nombre;

    public Producto Producto { get; set; }
    public decimal PrecioActual { get; set; }
    public bool Activa { get; set; } = true;

    public UsuarioDTO Ganador { get; set; }

    public SubastaStrategy Estrategia { get; set; }

    public List<Oferta> Ofertas { get; set; } = new List<Oferta>();

    public void Ofertar(UsuarioDTO usuario, decimal monto)
    {
        if (!Activa)
            throw new Exception("La subasta está cerrada");

        if (usuario == null)
            throw new Exception("Usuario inválido");

        if (monto <= 0)
            throw new Exception("El monto debe ser mayor a 0");

        if (Estrategia == null)
            throw new Exception("No hay estrategia definida");

        Estrategia.RealizarOferta(this, usuario, monto);
    }

    public void CerrarSubasta()
    {
        Activa = false;

        if (Ofertas.Any())
        {
            var mejor = Ofertas.OrderByDescending(o => o.Monto).First();

            Ganador = mejor.Usuario;
            PrecioActual = mejor.Monto;
        }
    }
}