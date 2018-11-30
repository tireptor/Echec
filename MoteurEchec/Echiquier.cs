using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoteurEchec
{
    public abstract class Echiquier
    {
        private static Pieces[] piecesDuJeu = new Pieces [32];
        private static int indPiecesDuJeu;
        private static strPosition position;
        // Enumération pour mieux gérer les noms des pièces 
        private  enum EnumPieces { Pion, Tours, Fous, Cavaliers, Roi, Reine };
        public  enum EnumCouleurs { Blanc, Noir };
        public static Pieces[] PiecesDuJeu { get => piecesDuJeu; private set => piecesDuJeu = value; }
        public static strPosition Position { get => position; set => position = value; }
        public static int IndPiecesDuJeu { get => indPiecesDuJeu; private set => indPiecesDuJeu = value; }

        public static void repartirLesPieces ()
        {
            indPiecesDuJeu = 0;
            repartirLesPions();
            repartirLesFous();
            repartirLesTours();
            repartirLesCavaliers();
            repartirLesRois();
            repartirLesReines();
        }

        private static void repartirLesPions()
        {
            for (int i = 0; i <8;i++)
            {
                position.X = i;
                position.Y = 1;
                piecesDuJeu[indPiecesDuJeu] = ajouterPion((int)EnumCouleurs.Blanc);
                indPiecesDuJeu++;
            }
            for (int i = 0; i < 8; i++)
            {
                position.X = i;
                position.Y = 6;
                piecesDuJeu[indPiecesDuJeu] = ajouterPion((int)EnumCouleurs.Noir);
                indPiecesDuJeu++;
            }
        }
        private static Pions ajouterPion(int couleur)
        {
            Pions p = new Pions((int)EnumPieces.Pion, couleur, position);
            return p;
        }
        private static void repartirLesFous()
        {
            position.X = 2;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterFous((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 5;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterFous((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 2;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterFous((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;

            position.X = 5;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterFous((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;
        }
        private static Fous ajouterFous(int couleur)
        {
            Fous f = new Fous((int)EnumPieces.Pion, couleur, position);
            return f;
        }
        private static void repartirLesTours()
        {
            position.X = 0;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterTours((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 7;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterTours((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 0;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterTours((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;

            position.X = 7;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterTours((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;
        }
        private static Tours ajouterTours(int couleur)
        {
            Tours t = new Tours((int)EnumPieces.Tours, couleur, position);
            return t;
        }
        private static void repartirLesCavaliers()
        {
            position.X = 1;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterCavaliers((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 6;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterCavaliers((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 1;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterCavaliers((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;

            position.X = 6;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterCavaliers((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;
        }
        private static Cavaliers ajouterCavaliers(int couleur)
        {
            Cavaliers c = new Cavaliers((int)EnumPieces.Tours, couleur, position);
            return c;
        }
        private static void repartirLesRois()
        {
            position.X = 4;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterRoi((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 4;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterRoi((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;
        }
        private static Roi ajouterRoi(int couleur)
        {
            Roi r = new Roi ((int)EnumPieces.Tours, couleur, position);
            return r;
        }
        private static void repartirLesReines()
        {
            position.X = 3;
            position.Y = 0;
            piecesDuJeu[indPiecesDuJeu] = ajouterReine((int)EnumCouleurs.Blanc);
            indPiecesDuJeu++;

            position.X = 3;
            position.Y = 7;
            piecesDuJeu[indPiecesDuJeu] = ajouterReine((int)EnumCouleurs.Noir);
            indPiecesDuJeu++;
        }
        private static Reine ajouterReine(int couleur)
        {
            Reine r = new Reine((int)EnumPieces.Tours, couleur, position);
            return r;
        }
    }
}
