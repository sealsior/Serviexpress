using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Servicio
    {
        #region Propiedades
        public int id_servicio { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> precio { get; set; }
        #endregion

        #region Constructores
        public Servicio()
        {
            this.Init();
        }

        private void Init()
        {
            id_servicio = 0;
            descripcion = string.Empty;
            precio = 0;
        }
        #endregion

        #region CRUD
        public bool Create()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();

            BDServiexpress.Servicio servicio = new BDServiexpress.Servicio();
            try
            {
                CommonBC.Syncronize(this, servicio);//copia datos al objeto de la BD
                bd.Servicio.Add(servicio);//agrega objeto a la BD 
                bd.SaveChanges();//guarda los cambios
                return true;
            }
            catch (Exception)
            {
                bd.Servicio.Remove(servicio);
                return false;
            }
        }
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Servicio servicio = bd.Servicio.First(c => c.id_servicio.Equals(id_servicio));
                CommonBC.Syncronize(servicio, this);

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
                BDServiexpress.Servicio servicio = bd.Servicio.First(c => c.id_servicio.Equals(id_servicio));
                CommonBC.Syncronize(this, servicio);
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
                BDServiexpress.Servicio servicio = bd.Servicio.First(c => c.id_servicio.Equals(id_servicio));
                bd.Servicio.Remove(servicio);
                bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Metodos Customer
        public List<Servicio> ReadAll()
        {
            ///Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creo una lista de Datos
                List<BDServiexpress.Servicio> listaDatos = bd.Servicio.ToList<BDServiexpress.Servicio>();
                //Creo una lista de Negocio
                List<Servicio> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;

            }
            catch (Exception)
            {
                return new List<Servicio>();
            }
        }

        private List<Servicio> GenerarLista(List<BDServiexpress.Servicio> listaDatos)
        {
            List<Servicio> listaNegocio = new List<Servicio>();
            foreach (BDServiexpress.Servicio datos in listaDatos)
            {
                Servicio negocio = new Servicio();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
        #endregion


    }
}
