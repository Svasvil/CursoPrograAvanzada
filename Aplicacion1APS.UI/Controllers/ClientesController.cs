using Microsoft.VisualBasic;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.ListaDeClientes;
using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Inventario.AgregarRepuesto;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.Cliente.AgregarCliente;
using MiPrimeraSolucion.LogicaNegocio.Cliente.ListaDeClientes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion1APS.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IListaClientes_LN _ListaClientes_LN;
        private readonly IAgregarClienteLN _agregarClienteLogica;
        


        public ClientesController() : this(new ListaClientes_LN())
        {
           
        }


        public ClientesController(IListaClientes_LN listaClientes_LN)
        {
            
            _ListaClientes_LN = new ListaClientes_LN();
            _agregarClienteLogica = new AgregarClienteLN();
        }

        // GET: Clientes
        public ActionResult ListaClientes()
        {
            List<ClientesDTO> ListaClientes = _ListaClientes_LN.Obtener();

            return View(ListaClientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            ClientesDTO clienteDetalles = new ClientesDTO();
            clienteDetalles.IDCliente = 1;  
            clienteDetalles.Nombre = "Sebastian";
            clienteDetalles.PrimerApellido = "Vasquez";
            clienteDetalles.SegundoApellido = "Villaplana";
            clienteDetalles.Telefono = "+506 1234-5678";  
            clienteDetalles.Correo = "se02vas@gmail.com";
            clienteDetalles.estado = true;

            return View(clienteDetalles);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            //basicamente nos muestra la view de create vacia para nosotros llenarla 
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClientesDTO NuevoCliente)
        {
            if (!ModelState.IsValid)
            {
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    foreach (var error in state.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Validation error for {key}: {error.ErrorMessage}");
                    }
                }

                return View(NuevoCliente);
            }

            int cantidadDeFilasAfectada = await _agregarClienteLogica.Agregar(NuevoCliente);
            return RedirectToAction("ListaClientes");

        }




        // GET: Clientes/Edit/5
        public ActionResult Editar(int id)
        {
            ClientesDTO cliente = new ClientesDTO();
            cliente.IDCliente = 1;  
            cliente.Nombre = "Sebastian";
            cliente.PrimerApellido = "Vasquez";
            cliente.SegundoApellido = "Villaplana";
            cliente.Telefono = "+506 1234-5678"; 
            cliente.Correo = "se02vas@gmail.com";
            cliente.estado = true;

            return View(cliente);
        }

        // POST: Clientes/Edit/5
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

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
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