using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using login_entre_telas.Model;
using login_entre_telas.View;
namespace login_entre_telas
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "professor@gtec",
                Nome = "professor",
                Senha = "321123"
            },
            new DadosUsuario()
            {
                Email = "ferdinando@gtec",
                Nome = "aluno",
                Senha = "123321"
            }
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

}
