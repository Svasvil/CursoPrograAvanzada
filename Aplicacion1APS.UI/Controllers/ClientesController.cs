using MiPrimeraSolucion.abstraccion.LogicaDeNegocio.Cliente.ListaDeClientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaNegocio.Cliente.ListaDeClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion1APS.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IListaClientes_LN _ListaClientes_LN;

        // *******************************************************************
        // 1. CONSTRUCTOR SIN PARÁMETROS (AGREGADO PARA RESOLVER EL ERROR)
        // Llama al constructor que tiene la dependencia, pasando la implementación concreta.
        // Esto permite que el activador de MVC cree la instancia del controlador.
        // *******************************************************************
        public ClientesController() : this(new ListaClientes_LN())
        {
            // Este constructor llama al que toma argumentos, asegurando que _ListaClientes_LN se inicialice.
        }

        // *******************************************************************
        // 2. CONSTRUCTOR CON DEPENDENCIAS (Mantenido para Inyección de Dependencias)
        // Este constructor ahora recibe el objeto y lo asigna.
        // *******************************************************************
        public ClientesController(IListaClientes_LN listaClientes_LN)
        {
            // Nota: Aquí se usa 'listaClientes_LN' que es el argumento, no 'new ListaClientes_LN()'
            // La inicialización con 'new' se maneja ahora en el constructor sin parámetros (arriba).
            _ListaClientes_LN = listaClientes_LN;
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
            return View(new ClientesDTO());
        }


        [HttpPost]
        public ActionResult Create(ClientesDTO nuevoCliente)
        {

            //nos lleva a la lista
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