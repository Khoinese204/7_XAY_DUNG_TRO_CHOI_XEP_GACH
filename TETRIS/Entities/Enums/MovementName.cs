using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities.Enums
{
    // Các giá trị đại diện cho các hành động di chuyển trong trò chơi
    public enum MovementName : int
    {
        Down = 0,
        Left = 1,
        Right = 2,
        Rotate = 3,
    }
}
