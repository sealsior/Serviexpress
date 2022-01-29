using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Convenio
    {
        #region Propiedades
        public int id_convenio { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> descuento { get; set; }
        #endregion

        #region Constructores
        public Convenio()
        {
            this.Init();
        }

        private void Init()
        {
            id_convenio = 0;
            descripcion = string.Empty;
            descuento = 0;
        }
        #endregion

        #region CRUD
        public bool Create()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();

            BDServiexpress.Convenio convenio = new BDServiexpress.Convenio();
            try
            {
                CommonBC.Syncronize(this, convenio);//copia datos al objeto de la BD
                bd.Convenio.Add(convenio);//agrega objeto a la BD 
                bd.SaveChanges();//guarda los cambios
                return true;
            }
            catch (Exception)
            {
                bd.Convenio.Remove(convenio);
                return false;
            }
        }
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Convenio convenio = bd.Convenio.First(c => c.id_convenio.Equals(id_convenio));
                CommonBC.Syncronize(convenio, this);

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
                BDServiexpress.Convenio convenio = bd.Convenio.First(c => c.id_convenio.Equals(id_convenio));
                CommonBC.Syncronize(this, convenio);
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
                BDServiexpress.Convenio convenio = bd.Convenio.First(c => c.id_convenio.Equals(id_convenio));
                bd.Convenio.Remove(convenio);
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
        public List<Convenio> ReadAll()
        {
            ///Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creo una lista de Datos
                List<BDServiexpress.Convenio> listaDatos = bd.Convenio.ToList<BDServiexpress.Convenio>();
                //Creo una lista de Negocio
                List<Convenio> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;

            }
            catch (Exception)
            {
                return new List<Convenio>();
            }
        }

        private List<Convenio> GenerarLista(List<BDServiexpress.Convenio> listaDatos)
        {
            List<Convenio> listaNegocio = new List<Convenio>();
            foreach (BDServiexpress.Convenio datos in listaDatos)
            {
                Convenio negocio = new Convenio();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        } 
        #endregion




    }
}
