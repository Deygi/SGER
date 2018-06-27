using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGER.Entidades;
using SGER.LogicaNegocio;

namespace SGER.Presentacion.Form_Login
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public void verifyUser()
        {
            Usuario loginUser = buildUser();
            Usuario user;

            if ((user = new business__Logic_User().query(loginUser.idUser)) != null)
            {
                if (user.password == loginUser.password)
                {
                    Form_Additionals.Form_Successfull view = new Form_Additionals.Form_Successfull();
                    view.ShowDialog();
                    Form_Additionals.Form_Index index = new Form_Additionals.Form_Index();
                    index.ShowDialog();
                    this.Close();
                }
                else
                {
                    Form_Additionals.Form_Alert view = new Form_Additionals.Form_Alert();
                    view.ShowDialog();
                }
            }
            else
            {
                Form_Additionals.Form_Alert view = new Form_Additionals.Form_Alert();
                view.ShowDialog();
            }

        }

        #region slaughter methodos
        public Usuario buildUser()
        {
            return new Usuario
            {
                idUser = int.Parse(txtUser.Text),
                password = txtPassword.Text

            };
        }
        #endregion

        private void BtonCancelar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void BtonAcept_Click(object sender, EventArgs e)
        {
            //verifyUser();
        }

        private void BtonAcept_Click_1(object sender, EventArgs e)
        {
            verifyUser();
        }

        private void BtonCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
