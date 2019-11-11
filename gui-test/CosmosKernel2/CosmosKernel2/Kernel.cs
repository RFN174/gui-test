using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace CosmosKernel2
{
    public class Kernel : Sys.Kernel
    {
        Canvas canvas;
        protected override void BeforeRun()
        {
            
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(System.Drawing.Color.Aqua);
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
