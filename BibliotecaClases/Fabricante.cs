using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Fabricante
    {
        #region Propiedades
        public int id_fabricante { get; set; }
        public string nombrefabricante { get; set; }
        #endregion

        #region Constructores
        public Fabricante()
        {
            this.Init();
        }

        private void Init()
        {
            id_fabricante = 0;
            nombrefabricante = string.Empty;
        }

        #endregion

        #region CRUD
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Fabricante fabricante =
                    bd.Fabricante.First(ae => ae.id_fabricante == id_fabricante);
                CommonBC.Syncronize(fabricante, this);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Fabricante> ReadAll()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                //Creacion de una lista de datos
                List<BDServiexpress.Fabricante> listaDatos = bd.Fabricante.ToList();
                //Creacion de una lista de negocio
                List<Fabricante> listaNegocio = GenerarLista(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {

                return new List<Fabricante>();
            }
        }

        private List<Fabricante> GenerarLista(List<BDServiexpress.Fabricante> listaDatos)
        {
            List<Fabricante> listaNegocio = new List<Fabricante>();
            foreach (BDServiexpress.Fabricante datos in listaDatos)
            {
                Fabricante negocio = new Fabricante();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        } 
        #endregion
    }
}
