using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoteurEchec
{
    public struct strPosition
    {
        private int x;
        private int y;

        public int X {  get => x; set => x = value; }
        public int Y {  get => y; set => y = value; }
    }
    public interface IDeplaceable
    {
        strPosition Position { get; }
        bool seDeplacer(strPosition position);
        strPosition[] recupererListeDeplacement(strPosition position);
    }
   
    abstract public class Pieces : IDeplaceable
    {
        private int nom;
        private int couleur;
        private strPosition position;
        private bool estVivant = true;

        public int Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        

        public int Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public strPosition Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool EstVivant
        {
            get { return estVivant; }
            set { estVivant = value; }
        }
        public abstract bool seDeplacer(strPosition position);

        public abstract strPosition[] recupererListeDeplacement(strPosition position);
  

    }
}
