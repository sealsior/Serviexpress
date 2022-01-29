using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Usuario
    {
        #region Propiedades
        public string email { get; set; }
        public string nombreusuario { get; set; }
        public string password { get; set; }
        #endregion

        #region Constructores
        public Usuario()
        {
            this.Init();
        }

        private void Init()
        {
            email = string.Empty;
            nombreusuario = string.Empty;
            password = string.Empty;
        }
        #endregion

        #region CRUD
        public bool Create()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();

            BDServiexpress.Usuario usuario = new BDServiexpress.Usuario();
            try
            {
                CommonBC.Syncronize(this, usuario);//copia datos al objeto de la BD
                bd.Usuario.Add(usuario);//agrega objeto a la BD 
                bd.SaveChanges();//guarda los cambios
                return true;
            }
            catch (Exception)
            {
                bd.Usuario.Remove(usuario);
                return false;
            }
        }
        public bool Read()
        {
            //Generacion de conexion a EDM
            BDServiexpress.SERVIEXPRESSEntities bd = new BDServiexpress.SERVIEXPRESSEntities();
            try
            {
                BDServiexpress.Usuario usuario = bd.Usuario.First(c => c.email.Equals(email));
                CommonBC.Syncronize(usuario, this);

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
                BDServiexpress.Usuario usuario = bd.Usuario.First(c => c.email.Equals(email));
                CommonBC.Syncronize(this, usuario);
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
                BDServiexpress.Usuario usuario = bd.Usuario.First(c => c.email.Equals(email));
                bd.Usuario.Remove(usuario);
                bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
        #endregion
    }

   
}
