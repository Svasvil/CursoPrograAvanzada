using MiPrimeraSolucion.abstraccion.ModelosParaUI.Clientes;
using MiPrimeraSolucion.abstraccion.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion1APS.UI.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
    public ActionResult ListaClientes()
        {

            List<ClientesDTO> ListaClientes = new List<ClientesDTO>();
            ListaClientes.Add(new ClientesDTO
            {
                IDCliente = "1",
                Nombre = "Sebastian",
                PrimerApellido = "Vasquez",
                SegundoApellido = "Villaplana",
                Telefono = 1234-5678,
                Correo = "Se02vas@gmail.com",
                estado = true
            });

            ListaClientes.Add
                (new ClientesDTO
                {
                    IDCliente = "2",
                    Nombre = "Valeria",
                    PrimerApellido = "Vasquez",
                    SegundoApellido = "Villaplana",
                    Telefono = 8765 - 4321,
                    Correo = "ValVas@gmail.com",
                    estado = true
                });


            return View(ListaClientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            ClientesDTO clienteDetalles = new ClientesDTO();
            clienteDetalles.IDCliente = "1";
            clienteDetalles.Nombre = "Sebastian";
            clienteDetalles.PrimerApellido = "Vasquez";
            clienteDetalles.SegundoApellido = "Villaplana";
            clienteDetalles.Telefono = 1234 - 5678;
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
          cliente.IDCliente = "1";
            cliente.Nombre = "Sebastian";
            cliente.PrimerApellido = "Vasquez";
            cliente.SegundoApellido = "Villaplana";
            cliente.Telefono = 1234 - 5678;
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
