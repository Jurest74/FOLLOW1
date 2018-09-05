

namespace follow.View_models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Propiedasdes(definiciones)

        public string Email
        {
            get;
            set;
        }

        public string Contraseña
        {
            get;
            set;
        }

        public  bool IsRunning {
            get;
            set;
        }

        public bool IsRemember {
            get;
            set;
        }

        #region Contructor
        public LoginViewModel()
        {
            this.IsRemember = true;
        }
        #endregion

        #endregion

        #region Region bottones (commands)

        public ICommand IsEntrar
        {
            get;
            set;
        }
        public ICommand IsRegistrar
        {
            get;
            set;
        }

        #endregion
    }
}
