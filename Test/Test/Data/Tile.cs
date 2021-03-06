﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Test
{
    public class Tile
    {
        public Point Location;
        public List<TileLayer> Layers = new List<TileLayer>();

        public bool IsBlocked;
        //public bool BlockMissile;
        public bool TouchTrigger;
        public bool StepTrigger;
        public string Script = "";    // Action1;Action2;Action3;...|(Value1,Value2),...;Values;...

        public Tile()
        {
            Layers.Add(new TileLayer("Tiny", 3, 1));
            Layers.Add(new TileLayer("Tiny", 0, 0));
            Layers.Add(new TileLayer("Tiny", 0, 0));
            Layers.Add(new TileLayer("Tiny", 0, 0));
        }

    }

    public class TileLayer
    {
        public string srcImg;
        public Point srcPos;

        public TileLayer(string source, int X, int Y)
        {
            srcImg = source;
            srcPos = new Point(X, Y);
        }
    }
}
