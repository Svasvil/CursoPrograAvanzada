using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.Inventario.ListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion1APS.UI.Controllers
{
    public class InventarioController : Controller
    {

        private readonly IObtenerListaRepuestos_LogicaNegocio_ _ObtenerListaRepuestosLN;
    public InventarioController()
        {
            _ObtenerListaRepuestosLN = new ObtenerListaRepuestos_LogicaNegocio_ ();
        }


        //Get inventario.
        public ActionResult ListadeRespuestos()
        {
            List<InventarioDTO> lalistaDeInventario = _ObtenerListaRepuestosLN.Obtener();

            return View(lalistaDeInventario);
        }

        // GET: Invetario/Details/5
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

        // GET: Invetario/Create
        public ActionResult Create()
        {
            //basicamente nos muestra la view de create vacia para nosotros llenarla 
            return View(new InventarioDTO());
        }

        // POST: Invetario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return RedirectToAction("lista Inventario");
        }

        // GET: Invetario/Edit/5
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

        // POST: Invetario/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Invetario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invetario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}