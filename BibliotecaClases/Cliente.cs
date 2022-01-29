using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaClases
{
    public class Cliente
    {
        private string _descripcionConvenio;

        #region Propiedades
        public string rut_cliente { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Nullable<int> telefono { get; set; }
        public string email { get; set; }
        public int id_convenio { get; set; }

        public string DescripcionConvenio => _descripcionConvenio;





        #endregion

        #region Contructores
        public Cliente()
        {
            this.Init();
        }

        private void Init()
        {
            rut_cliente = string.Empty;
            nombre = string.Empty;
            direccion = string.Empty;
            telefono = 0;
            email = string.Empty;
            id_convenio = 0;


        }
        #endregion

        //crear un nuevo registro de cliente 
        public bool Create()
        {
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            BDServiexpress.Cliente cli = new BDServiexpress.Cliente();

            try
            {
                CommonBC.Syncronize(this, cli);
                bd.Cliente.Add(cli);
                bd.SaveChanges();
                return true;


            }
            catch (Exception ex)
            {
                bd.Cliente.Remove(cli);
                return false;
            }

        }

        //leer un registro de cliente
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Cliente cliente =
                    bd.Cliente.First(ae => ae.rut_cliente == rut_cliente);
                CommonBC.Syncronize(cliente, this);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Cliente> ReadAll()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creacion de una lista de datos
                List<BDServiexpress.Cliente> listaDatos = bd.Cliente.ToList();
                //Creacion de una lista de negocio
                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {

                return new List<Cliente>();
            }
        }

        private List<Cliente> GenerarLista(List<BDServiexpress.Cliente> listaDatos)
        {
            List<Cliente> listaNegocio = new List<Cliente>();
            foreach (BDServiexpress.Cliente datos in listaDatos)
            {
                Cliente negocio = new Cliente();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
                negocio.LeerDescripcionConvenio();

            }
            return listaNegocio;
        }

        //Actualizar un registro 

        public bool Update()
        {
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();

            try
            {
                BDServiexpress.Cliente cli = bd.Cliente.First(b => b.rut_cliente == rut_cliente);
                CommonBC.Syncronize(this, cli);
                bd.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //ELiminar un registro 
        public bool Delete()
        {
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Cliente cli = bd.Cliente.First(b => b.rut_cliente == rut_cliente);
                bd.Cliente.Remove(cli);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {

                return false;
            }

            return true;
        }

        public void LeerDescripcionConvenio()
        {
            Convenio convenio = new Convenio() { id_convenio = id_convenio };
            if (convenio.Read())
            {
                _descripcionConvenio = convenio.descripcion;
            }
            else
            {
                _descripcionConvenio = string.Empty;
            }

        }

        public List<Cliente> ReadByRut(string rut_cliente)
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creacion de una lista de datos
                List<BDServiexpress.Cliente> listaDatos =
                    bd.Cliente.Where(c => c.rut_cliente == rut_cliente).ToList<BDServiexpress.Cliente>();

                //Creacion de una lista de negocio
                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {

                return new List<Cliente>();
            }
        }

        public List<Cliente> ReadByConvenio(int id_convenio)
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creacion de una lista de datos
                List<BDServiexpress.Cliente> listaDatos =
                    bd.Cliente.Where(c => c.id_convenio == id_convenio).ToList<BDServiexpress.Cliente>();

                //Creacion de una lista de negocio
                List<Cliente> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {

                return new List<Cliente>();
            }
        }

    }
}
