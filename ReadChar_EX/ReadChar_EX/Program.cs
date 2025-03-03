using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics; // Vector2 사용

class Program
{
    public struct Vector2
    {
        public int X, Y;
        public Vector2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool ReadConsoleOutputCharacter(
        IntPtr hConsoleOutput,
        [Out] StringBuilder lpCharacter,
        uint length,
        COORD bufferCoord,
        out uint lpNumberOfCharsRead
    );

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);

    const int STD_OUTPUT_HANDLE = -11;

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short X;
        public short Y;
    }

    static public StringBuilder ReadChar(Vector2 v)
    {
        try
        {
            IntPtr h = GetStdHandle(STD_OUTPUT_HANDLE);
            if (h == IntPtr.Zero || h == new IntPtr(-1))
            {
                Console.WriteLine("Invalid console handle.");
                return null;
            }

            StringBuilder sb = new StringBuilder(1);
            uint _i = 0;
            COORD coord = new COORD { X = (short)v.X, Y = (short)v.Y };

            bool result = ReadConsoleOutputCharacter(h, sb, 1, coord, out _i);

            if (!result)
            {
                int errorCode = Marshal.GetLastWin32Error();
                Console.WriteLine($"ReadConsoleOutputCharacter failed with error code: {errorCode}");
                return null;
            }

            char readChar = sb.Length > 0 ? sb[0] : '\0';

            if (readChar == '\0' || readChar == ' ')
            {
                Console.WriteLine($"No character at ({coord.X}, {coord.Y}).");
                return null;
            }

            return sb;
        }
        catch (Exception e)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(e.ToString());
            return null;
        }
    }

    static void Main()
    {
        Console.Clear();
        Console.SetCursorPosition(5, 2);
        Console.Write("Hello");

        Vector2 position = new Vector2(11, 2); // 'l'이 있는 위치
        StringBuilder result = ReadChar(position);

        if (result != null)
        {
            Console.WriteLine($"\nCharacter at ({position.X}, {position.Y}): '{result}'");
        }
        else
        {
            Console.WriteLine($"\nNo character found at ({position.X}, {position.Y}).");
        }
    }
}
