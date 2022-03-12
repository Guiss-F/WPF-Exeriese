using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Gs.Common;

namespace GS.Music
{
    public class MusicViewModel
    {
        #region Account
        private string _account;

        public string Account
        {
            get { return _account; }
            set
            {
                _account = value;
            }
        }

        #endregion

        #region PassWard
        private string _passWard;

        public string PassWard
        {
            get { return _passWard; }
            set { _passWard = value; }
        }

        #endregion

        #region LoginTypes
        private List<string> _loginTypes;
        
        public List<string> LoginTypes
        {
            get { return _loginTypes; }
            set { _loginTypes = value; }
        }
        #endregion

        public ICommand LoginCommand
        {
            get;
            set;
        }

        private ICommand _cancelRemberCommand;

        public ICommand CancelRemberCommand
        {
            get
            {
                return null == _cancelRemberCommand ?
                    new RelayCommand<bool>(CancelAction) : _cancelRemberCommand; 
            }
        }

        public MusicViewModel()
        {
            LoginCommand = new RelayCommand(LoginAction);
            Account = "Admin";
            LoginTypes = new List<string>();
            LoginTypes.Add("手机号登录");
            LoginTypes.Add("密码登录");
            LoginTypes.Add("二维码登录");
        }

        private void LoginAction()
        {
            if (Account == "Admin" && PassWard == "123456")
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void CancelAction(bool obj)
        {
            MessageBox.Show($"check status {obj}");
        }
    }

}
