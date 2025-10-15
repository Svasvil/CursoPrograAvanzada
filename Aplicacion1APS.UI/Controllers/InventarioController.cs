using MiPrimeraSolucion.abstraccion.DataAcces.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.ListaDeRepuestos;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.LogicaNegocio.Inventario.ListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion1APS.UI.Controllers
{
    public class InventarioController : Controller
    {
        
        private readonly IObtenerListaRepuestos_LogicaNegocio_ _obtenerListaRepuestosLN;

        
        private readonly IAgregarRepuesto_Logica_ _agregarRepuestoLogica;

        public InventarioController()
        {
            _obtenerListaRepuestosLN = new ObtenerListaRepuestos_LogicaNegocio_();
            _agregarRepuestoLogica = new AgregarRepuesto_LogicaNegocio_();
        }

        public ActionResult ListaRepuestos()
        {
            List<InventarioDTO> laListaDeInventario = _obtenerListaRepuestosLN.Obtener();

            return View("ListadeRespuestos", laListaDeInventario);
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
            return View();
        }

        // POST: Invetario/Create
        [HttpPost]
        public async Task<ActionResult> Create(InventarioDTO RepuestoGuardar)
        {
            try
            {
                
                int cantidadDeFilasAfectada = await _agregarRepuestoLogica.Agregar(RepuestoGuardar);
                return RedirectToAction("ListaRepuestos");

            }
            catch
            {
                return View(RepuestoGuardar);
            }
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