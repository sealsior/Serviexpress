using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class IngresoTaller
    {
        private string _descripcion;
        private string _nombre;
        private string _nombrefabricante;
        #region Propiedades
        public int num_ingreso { get; set; }
        public string patente { get; set; }
        public int id_fabricante { get; set; }
        public int anno { get; set; }
        public string modelo { get; set; }
        public int id_servicio { get; set; }
        public string rut_cliente { get; set; }

        public string Descripcion { get { return _descripcion; } }
        public string Nombre { get { return _nombre; } }
        public string Nombrefabricante { get { return _nombrefabricante; } }
        #endregion

        #region Constructores
        public IngresoTaller()
        {
            this.init();
        }

        private void init()
        {
            num_ingreso = 0;
            patente = string.Empty;
            id_fabricante = 0;
            anno = 0;
            modelo = string.Empty;
            id_servicio = 0;
            rut_cliente = string.Empty;

            _descripcion = string.Empty;
            _nombrefabricante = string.Empty;
        }
        #endregion

        #region Metodos CRUD
        public bool Create()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();

            BDServiexpress.IngresoTaller ingresoTaller = new BDServiexpress.IngresoTaller();
            try
            {
                CommonBC.Syncronize(this, ingresoTaller);//copia datos al objeto de la BD
                bd.IngresoTaller.Add(ingresoTaller);//agrega objeto a la BD 
                bd.SaveChanges();//guarda los cambios
                return true;
            }
            catch (Exception)
            {
                bd.IngresoTaller.Remove(ingresoTaller);
                return false;
            }
        }
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.IngresoTaller ingresoTaller = bd.IngresoTaller.First(c => c.num_ingreso.Equals(num_ingreso));
                CommonBC.Syncronize(ingresoTaller, this);
                //agrega lectura de propiedades customizadas
                LeerDescripcionServicio();
                LeerNombreCliente();
                LeerNombreFabricante();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.IngresoTaller ingresoTaller = bd.IngresoTaller.First(c => c.num_ingreso.Equals(num_ingreso));
                CommonBC.Syncronize(this, ingresoTaller);
                bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete()
        {
            ///Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.IngresoTaller ingresoTaller = bd.IngresoTaller.First(c => c.num_ingreso.Equals(num_ingreso));
                bd.IngresoTaller.Remove(ingresoTaller);
                bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion


        #region MetodosCustomer
        public void LeerDescripcionServicio()
        {
            Servicio servicio = new Servicio() { id_servicio = id_servicio };
            if (servicio.Read())
            {
                _descripcion = servicio.descripcion;
            }
            else
            {
                _descripcion = string.Empty;
            }
        }

        public void LeerNombreFabricante()
        {
            Fabricante fabricante = new Fabricante() { id_fabricante = id_fabricante };
            if (fabricante.Read())
            {
                _nombrefabricante = fabricante.nombrefabricante;
            }
            else
            {
                _nombrefabricante = string.Empty;
            }
        }
        public void LeerNombreCliente()
        {
            Cliente cliente = new Cliente() { rut_cliente = rut_cliente };
            if (cliente.Read())
            {
                _nombre = cliente.nombre;
            }
            else
            {
                _nombre = string.Empty;
            }
        }
        public List<IngresoTaller> ReadAll()
        {
            ///Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creo una lista de Datos
                List<BDServiexpress.IngresoTaller> listaDatos = bd.IngresoTaller.ToList<BDServiexpress.IngresoTaller>();
                //Creo una lista de Negocio
                List<IngresoTaller> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;

            }
            catch (Exception)
            {
                return new List<IngresoTaller>();
            }
        }

        private List<IngresoTaller> GenerarLista(List<BDServiexpress.IngresoTaller> listaDatos)
        {
            List<IngresoTaller> listaNegocio = new List<IngresoTaller>();
            foreach (BDServiexpress.IngresoTaller datos in listaDatos)
            {
                IngresoTaller negocio = new IngresoTaller();
                CommonBC.Syncronize(datos, negocio);
                negocio.LeerDescripcionServicio();
                negocio.LeerNombreCliente();
                negocio.LeerNombreFabricante();
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

        public List<IngresoTaller> ReadByFabricante(int idFabricante)
        {
            BDServiexpress.SERVIEXPRESSEntities bbdd = new BDServiexpress.SERVIEXPRESSEntities();

            try
            {
                List<BDServiexpress.IngresoTaller> listaDatos =
                    bbdd.IngresoTaller.Where(b => b.id_fabricante == idFabricante).ToList<BDServiexpress.IngresoTaller>();

                List<IngresoTaller> listaNegocio = GenerarLista(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<IngresoTaller>();
            }
        }

        public List<IngresoTaller> ReadByCliente(string rutCliente)
        {
            BDServiexpress.SERVIEXPRESSEntities bbdd = new BDServiexpress.SERVIEXPRESSEntities();

            try
            {
                List<BDServiexpress.IngresoTaller> listaDatos =
                    bbdd.IngresoTaller.Where(b => b.rut_cliente == rutCliente).ToList<BDServiexpress.IngresoTaller>();

                List<IngresoTaller> listaNegocio = GenerarLista(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<IngresoTaller>();
            }

        }

        public List<IngresoTaller> ReadByServicio(int idServicio)
        {
            BDServiexpress.SERVIEXPRESSEntities bbdd = new BDServiexpress.SERVIEXPRESSEntities();

            try
            {
                List<BDServiexpress.IngresoTaller> listaDatos =
                    bbdd.IngresoTaller.Where(b => b.id_servicio == idServicio).ToList<BDServiexpress.IngresoTaller>();

                List<IngresoTaller> listaNegocio = GenerarLista(listaDatos);

                return listaNegocio;

            }
            catch (Exception ex)
            {
                return new List<IngresoTaller>();
            }

        }


        #endregion


    } 

}
