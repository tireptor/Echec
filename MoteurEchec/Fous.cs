using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoteurEchec
{
    class Fous : Pieces
    {
        public Fous(int nom, int couleur, strPosition position)
        {
            this.Nom = nom;
            this.Couleur = couleur;
            this.Position = position;
        }
        public override bool seDeplacer(strPosition position)
        {
            return false;
        }
        public override strPosition[] recupererListeDeplacement(strPosition position)
        {

            strPosition[] listeDeplacement = new strPosition[5];
            return listeDeplacement;
        }
    }
}
