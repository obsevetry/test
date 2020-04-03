using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightLibrary
{
    public delegate void PlayerStateHandler(object sender, PlayerEventArgs e);

    public class PlayerEventArgs : EventArgs
    {
        public PlayerEventArgs()
        {

        }
    }
}
