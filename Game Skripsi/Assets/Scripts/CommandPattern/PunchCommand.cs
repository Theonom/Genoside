using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.CommandPattern
{
    class PunchCommand : Command
    {
        private Player player;

        public PunchCommand(Player player, KeyCode key) : base(key)
        {
            this.player = player;
        }

        public override void GetKeyDown()
        {
            player.Actions.Punch();
        }
    }
}
