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
                Pions p = new Pions("Pion","Blanc", position);
                piecesDuJeu[indPiecesDuJeu] = p;
                indPiecesDuJeu++;
            }
            for (int i = 0; i < 8; i++)
            {
                position.X = i;
                position.Y = 6;
                Pions p = new Pions("Pion", "Noir", position);
                piecesDuJeu[indPiecesDuJeu] = p;
                indPiecesDuJeu++;
            }
        }
        private static void repartirLesFous()
        {
            position.X = 2;
            position.Y = 0;
            Fous f1b = new Fous("Fous", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = f1b;
            indPiecesDuJeu++;

            position.X = 5;
            position.Y = 0;
            Fous f2b = new Fous("Fous", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = f2b;
            indPiecesDuJeu++;

            position.X = 2;
            position.Y = 7;
            Fous f1n = new Fous("Fous", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = f1n;
            indPiecesDuJeu++;

            position.X = 5;
            position.Y = 7;
            Fous f2n = new Fous("Fous", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = f2n;
            indPiecesDuJeu++;
        }
        private static void repartirLesTours()
        {
            position.X = 0;
            position.Y = 0;
            Tours t1b = new Tours("Tours", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = t1b;
            indPiecesDuJeu++;

            position.X = 7;
            position.Y = 0;
            Tours t2b = new Tours("Tours", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = t2b;
            indPiecesDuJeu++;

            position.X = 0;
            position.Y = 7;
            Tours t1n = new Tours("Tours", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = t1n;
            indPiecesDuJeu++;

            position.X = 7;
            position.Y = 7;
            Tours t2n = new Tours("Tours", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = t2n;
            indPiecesDuJeu++;
        }
        private static void repartirLesCavaliers()
        {
            position.X = 1;
            position.Y = 0;
            Cavaliers c1b = new Cavaliers("Cavaliers", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = c1b;
            indPiecesDuJeu++;

            position.X = 6;
            position.Y = 0;
            Cavaliers c2b = new Cavaliers("Cavaliers", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = c2b;
            indPiecesDuJeu++;

            position.X = 1;
            position.Y = 7;
            Cavaliers c1n = new Cavaliers("Cavaliers", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = c1n;
            indPiecesDuJeu++;

            position.X = 6;
            position.Y = 7;
            Cavaliers c2n = new Cavaliers("Cavaliers", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = c2n;
            indPiecesDuJeu++;
        }
        private static void repartirLesRois()
        {
            position.X = 4;
            position.Y = 0;
            Roi rb = new Roi("Roi", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = rb;
            indPiecesDuJeu++;

            position.X = 4;
            position.Y = 7;
            Roi rn = new Roi("Roi", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = rn;
            indPiecesDuJeu++;
        }
        private static void repartirLesReines()
        {
            position.X = 3;
            position.Y = 0;
            Reine rb = new Reine("Reine", "Blanc", position);
            piecesDuJeu[indPiecesDuJeu] = rb;
            indPiecesDuJeu++;

            position.X = 3;
            position.Y = 7;
            Reine rn = new Reine("Reine", "Noir", position);
            piecesDuJeu[indPiecesDuJeu] = rn;
            indPiecesDuJeu++;
        }
    }
}
