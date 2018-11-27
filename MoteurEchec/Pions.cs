using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoteurEchec
{
    class Pions : Pieces
    {
        private bool premiereAction = true;

        public bool PremiereAction { get => premiereAction; private set => premiereAction = value; }

        public Pions (string nom, string couleur, strPosition position)
        {
            this.Nom = nom;
            this.Couleur = couleur;
            this.Position = position;
        }
        private bool deplacementPossible(strPosition positionSouhaitee)
        {
            if (positionSouhaitee.Y < 0 || positionSouhaitee.Y > 7 || positionSouhaitee.X < 0 || positionSouhaitee.Y > 7) { return false; }

            strPosition[] listeDeplacement = new strPosition[5];
            listeDeplacement = recupererListeDeplacement(positionSouhaitee);
            foreach (strPosition positionPossible in listeDeplacement)
            {
                if ((positionPossible.X == positionSouhaitee.X) && (positionPossible.Y == positionSouhaitee.Y))
                {
                    return true;
                }
            }
            return false;
        }
        public override bool seDeplacer(strPosition positionSouhaitee)
        {
            if (deplacementPossible(positionSouhaitee))
            {
                // On affecte la nouvelle position du pion
                this.Position = positionSouhaitee;
                return true;
            }
            return false;
        }
        private bool CaseEstLlibre(strPosition positionAVerifier)
        {
            // On parcours toutes les pièces du jeu
            foreach (Pieces pieces in Echiquier.PiecesDuJeu)
            {
                if ((pieces.Position.X == positionAVerifier.X) && pieces.EstVivant)
                {
                    return false;
                }
                if ((pieces.Position.Y == positionAVerifier.Y) && pieces.EstVivant)
                {
                    return false;
                }
            }
            return true;
        }
        public override strPosition [] recupererListeDeplacement(strPosition position)
        {
            // On simule le déplacement en Y, on va regarder si on peut avancer
            strPosition [] listeDeplacement = new strPosition[5];
            int indListeDeplacement = 0;
            strPosition positionAVerifier = position;
            if (this.Couleur == "Blanc")
            {
                positionAVerifier.Y = position.Y + 1;
            }
            else
            {
                positionAVerifier.Y = position.Y - 1;
            }
            
            
            if (CaseEstLlibre(positionAVerifier))
            {
                ajouterDeplacementPossible(ref listeDeplacement, ref indListeDeplacement, positionAVerifier);
            }

            positionAVerifier.X = position.X + 1;
            // Si on peut manger une piece en diagonale alors on ajoute le déplacement en diagonale
            if (peutMangerPiece(positionAVerifier))
            {
                ajouterDeplacementPossible(ref listeDeplacement, ref indListeDeplacement, positionAVerifier);
            }
                positionAVerifier.X = position.X - 1;
                
            if (peutMangerPiece(positionAVerifier))
            {
                ajouterDeplacementPossible(ref listeDeplacement, ref indListeDeplacement, positionAVerifier);
            }
            // Un pion peut avancer de deux case lors de son premier tour
            if (premiereAction)
            {
                if (this.Couleur == "Blanc")
                {
                    positionAVerifier.Y = positionAVerifier.Y + 2;
                }
                else
                {
                    positionAVerifier.Y = positionAVerifier.Y - 2;
                }
                
                if (CaseEstLlibre(positionAVerifier))
                {
                    ajouterDeplacementPossible(ref listeDeplacement,ref indListeDeplacement,positionAVerifier);
                }
            }

            return listeDeplacement;
        }
        private void ajouterDeplacementPossible(ref strPosition [] listeDeplacement,ref int indListeDeplacement, strPosition positionAAjouter)
        {
            listeDeplacement[indListeDeplacement].X = positionAAjouter.X;
            listeDeplacement[indListeDeplacement].Y = positionAAjouter.Y;
            indListeDeplacement++;
        }
        private bool peutMangerPiece(strPosition positionAVerifier)
        {
            if (!CaseEstLlibre(positionAVerifier)) { return true; }
            return false;
        }
    }
}
