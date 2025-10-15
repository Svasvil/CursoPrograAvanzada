using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.LogicaNegocio.Inventario.ListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

public class InventarioController : Controller
{
    private readonly IObtenerListaRepuestos_LogicaNegocio_ _obtenerListaRepuestosLN;
    private readonly IAgregarRepuesto_Logica_ _agregarRepuestoLogica;

    public InventarioController()
    {
        _obtenerListaRepuestosLN = new ObtenerListaRepuestos_LogicaNegocio_();
        _agregarRepuestoLogica = new AgregarRepuesto_LogicaNegocio_();
    }

    // LISTA DE REPUESTOS
    public ActionResult ListadeRepuestos()
    {
        List<InventarioDTO> laListaDeInventario = _obtenerListaRepuestosLN.Obtener();
        return View("ListadeRepuestos", laListaDeInventario);
    }


    // GET: Inventario/Details/5
    public ActionResult Details(int id)
    {
        InventarioDTO invDetalles = new InventarioDTO();
        invDetalles.codigoDelRepuesto = "2";
        invDetalles.marcaDelRepuesto = "Toyota";
        invDetalles.vehiculo = "Toyota 2001";
        invDetalles.nombreDelRepuesto = "Compensadors para llantas";
        invDetalles.cantidad = 2;
        return View(invDetalles);
    }

    // GET: Inventario/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Inventario/Create
    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<ActionResult> Create(InventarioDTO RepuestoGuardar)
    {
        if (!ModelState.IsValid)
        {
            // Debug output to see which fields are invalid
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    System.Diagnostics.Debug.WriteLine($"Validation error for {key}: {error.ErrorMessage}");
                }
            }

            return View(RepuestoGuardar);
        }

        int cantidadDeFilasAfectada = await _agregarRepuestoLogica.Agregar(RepuestoGuardar);
        return RedirectToAction("ListadeRepuestos", "Inventario");
    }


    // GET: Inventario/Editar/5
    public ActionResult Editar(int id)
    {
        InventarioDTO inventario = new InventarioDTO();
        inventario.codigoDelRepuesto = "2";
        inventario.marcaDelRepuesto = "Toyota";
        inventario.vehiculo = "Toyota 2001";
        inventario.nombreDelRepuesto = "Compensadors para llantas";
        inventario.cantidad = 2;
        return View(inventario);
    }

    // POST: Inventario/Editar/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Editar(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add update logic here
            return RedirectToAction("ListaRepuestos");
        }
        catch
        {
            return View();
        }
    }

    // GET: Inventario/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: Inventario/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add delete logic here
            return RedirectToAction("ListaRepuestos");
        }
        catch
        {
            return View();
        }
    }
}