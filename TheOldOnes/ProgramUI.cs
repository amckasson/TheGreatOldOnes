using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOldOnes.GameLibrary;

namespace TheOldOnes
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            GameOpening opening = new GameOpening();
            opening.GameTitle();

        }
    }
}
