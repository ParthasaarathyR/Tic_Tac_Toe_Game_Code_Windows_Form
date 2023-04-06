using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe__Windows_Forms_Application_
{
    public class Player
    {
        string _player01;

        public string Player01
        {
            get { return _player01; }
            set { _player01 = value; }
        }

        string _player02;

        public string Player02
        {
            get { return _player02; }
            set { _player02 = value; }
        }

        public Player(string P1, string P2)
        {
            this._player01 = P1;
            this._player02 = P2;
        }

        public Player()
        {
             
        }
    }
}
