using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorridaDeCaes.WinApp
{
    public class Greyhound
    {
        public int StartPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public Greyhound(PictureBox picBDog, int lenghtRaceTrack)
        {
            this.StartPosition = picBDog.Location.X;
            this.Location = this.StartPosition;
            this.RacetrackLenght = lenghtRaceTrack;
            //Aqui a corrida acaba mais ou menos na linha de chegada
            //this.RacetrackLenght = lenghtRaceTrack - 137;
            this.MyPictureBox = picBDog;
            MyRandom = new Random();


        }

        public bool Run()
        {
            this.Location += MyRandom.Next(1, 4);
            System.Drawing.Point pos = this.MyPictureBox.Location;
            pos.X += this.Location;
            this.MyPictureBox.Location = pos;

            if (this.MyPictureBox.Location.X >= this.RacetrackLenght)
                return true;

            return false;
        }
        public void TakeStartPosition()
        {
            System.Drawing.Point pos = this.MyPictureBox.Location;
            pos.X = this.StartPosition;            
            this.MyPictureBox.Location = pos;
            this.Location = this.StartPosition;
        }

    }
}
