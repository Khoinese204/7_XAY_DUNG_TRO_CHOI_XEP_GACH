using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Entities.Enums;

namespace Tetris.Entities.Enums
{
    public class ElementColor
    {
        // Mảng chứa các màu sắc tương ứng với các giá trị trong enum ElementID
        public System.Drawing.Color[] SystemDrawingColor { private set; get; } = new System.Drawing.Color[11];

        // Constructor của lớp, khởi tạo các giá trị màu sắc
        public ElementColor()
        {
            SystemDrawingColor[(int)ElementID.JBlock] = System.Drawing.SystemColors.Highlight;
            SystemDrawingColor[(int)ElementID.TBlock] = System.Drawing.Color.DarkOrchid;
            SystemDrawingColor[(int)ElementID.LBlock] = System.Drawing.Color.DarkOrange;
            SystemDrawingColor[(int)ElementID.IBlock] = System.Drawing.Color.Aqua;
            SystemDrawingColor[(int)ElementID.OBlock] = System.Drawing.Color.Yellow;
            SystemDrawingColor[(int)ElementID.SBlock] = System.Drawing.Color.Lime;
            SystemDrawingColor[(int)ElementID.ZBlock] = System.Drawing.Color.Red;
            SystemDrawingColor[(int)ElementID.Wall] = System.Drawing.Color.CadetBlue;
            SystemDrawingColor[(int)ElementID.Free] = System.Drawing.Color.Transparent;
            SystemDrawingColor[(int)ElementID.OldPiece] = System.Drawing.Color.Gainsboro;
            SystemDrawingColor[(int)ElementID.NextPieceGrid] = System.Drawing.SystemColors.WindowFrame;
        }
    }
}
