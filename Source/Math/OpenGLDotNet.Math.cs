using System;
using Common;

namespace OpenGLDotNet.Math
{
    ///////////////////////////////////////////////////////////////////////////
    // POINT DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Point with "int/Int32" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT2I...
    public class Point2i
    {
        public int X = 0;
        public int Y = 0;

        public Point2i()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point2i(int prmX, int prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public Point2i(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public double Distance()
        {
            return this.Distance(0, 0);
        }

        public double Distance(int prmX, int prmY)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY));
        }

        public double Distance(Point2i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public void MoveTo(int prmX, int prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public void MoveTo(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveRelative(int prmX, int prmY)
        {
            this.X += prmX;
            this.Y += prmY;
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public static bool operator ==(Point2i lhs, Point2i rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point2i lhs, Point2i rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point2i && obj is Point2i)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Point2i Point = (Point2i)obj;

                    if (this.X == Point.X && this.Y == Point.Y)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            return this.X ^ this.Y;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Point with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT2F...
    public class Point2f
    {
        public float X = 0;
        public float Y = 0;

        public Point2f()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point2f(float prmX, float prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public Point2f(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public Point2f(Point2f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public double Distance()
        {
            return this.Distance(0, 0);
        }

        public double Distance(float prmX, float prmY)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY));
        }

        public double Distance(Point2i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public double Distance(Point2f prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public void MoveTo(float prmX, float prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public void MoveTo(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveTo(Point2f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveRelative(float prmX, float prmY)
        {
            this.X += prmX;
            this.Y += prmY;
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public static bool operator ==(Point2f lhs, Point2f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point2f lhs, Point2f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point2f && obj is Point2f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                Point2f Point = (Point2f)obj;

                if (this.X == Point.X && this.Y == Point.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);

            return PartX ^ PartY;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Point with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT2D...
    public class Point2d
    {
        public double X = 0;
        public double Y = 0;

        public Point2d()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point2d(double prmX, double prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public Point2d(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public Point2d(Point2f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public Point2d(Point2d prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public double Distance()
        {
            return this.Distance(0, 0);
        }

        public double Distance(double prmX, double prmY)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY));
        }

        public double Distance(Point2i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public double Distance(Point2f prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public double Distance(Point2d prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y);
        }

        public void MoveTo(double prmX, double prmY)
        {
            this.X = prmX;
            this.Y = prmY;
        }

        public void MoveTo(Point2i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveTo(Point2f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveTo(Point2d prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
        }

        public void MoveRelative(double prmX, double prmY)
        {
            this.X += prmX;
            this.Y += prmY;
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public void MoveRelative(Point2d prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
        }

        public static bool operator ==(Point2d lhs, Point2d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point2d lhs, Point2d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point2d && obj is Point2d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Point2d Point = (Point2d)obj;

                    if (this.X == Point.X && this.Y == Point.Y)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF);
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Point with "int/Int32" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT3I...
    public class Point3i
    {
        public int X = 0;
        public int Y = 0;
        public int Z = 0;

        public Point3i()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Point3i(int prmX, int prmY, int prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public Point3i(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public double Distance()
        {
            return this.Distance(0, 0, 0);
        }

        public double Distance(int prmX, int prmY, int prmZ)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY) + (this.Z - prmZ) * (this.Z - prmZ));
        }

        public double Distance(Point3i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public void MoveTo(int prmX, int prmY, int prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public void MoveTo(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveRelative(int prmX, int prmY, int prmZ)
        {
            this.X += prmX;
            this.Y += prmY;
            this.Z += prmZ;
        }

        public void MoveRelative(Point3i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public static bool operator ==(Point3i lhs, Point3i rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point3i lhs, Point3i rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point3i && obj is Point3i)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Point3i Point = (Point3i)obj;

                    if (this.X == Point.X && this.Y == Point.Y && this.Z == Point.Z)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            return this.X ^ this.Y ^ this.Z;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Point with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT3F...
    public class Point3f
    {
        public float X = 0;
        public float Y = 0;
        public float Z = 0;

        public Point3f()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Point3f(float prmX, float prmY, float prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public Point3f(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public Point3f(Point3f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public double Distance()
        {
            return this.Distance(0, 0, 0);
        }

        public double Distance(float prmX, float prmY, float prmZ)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY) + (this.Z - prmZ) * (this.Z - prmZ));
        }

        public double Distance(Point3i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public double Distance(Point3f prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public void MoveTo(float prmX, float prmY, float prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public void MoveTo(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveTo(Point3f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveRelative(float prmX, float prmY, float prmZ)
        {
            this.X += prmX;
            this.Y += prmY;
            this.Z += prmZ;
        }

        public void MoveRelative(Point3i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public void MoveRelative(Point3f prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public static bool operator ==(Point3f lhs, Point3f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point3f lhs, Point3f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point3f && obj is Point3f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Point3f Point = (Point3f)obj;

                    if (this.X == Point.X && this.Y == Point.Y && this.Z == Point.Z)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            int PartZ = BitConverter.ToInt32(BitConverter.GetBytes(this.Z), 0);
            
            return PartX ^ PartY ^ PartZ;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Point with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region POINT3D...
    public class Point3d
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public Point3d()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Point3d(double prmX, double prmY, double prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public Point3d(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public Point3d(Point3f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public Point3d(Point3d prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public double Distance()
        {
            return this.Distance(0, 0, 0);
        }

        public double Distance(double prmX, double prmY, double prmZ)
        {
            return System.Math.Sqrt((this.X - prmX) * (this.X - prmX) + (this.Y - prmY) * (this.Y - prmY) + (this.Z - prmZ) * (this.Z - prmZ));
        }

        public double Distance(Point3i prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public double Distance(Point3f prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public double Distance(Point3d prmPoint)
        {
            return this.Distance(prmPoint.X, prmPoint.Y, prmPoint.Z);
        }

        public void MoveTo(double prmX, double prmY, double prmZ)
        {
            this.X = prmX;
            this.Y = prmY;
            this.Z = prmZ;
        }

        public void MoveTo(Point3i prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveTo(Point3f prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveTo(Point3d prmPoint)
        {
            this.X = prmPoint.X;
            this.Y = prmPoint.Y;
            this.Z = prmPoint.Z;
        }

        public void MoveRelative(double prmX, double prmY, double prmZ)
        {
            this.X += prmX;
            this.Y += prmY;
            this.Z += prmZ;
        }

        public void MoveRelative(Point3i prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public void MoveRelative(Point3f prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public void MoveRelative(Point3d prmPoint)
        {
            this.X += prmPoint.X;
            this.Y += prmPoint.Y;
            this.Z += prmPoint.Z;
        }

        public static bool operator ==(Point3d lhs, Point3d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Point3d lhs, Point3d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Point3d && obj is Point3d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Point3d Point = (Point3d)obj;

                    if (this.X == Point.X && this.Y == Point.Y && this.Z == Point.Z)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);
            long PartZ = BitConverter.DoubleToInt64Bits(this.Z);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF) ^ (int)(PartZ >> 32) ^ (int)(PartZ & 0xFFFFFFFF);
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // VECTOR DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Vector with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR2F...
    public class Vector2f
    {
        public float X = 0;
        public float Y = 0;

        public Vector2f()
        {
            X = 0;
            Y = 0;
        }

        public Vector2f(float iniX, float iniY)
        {
            X = iniX;
            Y = iniY;
        }

        public Vector2f(Vector2f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
        }

        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                float _vector_length = Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
            }
        }

        public static Vector2f operator +(Vector2f lhs, Vector2f rhs)
        {
            return new Vector2f(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        public static Vector2f operator -(Vector2f lhs, Vector2f rhs)
        {
            return new Vector2f(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        public static Vector2f operator *(float lhs, Vector2f rhs)
        {
            return new Vector2f(lhs * rhs.X, lhs * rhs.Y);
        }

        public static Vector2f operator *(Vector2f lhs, float rhs)
        {
            return new Vector2f(lhs.X * rhs, lhs.Y * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static float operator *(Vector2f lhs, Vector2f rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y;
        }

        public static bool operator ==(Vector2f lhs, Vector2f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector2f _lhs = new Vector2f(lhs);
                Vector2f _rhs = new Vector2f(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector2f lhs, Vector2f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector2f && obj is Vector2f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector2f Vector = (Vector2f)obj;

                    Vector2f _lhs = new Vector2f(this);
                    Vector2f _rhs = new Vector2f(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);

            return PartX ^ PartY;
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Vector with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR2D...
    public class Vector2d
    {
        public double X = 0;
        public double Y = 0;

        public Vector2d()
        {
            X = 0;
            Y = 0;
        }

        public Vector2d(double iniX, double iniY)
        {
            X = iniX;
            Y = iniY;
        }

        public Vector2d(Vector2f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
        }

        public Vector2d(Vector2d iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
        }

        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                double _vector_length = Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
            }
        }

        public static Vector2d operator +(Vector2d lhs, Vector2d rhs)
        {
            return new Vector2d(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        public static Vector2d operator -(Vector2d lhs, Vector2d rhs)
        {
            return new Vector2d(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        public static Vector2d operator *(double lhs, Vector2d rhs)
        {
            return new Vector2d(lhs * rhs.X, lhs * rhs.Y);
        }

        public static Vector2d operator *(Vector2d lhs, double rhs)
        {
            return new Vector2d(lhs.X * rhs, lhs.Y * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static double operator *(Vector2d lhs, Vector2d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y;
        }

        public static bool operator ==(Vector2d lhs, Vector2d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true; 
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector2d _lhs = new Vector2d(lhs);
                Vector2d _rhs = new Vector2d(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector2d lhs, Vector2d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector2d && obj is Vector2d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector2d Vector = (Vector2d)obj;

                    Vector2d _lhs = new Vector2d(this);
                    Vector2d _rhs = new Vector2d(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF);
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Vector with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR3F...
    public class Vector3f
    {
        public float X = 0;
        public float Y = 0;
        public float Z = 0;

        public Vector3f()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3f(float iniX, float iniY, float iniZ)
        {
            X = iniX;
            Y = iniY;
            Z = iniZ;
        }

        public Vector3f(Vector3f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
        }

        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z);
            }
            set
            {
                float _vector_length = this.Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
                Z = (Z / _vector_length) * value;
            }
        }

        public static Vector3f operator +(Vector3f lhs, Vector3f rhs)
        {
            return new Vector3f(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static Vector3f operator -(Vector3f lhs, Vector3f rhs)
        {
            return new Vector3f(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static Vector3f operator *(float lhs, Vector3f rhs)
        {
            return new Vector3f(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static Vector3f operator *(Vector3f lhs, float rhs)
        {
            return new Vector3f(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static float Dot(Vector3f lhs, Vector3f rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;
        }

        // This is "Cross Product" of two vectors
        public static Vector3f Cross(Vector3f lhs, Vector3f rhs)
        {
            Vector3f Result = new Vector3f();

            Result.X = +(lhs.Y * rhs.Z - lhs.Z * rhs.Y);
            Result.Y = -(lhs.X * rhs.Z - lhs.Z * rhs.X);
            Result.Z = +(lhs.X * rhs.Y - lhs.Y * rhs.X);

            return Result;
        }

        public static bool operator ==(Vector3f lhs, Vector3f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector3f _lhs = new Vector3f(lhs);
                Vector3f _rhs = new Vector3f(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector3f lhs, Vector3f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector3f && obj is Vector3f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector3f Vector = (Vector3f)obj;

                    Vector3f _lhs = new Vector3f(this);
                    Vector3f _rhs = new Vector3f(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            int PartZ = BitConverter.ToInt32(BitConverter.GetBytes(this.Z), 0);

            return PartX ^ PartY ^ PartZ;
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "," + Z + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Vector with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR3D...
    public class Vector3d
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public Vector3d()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3d(double iniX, double iniY, double iniZ)
        {
            X = iniX;
            Y = iniY;
            Z = iniZ;
        }

        public Vector3d(Vector3f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
        }

        public Vector3d(Vector3d iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
        }

        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y + Z * Z);
            }
            set
            {
                double _vector_length = this.Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
                Z = (Z / _vector_length) * value;
            }
        }

        public static Vector3d operator +(Vector3d lhs, Vector3d rhs)
        {
            return new Vector3d(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static Vector3d operator -(Vector3d lhs, Vector3d rhs)
        {
            return new Vector3d(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static Vector3d operator *(double lhs, Vector3d rhs)
        {
            return new Vector3d(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static Vector3d operator *(Vector3d lhs, double rhs)
        {
            return new Vector3d(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static double Dot(Vector3d lhs, Vector3d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;
        }

        // This is "Cross Product" of two vectors
        public static Vector3d Cross(Vector3d lhs, Vector3d rhs)
        {
            Vector3d Result = new Vector3d();

            Result.X = +(lhs.Y * rhs.Z - lhs.Z * rhs.Y);
            Result.Y = -(lhs.X * rhs.Z - lhs.Z * rhs.X);
            Result.Z = +(lhs.X * rhs.Y - lhs.Y * rhs.X);

            return Result;
        }

        public static bool operator ==(Vector3d lhs, Vector3d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector3d _lhs = new Vector3d(lhs);
                Vector3d _rhs = new Vector3d(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector3d lhs, Vector3d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector3d && obj is Vector3d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector3d Vector = (Vector3d)obj;

                    Vector3d _lhs = new Vector3d(this);
                    Vector3d _rhs = new Vector3d(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);
            long PartZ = BitConverter.DoubleToInt64Bits(this.Z);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF) ^ (int)(PartZ >> 32) ^ (int)(PartZ & 0xFFFFFFFF);
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "," + Z + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 4 Dimensional Vector with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR4F...
    public class Vector4f
    {
        public float X = 0;
        public float Y = 0;
        public float Z = 0;
        public float W = 0;

        public Vector4f()
        {
            X = 0;
            Y = 0;
            Z = 0;
            W = 0;
        }

        public Vector4f(float iniX, float iniY, float iniZ, float iniW)
        {
            X = iniX;
            Y = iniY;
            Z = iniZ;
            W = iniW;
        }

        public Vector4f(Vector4f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
            W = iniVector.W;
        }

        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
            }
            set
            {
                float _vector_length = this.Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
                Z = (Z / _vector_length) * value;
                W = (W / _vector_length) * value;
            }
        }

        public static Vector4f operator +(Vector4f lhs, Vector4f rhs)
        {
            return new Vector4f(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        public static Vector4f operator -(Vector4f lhs, Vector4f rhs)
        {
            return new Vector4f(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        public static Vector4f operator *(float lhs, Vector4f rhs)
        {
            return new Vector4f(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z, lhs * rhs.W);
        }

        public static Vector4f operator *(Vector4f lhs, float rhs)
        {
            return new Vector4f(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static float Dot(Vector4f lhs, Vector4f rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z + lhs.W * rhs.W;
        }

        public static bool operator ==(Vector4f lhs, Vector4f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector4f _lhs = new Vector4f(lhs);
                Vector4f _rhs = new Vector4f(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z && _lhs.W == _rhs.W)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector4f lhs, Vector4f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector4f && obj is Vector4f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector4f Vector = (Vector4f)obj;

                    Vector4f _lhs = new Vector4f(this);
                    Vector4f _rhs = new Vector4f(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z && _lhs.W == _rhs.W)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            int PartZ = BitConverter.ToInt32(BitConverter.GetBytes(this.Z), 0);
            int PartW = BitConverter.ToInt32(BitConverter.GetBytes(this.W), 0);

            return PartX ^ PartY ^ PartZ ^ PartW;
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "," + Z + "," + W + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 4 Dimensional Vector with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region VECTOR4D...
    public class Vector4d
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;
        public double W = 0;

        public Vector4d()
        {
            X = 0;
            Y = 0;
            Z = 0;
            W = 0;
        }

        public Vector4d(double iniX, double iniY, double iniZ, double iniW)
        {
            X = iniX;
            Y = iniY;
            Z = iniZ;
            W = iniW;
        }

        public Vector4d(Vector4f iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
            W = iniVector.W;
        }

        public Vector4d(Vector4d iniVector)
        {
            X = iniVector.X;
            Y = iniVector.Y;
            Z = iniVector.Z;
            W = iniVector.W;
        }

        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
            }
            set
            {
                double _vector_length = this.Length;

                X = (X / _vector_length) * value;
                Y = (Y / _vector_length) * value;
                Z = (Z / _vector_length) * value;
                W = (W / _vector_length) * value;
            }
        }

        public static Vector4d operator +(Vector4d lhs, Vector4d rhs)
        {
            return new Vector4d(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        public static Vector4d operator -(Vector4d lhs, Vector4d rhs)
        {
            return new Vector4d(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        public static Vector4d operator *(double lhs, Vector4d rhs)
        {
            return new Vector4d(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z, lhs * rhs.W);
        }

        public static Vector4d operator *(Vector4d lhs, double rhs)
        {
            return new Vector4d(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
        }

        // This is "Dot/Scalar Product" of two vectors
        public static double Dot(Vector4d lhs, Vector4d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z + lhs.W * rhs.W;
        }

        public static bool operator ==(Vector4d lhs, Vector4d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                Vector4d _lhs = new Vector4d(lhs);
                Vector4d _rhs = new Vector4d(rhs);

                _lhs.Length = 1;        // normalize
                _rhs.Length = 1;        // normalize

                if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z && _lhs.W == _rhs.W)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Vector4d lhs, Vector4d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Vector4d && obj is Vector4d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Vector4d Vector = (Vector4d)obj;

                    Vector4d _lhs = new Vector4d(this);
                    Vector4d _rhs = new Vector4d(Vector);

                    _lhs.Length = 1;        // normalize
                    _rhs.Length = 1;        // normalize

                    if (_lhs.X == _rhs.X && _lhs.Y == _rhs.Y && _lhs.Z == _rhs.Z && _lhs.W == _rhs.W)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);
            long PartZ = BitConverter.DoubleToInt64Bits(this.Z);
            long PartW = BitConverter.DoubleToInt64Bits(this.W);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF) ^ (int)(PartZ >> 32) ^ (int)(PartZ & 0xFFFFFFFF) ^ (int)(PartW >> 32) ^ (int)(PartW & 0xFFFFFFFF);
        }

        public override string ToString()
        {
            return "|" + X + "," + Y + "," + Z + "," + W + "|";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // RECTANGLE DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Rectangle with "int/Int32" precision
    ///////////////////////////////////////////////////////////////////////////
    #region RECTANGLE2I...
    public class Rectangle2i
    {
        private int _x1 = 0;
        private int _y1 = 0;
        private int _x2 = 0;
        private int _y2 = 0;

        public Rectangle2i()
        {
            this._x1 = 0;
            this._y1 = 0;
            this._x2 = 0;
            this._y2 = 0;
        }

        public Rectangle2i(int prmX1, int prmY1, int prmX2, int prmY2)
        {
            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = prmX2;
            this._y2 = prmY2;

            this.ReorderPoints();
        }

        public Rectangle2i(Point2i prmLeftTop, Point2i prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2i(Rectangle2i prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        private void ReorderPoints()
        {
            if (this._x1 > this._x2)
            {
                ToolsX.Swap(ref this._x1, ref this._x2);
            }

            if (this._y1 > this._y2)
            {
                ToolsX.Swap(ref this._y1, ref this._y2);
            }
        }

        public int X1
        {
            get
            {
                return this._x1;
            }

            set
            {
                this._x1 = value;

                this.ReorderPoints();
            }
        }

        public int Y1
        {
            get
            {
                return this._y1;
            }

            set
            {
                this._y1 = value;

                this.ReorderPoints();
            }
        }

        public int X2
        {
            get
            {
                return this._x2;
            }

            set
            {
                this._x2 = value;

                this.ReorderPoints();
            }
        }

        public int Y2
        {
            get
            {
                return this._y2;
            }

            set
            {
                this._y2 = value;

                this.ReorderPoints();
            }
        }

        public int Width
        {
            get
            {
                return (this._x2 - this._x1);
            }

            set
            {
                this._x2 = this._x1 + value;

                this.ReorderPoints();
            }
        }

        public int Height
        {
            get
            {
                return (this._y2 - this._y1);
            }

            set
            {
                this._y2 = this._y1 + value;

                this.ReorderPoints();
            }
        }

        public Point2i Size
        {
            get
            {
                return new Point2i(this._x2 - this._x1, this._y2 - this._y1);
            }

            set
            {
                this.GrowTo(value);
            }
        }

        public int Area
        {
            get
            {
                return (this._x2 - this._x1) * (this._y2 - this._y1);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this.Area == 0);
            }
        }


        public void MoveTo(int prmX1, int prmY1)
        {
            int _width = this.Width;
            int _height = this.Height;

            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2i prmPoint)
        {
            int _width = this.Width;
            int _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveRelative(int prmX1, int prmY1)
        {
            this._x1 += prmX1;
            this._y1 += prmY1;
            this._x2 += prmX1;
            this._y2 += prmY1;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void GrowTo(int prmX, int prmY)
        {
            this._x2 = this._x1 + prmX;
            this._y2 = this._y1 + prmY;

            this.ReorderPoints();
        }

        public void GrowTo(Point2i prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(int prmX, int prmY)
        {
            this._x2 += prmX;
            this._y2 += prmY;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2i prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public bool IsInside(Point2i prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool IsInside(int prmX, int prmY)
        {
            return (this.X1 <= prmX && this.X2 >= prmX && this.Y1 <= prmY && this.Y2 >= prmY);
        }

        public bool HasIntersection(Rectangle2i prmRectangle)
        {
            Point2i TopLeft = new Point2i(prmRectangle.X1, prmRectangle.Y1);
            Point2i TopRight = new Point2i(prmRectangle.X2, prmRectangle.Y1);
            Point2i BottomLeft = new Point2i(prmRectangle.X1, prmRectangle.Y2);
            Point2i BottomRight = new Point2i(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public Rectangle2i Intersect(Rectangle2i prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                int IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                int IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                int IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                int IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return new Rectangle2i(IntersectX1, IntersectY1, IntersectX2, IntersectY2);
            }
            else
            {
                return null;
            }
        }

        public Rectangle2i Union(Rectangle2i prmRectangle)
        {
            int UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            int UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            int UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            int UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2i(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public static bool operator ==(Rectangle2i lhs, Rectangle2i rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X1 == rhs.X1 && lhs.Y1 == rhs.Y1 && lhs.X2 == rhs.X2 && lhs.Y2 == rhs.Y2)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Rectangle2i lhs, Rectangle2i rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Rectangle2i && obj is Rectangle2i)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Rectangle2i Rectangle = (Rectangle2i)obj;

                    if (this.X1 == Rectangle.X1 && this.Y1 == Rectangle.Y1 && this.X2 == Rectangle.X2 && this.Y2 == Rectangle.Y2)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            return this.X1 ^ this.Y1 ^ this.X2 ^ this.Y2;
        }

        public override string ToString()
        {
            return "[" + this.X1 + "," + this.Y1 + " - " + this.X2 + "," + this.Y2 + "]";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Rectangle with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region RECTANGLE2F...
    public class Rectangle2f
    {
        private float _x1 = 0;
        private float _y1 = 0;
        private float _x2 = 0;
        private float _y2 = 0;

        public Rectangle2f()
        {
            this._x1 = 0;
            this._y1 = 0;
            this._x2 = 0;
            this._y2 = 0;
        }

        public Rectangle2f(float prmX1, float prmY1, float prmX2, float prmY2)
        {
            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = prmX2;
            this._y2 = prmY2;

            this.ReorderPoints();
        }

        public Rectangle2f(Point2i prmLeftTop, Point2i prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2f(Point2f prmLeftTop, Point2f prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2f(Rectangle2i prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        public Rectangle2f(Rectangle2f prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        private void ReorderPoints()
        {
            if (this._x1 > this._x2)
            {
                ToolsX.Swap(ref this._x1, ref this._x2);
            }

            if (this._y1 > this._y2)
            {
                ToolsX.Swap(ref this._y1, ref this._y2);
            }
        }

        public float X1
        {
            get
            {
                return this._x1;
            }

            set
            {
                this._x1 = value;

                this.ReorderPoints();
            }
        }

        public float Y1
        {
            get
            {
                return this._y1;
            }

            set
            {
                this._y1 = value;

                this.ReorderPoints();
            }
        }

        public float X2
        {
            get
            {
                return this._x2;
            }

            set
            {
                this._x2 = value;

                this.ReorderPoints();
            }
        }

        public float Y2
        {
            get
            {
                return this._y2;
            }

            set
            {
                this._y2 = value;

                this.ReorderPoints();
            }
        }

        public float Width
        {
            get
            {
                return (this._x2 - this._x1);
            }

            set
            {
                this._x2 = this._x1 + value;

                this.ReorderPoints();
            }
        }

        public float Height
        {
            get
            {
                return (this._y2 - this._y1);
            }

            set
            {
                this._y2 = this._y1 + value;

                this.ReorderPoints();
            }
        }

        public Point2f Size
        {
            get
            {
                return new Point2f(this._x2 - this._x1, this._y2 - this._y1);
            }

            set
            {
                this.GrowTo(value);
            }
        }

        public float Area
        {
            get
            {
                return (this._x2 - this._x1) * (this._y2 - this._y1);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this.Area == 0);
            }
        }


        public void MoveTo(float prmX1, float prmY1)
        {
            float _width = this.Width;
            float _height = this.Height;

            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2i prmPoint)
        {
            float _width = this.Width;
            float _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2f prmPoint)
        {
            float _width = this.Width;
            float _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveRelative(float prmX1, float prmY1)
        {
            this._x1 += prmX1;
            this._y1 += prmY1;
            this._x2 += prmX1;
            this._y2 += prmY1;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void GrowTo(float prmX, float prmY)
        {
            this._x2 = this._x1 + prmX;
            this._y2 = this._y1 + prmY;

            this.ReorderPoints();
        }

        public void GrowTo(Point2i prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowTo(Point2f prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(float prmX, float prmY)
        {
            this._x2 += prmX;
            this._y2 += prmY;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2i prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2f prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public bool IsInside(float prmX, float prmY)
        {
            return (this.X1 <= prmX && this.X2 >= prmX && this.Y1 <= prmY && this.Y2 >= prmY);
        }

        public bool IsInside(Point2i prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool IsInside(Point2f prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool HasIntersection(Rectangle2i prmRectangle)
        {
            Point2i TopLeft = new Point2i(prmRectangle.X1, prmRectangle.Y1);
            Point2i TopRight = new Point2i(prmRectangle.X2, prmRectangle.Y1);
            Point2i BottomLeft = new Point2i(prmRectangle.X1, prmRectangle.Y2);
            Point2i BottomRight = new Point2i(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public bool HasIntersection(Rectangle2f prmRectangle)
        {
            Point2f TopLeft = new Point2f(prmRectangle.X1, prmRectangle.Y1);
            Point2f TopRight = new Point2f(prmRectangle.X2, prmRectangle.Y1);
            Point2f BottomLeft = new Point2f(prmRectangle.X1, prmRectangle.Y2);
            Point2f BottomRight = new Point2f(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public Rectangle2f Intersect(Rectangle2i prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                float IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                float IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                float IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                float IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return (new Rectangle2f(IntersectX1, IntersectY1, IntersectX2, IntersectY2));
            }
            else
            {
                return null;
            }
        }

        public Rectangle2f Intersect(Rectangle2f prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                float IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                float IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                float IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                float IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return (new Rectangle2f(IntersectX1, IntersectY1, IntersectX2, IntersectY2));
            }
            else
            {
                return null;
            }
        }

        public Rectangle2f Union(Rectangle2i prmRectangle)
        {
            float UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            float UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            float UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            float UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2f(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public Rectangle2f Union(Rectangle2f prmRectangle)
        {
            float UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            float UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            float UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            float UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2f(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public static bool operator ==(Rectangle2f lhs, Rectangle2f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X1 == rhs.X1 && lhs.Y1 == rhs.Y1 && lhs.X2 == rhs.X2 && lhs.Y2 == rhs.Y2)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Rectangle2f lhs, Rectangle2f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Rectangle2f && obj is Rectangle2f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Rectangle2f Rectangle = (Rectangle2f)obj;

                    if (this.X1 == Rectangle.X1 && this.Y1 == Rectangle.Y1 && this.X2 == Rectangle.X2 && this.Y2 == Rectangle.Y2)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX1 = BitConverter.ToInt32(BitConverter.GetBytes(this.X1), 0);
            int PartY1 = BitConverter.ToInt32(BitConverter.GetBytes(this.Y1), 0);
            int PartX2 = BitConverter.ToInt32(BitConverter.GetBytes(this.X2), 0);
            int PartY2 = BitConverter.ToInt32(BitConverter.GetBytes(this.Y2), 0);

            return PartX1 ^ PartY1 ^ PartX2 ^ PartY2;
        }

        public override string ToString()
        {
            return "[" + this.X1 + "," + this.Y1 + " - " + this.X2 + "," + this.Y2 + "]";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Rectangle with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region RECTANGLE2D..
    public class Rectangle2d
    {
        private double _x1 = 0;
        private double _y1 = 0;
        private double _x2 = 0;
        private double _y2 = 0;

        public Rectangle2d()
        {
            this._x1 = 0;
            this._y1 = 0;
            this._x2 = 0;
            this._y2 = 0;
        }

        public Rectangle2d(double prmX1, double prmY1, double prmX2, double prmY2)
        {
            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = prmX2;
            this._y2 = prmY2;

            this.ReorderPoints();
        }

        public Rectangle2d(Point2i prmLeftTop, Point2i prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2d(Point2f prmLeftTop, Point2f prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2d(Point2d prmLeftTop, Point2d prmRightBottom)
        {
            this._x1 = prmLeftTop.X;
            this._y1 = prmLeftTop.Y;
            this._x2 = prmRightBottom.X;
            this._y2 = prmRightBottom.Y;

            this.ReorderPoints();
        }

        public Rectangle2d(Rectangle2i prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        public Rectangle2d(Rectangle2f prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        public Rectangle2d(Rectangle2d prmRectangle)
        {
            this._x1 = prmRectangle.X1;
            this._y1 = prmRectangle.Y1;
            this._x2 = prmRectangle.X2;
            this._y2 = prmRectangle.Y2;

            this.ReorderPoints();
        }

        private void ReorderPoints()
        {
            if (this._x1 > this._x2)
            {
                ToolsX.Swap(ref this._x1, ref this._x2);
            }

            if (this._y1 > this._y2)
            {
                ToolsX.Swap(ref this._y1, ref this._y2);
            }
        }

        public double X1
        {
            get
            {
                return this._x1;
            }

            set
            {
                this._x1 = value;

                this.ReorderPoints();
            }
        }

        public double Y1
        {
            get
            {
                return this._y1;
            }

            set
            {
                this._y1 = value;

                this.ReorderPoints();
            }
        }

        public double X2
        {
            get
            {
                return this._x2;
            }

            set
            {
                this._x2 = value;

                this.ReorderPoints();
            }
        }

        public double Y2
        {
            get
            {
                return this._y2;
            }

            set
            {
                this._y2 = value;

                this.ReorderPoints();
            }
        }

        public double Width
        {
            get
            {
                return (this._x2 - this._x1);
            }

            set
            {
                this._x2 = this._x1 + value;

                this.ReorderPoints();
            }
        }

        public double Height
        {
            get
            {
                return (this._y2 - this._y1);
            }

            set
            {
                this._y2 = this._y1 + value;

                this.ReorderPoints();
            }
        }

        public Point2d Size
        {
            get
            {
                return new Point2d(this._x2 - this._x1, this._y2 - this._y1);
            }

            set
            {
                this.GrowTo(value);
            }
        }

        public double Area
        {
            get
            {
                return (this._x2 - this._x1) * (this._y2 - this._y1);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this.Area == 0);
            }
        }


        public void MoveTo(double prmX1, double prmY1)
        {
            double _width = this.Width;
            double _height = this.Height;

            this._x1 = prmX1;
            this._y1 = prmY1;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2i prmPoint)
        {
            double _width = this.Width;
            double _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2f prmPoint)
        {
            double _width = this.Width;
            double _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveTo(Point2d prmPoint)
        {
            double _width = this.Width;
            double _height = this.Height;

            this._x1 = prmPoint.X;
            this._y1 = prmPoint.Y;
            this._x2 = this._x1 + _width;
            this._y2 = this._y1 + _height;

            this.ReorderPoints();
        }

        public void MoveRelative(double prmX1, double prmY1)
        {
            this._x1 += prmX1;
            this._y1 += prmY1;
            this._x2 += prmX1;
            this._y2 += prmY1;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void MoveRelative(Point2d prmPoint)
        {
            this._x1 += prmPoint.X;
            this._y1 += prmPoint.Y;
            this._x2 += prmPoint.X;
            this._y2 += prmPoint.Y;

            this.ReorderPoints();
        }

        public void GrowTo(double prmX, double prmY)
        {
            this._x2 = this._x1 + prmX;
            this._y2 = this._y1 + prmY;

            this.ReorderPoints();
        }

        public void GrowTo(Point2i prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowTo(Point2f prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowTo(Point2d prmSize)
        {
            this._x2 = this._x1 + prmSize.X;
            this._y2 = this._y1 + prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(double prmX, double prmY)
        {
            this._x2 += prmX;
            this._y2 += prmY;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2i prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2f prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public void GrowRelative(Point2d prmSize)
        {
            this._x2 += prmSize.X;
            this._y2 += prmSize.Y;

            this.ReorderPoints();
        }

        public bool IsInside(double prmX, double prmY)
        {
            return (this.X1 <= prmX && this.X2 >= prmX && this.Y1 <= prmY && this.Y2 >= prmY);
        }

        public bool IsInside(Point2i prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool IsInside(Point2f prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool IsInside(Point2d prmPoint)
        {
            return (this.X1 <= prmPoint.X && this.X2 >= prmPoint.X && this.Y1 <= prmPoint.Y && this.Y2 >= prmPoint.Y);
        }

        public bool HasIntersection(Rectangle2i prmRectangle)
        {
            Point2i TopLeft = new Point2i(prmRectangle.X1, prmRectangle.Y1);
            Point2i TopRight = new Point2i(prmRectangle.X2, prmRectangle.Y1);
            Point2i BottomLeft = new Point2i(prmRectangle.X1, prmRectangle.Y2);
            Point2i BottomRight = new Point2i(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public bool HasIntersection(Rectangle2f prmRectangle)
        {
            Point2f TopLeft = new Point2f(prmRectangle.X1, prmRectangle.Y1);
            Point2f TopRight = new Point2f(prmRectangle.X2, prmRectangle.Y1);
            Point2f BottomLeft = new Point2f(prmRectangle.X1, prmRectangle.Y2);
            Point2f BottomRight = new Point2f(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public bool HasIntersection(Rectangle2d prmRectangle)
        {
            Point2d TopLeft = new Point2d(prmRectangle.X1, prmRectangle.Y1);
            Point2d TopRight = new Point2d(prmRectangle.X2, prmRectangle.Y1);
            Point2d BottomLeft = new Point2d(prmRectangle.X1, prmRectangle.Y2);
            Point2d BottomRight = new Point2d(prmRectangle.X2, prmRectangle.Y2);

            return (this.IsInside(TopLeft) || this.IsInside(TopRight) || this.IsInside(BottomLeft) || this.IsInside(BottomRight));
        }

        public Rectangle2d Intersect(Rectangle2i prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                double IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                double IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                double IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                double IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return (new Rectangle2d(IntersectX1, IntersectY1, IntersectX2, IntersectY2));
            }
            else
            {
                return null;
            }
        }

        public Rectangle2d Intersect(Rectangle2f prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                double IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                double IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                double IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                double IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return (new Rectangle2d(IntersectX1, IntersectY1, IntersectX2, IntersectY2));
            }
            else
            {
                return null;
            }
        }

        public Rectangle2d Intersect(Rectangle2d prmRectangle)
        {
            if (this.HasIntersection(prmRectangle))
            {
                double IntersectX1 = ToolsX.Max(this.X1, prmRectangle.X1);
                double IntersectY1 = ToolsX.Max(this.Y1, prmRectangle.Y1);
                double IntersectX2 = ToolsX.Min(this.X2, prmRectangle.X2);
                double IntersectY2 = ToolsX.Min(this.Y2, prmRectangle.Y2);

                return (new Rectangle2d(IntersectX1, IntersectY1, IntersectX2, IntersectY2));
            }
            else
            {
                return null;
            }
        }

        public Rectangle2d Union(Rectangle2i prmRectangle)
        {
            double UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            double UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            double UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            double UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2d(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public Rectangle2d Union(Rectangle2f prmRectangle)
        {
            double UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            double UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            double UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            double UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2d(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public Rectangle2d Union(Rectangle2d prmRectangle)
        {
            double UnionX1 = ToolsX.Min(this.X1, prmRectangle.X1);
            double UnionY1 = ToolsX.Min(this.Y1, prmRectangle.Y1);
            double UnionX2 = ToolsX.Max(this.X2, prmRectangle.X2);
            double UnionY2 = ToolsX.Max(this.Y2, prmRectangle.Y2);

            return (new Rectangle2d(UnionX1, UnionY1, UnionX2, UnionY2));
        }

        public static bool operator ==(Rectangle2d lhs, Rectangle2d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X1 == rhs.X1 && lhs.Y1 == rhs.Y1 && lhs.X2 == rhs.X2 && lhs.Y2 == rhs.Y2)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Rectangle2d lhs, Rectangle2d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Rectangle2d && obj is Rectangle2d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Rectangle2d Rectangle = (Rectangle2d)obj;

                    if (this.X1 == Rectangle.X1 && this.Y1 == Rectangle.Y1 && this.X2 == Rectangle.X2 && this.Y2 == Rectangle.Y2)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX1 = BitConverter.DoubleToInt64Bits(this.X1);
            long PartY1 = BitConverter.DoubleToInt64Bits(this.Y1);
            long PartX2 = BitConverter.DoubleToInt64Bits(this.X2);
            long PartY2 = BitConverter.DoubleToInt64Bits(this.Y2);

            return (int)(PartX1 >> 32) ^ (int)(PartX1 & 0xFFFFFFFF) ^ (int)(PartY1 >> 32) ^ (int)(PartY1 & 0xFFFFFFFF) ^ (int)(PartX2 >> 32) ^ (int)(PartX2 & 0xFFFFFFFF) ^ (int)(PartY2 >> 32) ^ (int)(PartY2 & 0xFFFFFFFF);
        }

        public override string ToString()
        {
            return "[" + this.X1 + "," + this.Y1 + " - " + this.X2 + "," + this.Y2 + "]";
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // CIRCLE DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Circle with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region CIRCLE2F...
    public class Circle2f
    {
        private float _x = 0;
        private float _y = 0;
        private float _radius = 0;

        public Circle2f()
        {
            this._x = 0;
            this._y = 0;
            this._radius = 0;
        }

        public Circle2f(float prmX, float prmY, float prmRadius)
        {
            this._x = prmX;
            this._y = prmY;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2f(Point2i prmCenter, float prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2f(Point2f prmCenter, float prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2f(Circle2f prmCircle)
        {
            this._x = prmCircle.X;
            this._y = prmCircle.Y;
            this._radius = System.Math.Abs(prmCircle.Radius);
        }

        public float X
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public float Y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        public float Radius
        {
            get
            {
                return this._radius;
            }

            set
            {
                this._radius = System.Math.Abs(value);
            }
        }

        public float Area
        {
            get
            {
                return ((float)System.Math.PI * this._radius * this._radius);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this._radius == 0);
            }
        }

        public void MoveTo(float prmX, float prmY)
        {
            this._x = prmX;
            this._y = prmY;
        }

        public void MoveTo(Point2i prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
        }

        public void MoveTo(Point2f prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
        }

        public void MoveRelative(float prmX, float prmY)
        {
            this._x += prmX;
            this._y += prmY;
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
        }

        public void GrowTo(float prmRadius)
        {
            this._radius = System.Math.Abs(prmRadius);
        }

        public void GrowRelative(float prmRadius)
        {
            this._radius += prmRadius;
            this._radius = System.Math.Abs(this._radius);
        }

        public bool IsInside(float prmX, float prmY)
        {
            float DifferenceX = prmX - this._x;
            float DifferenceY = prmY - this._y;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point2i prmPoint)
        {
            float DifferenceX = prmPoint.X - this._x;
            float DifferenceY = prmPoint.Y - this._y;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point2f prmPoint)
        {
            float DifferenceX = prmPoint.X - this._x;
            float DifferenceY = prmPoint.Y - this._y;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public static bool operator ==(Circle2f lhs, Circle2f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Radius == rhs.Radius)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Circle2f lhs, Circle2f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Circle2f && obj is Circle2f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Circle2f Circle = (Circle2f)obj;

                    if (this.X == Circle.X && this.Y == Circle.Y && this.Radius == Circle.Radius)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            int PartRadius = BitConverter.ToInt32(BitConverter.GetBytes(this.Radius), 0);

            return PartX ^ PartY ^ PartRadius;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2 Dimensional Circle with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region CIRCLE2D...
    public class Circle2d
    {
        private double _x = 0;
        private double _y = 0;
        private double _radius = 0;

        public Circle2d()
        {
            this._x = 0;
            this._y = 0;
            this._radius = 0;
        }

        public Circle2d(double prmX, double prmY, double prmRadius)
        {
            this._x = prmX;
            this._y = prmY;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2d(Point2i prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2d(Point2f prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2d(Point2d prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Circle2d(Circle2f prmCircle)
        {
            this._x = prmCircle.X;
            this._y = prmCircle.Y;
            this._radius = System.Math.Abs(prmCircle.Radius);
        }

        public Circle2d(Circle2d prmCircle)
        {
            this._x = prmCircle.X;
            this._y = prmCircle.Y;
            this._radius = System.Math.Abs(prmCircle.Radius);
        }

        public double X
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public double Y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        public double Radius
        {
            get
            {
                return this._radius;
            }

            set
            {
                this._radius = System.Math.Abs(value);
            }
        }

        public double Area
        {
            get
            {
                return (System.Math.PI * this._radius * this._radius);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this._radius == 0);
            }
        }

        public void MoveTo(double prmX, double prmY)
        {
            this._x = prmX;
            this._y = prmY;
        }

        public void MoveTo(Point2i prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
        }

        public void MoveTo(Point2f prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
        }

        public void MoveTo(Point2d prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
        }

        public void MoveRelative(double prmX, double prmY)
        {
            this._x += prmX;
            this._y += prmY;
        }

        public void MoveRelative(Point2i prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
        }

        public void MoveRelative(Point2f prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
        }

        public void MoveRelative(Point2d prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
        }

        public void GrowTo(double prmRadius)
        {
            this._radius = System.Math.Abs(prmRadius);
        }

        public void GrowRelative(double prmRadius)
        {
            this._radius += prmRadius;
            this._radius = System.Math.Abs(this._radius);
        }

        public bool IsInside(double prmX, double prmY)
        {
            double DifferenceX = prmX - this._x;
            double DifferenceY = prmY - this._y;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point2i prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point2f prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point2d prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY);

            return (Distance <= this._radius);
        }

        public static bool operator ==(Circle2d lhs, Circle2d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Radius == rhs.Radius)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Circle2d lhs, Circle2d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Circle2d && obj is Circle2d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Circle2d Circle = (Circle2d)obj;

                    if (this.X == Circle.X && this.Y == Circle.Y && this.Radius == Circle.Radius)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);
            long PartRadius = BitConverter.DoubleToInt64Bits(this.Radius);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF) ^ (int)(PartRadius >> 32) ^ (int)(PartRadius & 0xFFFFFFFF);
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // SPHERE DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Sphere with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region SPHERE3F...
    public class Sphere3f
    {
        private float _x = 0;
        private float _y = 0;
        private float _z = 0;
        private float _radius = 0;

        public Sphere3f()
        {
            this._x = 0;
            this._y = 0;
            this._z = 0;
            this._radius = 0;
        }

        public Sphere3f(float prmX, float prmY, float prmZ, float prmRadius)
        {
            this._x = prmX;
            this._y = prmY;
            this._z = prmZ;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3f(Point3i prmCenter, float prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._z = prmCenter.Z;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3f(Point3f prmCenter, float prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._z = prmCenter.Z;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3f(Sphere3f prmSphere)
        {
            this._x = prmSphere.X;
            this._y = prmSphere.Y;
            this._z = prmSphere.Z;
            this._radius = System.Math.Abs(prmSphere.Radius);
        }

        public float X
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public float Y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        public float Z
        {
            get
            {
                return this._z;
            }

            set
            {
                this._z = value;
            }
        }

        public float Radius
        {
            get
            {
                return this._radius;
            }

            set
            {
                this._radius = System.Math.Abs(value);
            }
        }

        public float Area
        {
            get
            {
                return (4 * (float)System.Math.PI * this._radius * this._radius);
            }
        }

        public float Volume
        {
            get
            {
                return (4 / 3) * ((float)System.Math.PI * this._radius * this._radius * this._radius);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this._radius == 0);
            }
        }

        public void MoveTo(float prmX, float prmY, float prmZ)
        {
            this._x = prmX;
            this._y = prmY;
            this._z = prmZ;
        }

        public void MoveTo(Point3i prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
            this._z = prmPoint.Z;
        }

        public void MoveTo(Point3f prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
            this._z = prmPoint.Z;
        }

        public void MoveRelative(float prmX, float prmY, float prmZ)
        {
            this._x += prmX;
            this._y += prmY;
            this._z += prmZ;
        }

        public void MoveRelative(Point3i prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
            this._z += prmPoint.Z;
        }

        public void MoveRelative(Point3f prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
            this._z += prmPoint.Z;
        }

        public void GrowTo(float prmRadius)
        {
            this._radius = System.Math.Abs(prmRadius);
        }

        public void GrowRelative(float prmRadius)
        {
            this._radius += prmRadius;
            this._radius = System.Math.Abs(this._radius);
        }

        public bool IsInside(float prmX, float prmY, float prmZ)
        {
            float DifferenceX = prmX - this._x;
            float DifferenceY = prmY - this._y;
            float DifferenceZ = prmZ - this._z;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point3i prmPoint)
        {
            float DifferenceX = prmPoint.X - this._x;
            float DifferenceY = prmPoint.Y - this._y;
            float DifferenceZ = prmPoint.Z - this._z;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point3f prmPoint)
        {
            float DifferenceX = prmPoint.X - this._x;
            float DifferenceY = prmPoint.Y - this._y;
            float DifferenceZ = prmPoint.Z - this._z;

            float Distance = (float)System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public static bool operator ==(Sphere3f lhs, Sphere3f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z && lhs.Radius == rhs.Radius)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Sphere3f lhs, Sphere3f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Sphere3f && obj is Sphere3f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Sphere3f Sphere = (Sphere3f)obj;

                    if (this.X == Sphere.X && this.Y == Sphere.Y && this.Z == Sphere.Z && this.Radius == Sphere.Radius)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartX = BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            int PartY = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            int PartZ = BitConverter.ToInt32(BitConverter.GetBytes(this.Z), 0);
            int PartRadius = BitConverter.ToInt32(BitConverter.GetBytes(this.Radius), 0);

            return PartX ^ PartY ^ PartZ ^ PartRadius;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3 Dimensional Sphere with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region SPHERE3D...
    public class Sphere3d
    {
        private double _x = 0;
        private double _y = 0;
        private double _z = 0;
        private double _radius = 0;

        public Sphere3d()
        {
            this._x = 0;
            this._y = 0;
            this._z = 0;
            this._radius = 0;
        }

        public Sphere3d(double prmX, double prmY, double prmZ, double prmRadius)
        {
            this._x = prmX;
            this._y = prmY;
            this._z = prmZ;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3d(Point3i prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._z = prmCenter.Z;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3d(Point3f prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._z = prmCenter.Z;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3d(Point3d prmCenter, double prmRadius)
        {
            this._x = prmCenter.X;
            this._y = prmCenter.Y;
            this._z = prmCenter.Z;
            this._radius = System.Math.Abs(prmRadius);
        }

        public Sphere3d(Sphere3f prmSphere)
        {
            this._x = prmSphere.X;
            this._y = prmSphere.Y;
            this._z = prmSphere.Z;
            this._radius = System.Math.Abs(prmSphere.Radius);
        }

        public Sphere3d(Sphere3d prmSphere)
        {
            this._x = prmSphere.X;
            this._y = prmSphere.Y;
            this._z = prmSphere.Z;
            this._radius = System.Math.Abs(prmSphere.Radius);
        }

        public double X
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public double Y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        public double Z
        {
            get
            {
                return this._z;
            }

            set
            {
                this._z = value;
            }
        }

        public double Radius
        {
            get
            {
                return this._radius;
            }

            set
            {
                this._radius = System.Math.Abs(value);
            }
        }

        public double Area
        {
            get
            {
                return (4 * System.Math.PI * this._radius * this._radius);
            }
        }

        public double Volume
        {
            get
            {
                return (4 / 3) * (System.Math.PI * this._radius * this._radius * this._radius);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (this._radius == 0);
            }
        }

        public void MoveTo(double prmX, double prmY, double prmZ)
        {
            this._x = prmX;
            this._y = prmY;
            this._z = prmZ;
        }

        public void MoveTo(Point3i prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
            this._z = prmPoint.Z;
        }

        public void MoveTo(Point3f prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
            this._z = prmPoint.Z;
        }

        public void MoveTo(Point3d prmPoint)
        {
            this._x = prmPoint.X;
            this._y = prmPoint.Y;
            this._z = prmPoint.Z;
        }

        public void MoveRelative(double prmX, double prmY, double prmZ)
        {
            this._x += prmX;
            this._y += prmY;
            this._z += prmZ;
        }

        public void MoveRelative(Point3i prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
            this._z += prmPoint.Z;
        }

        public void MoveRelative(Point3f prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
            this._z += prmPoint.Z;
        }

        public void MoveRelative(Point3d prmPoint)
        {
            this._x += prmPoint.X;
            this._y += prmPoint.Y;
            this._z += prmPoint.Z;
        }

        public void GrowTo(double prmRadius)
        {
            this._radius = System.Math.Abs(prmRadius);
        }

        public void GrowRelative(double prmRadius)
        {
            this._radius += prmRadius;
            this._radius = System.Math.Abs(this._radius);
        }

        public bool IsInside(double prmX, double prmY, double prmZ)
        {
            double DifferenceX = prmX - this._x;
            double DifferenceY = prmY - this._y;
            double DifferenceZ = prmZ - this._z;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point3i prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;
            double DifferenceZ = prmPoint.Z - this._z;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point3f prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;
            double DifferenceZ = prmPoint.Z - this._z;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public bool IsInside(Point3d prmPoint)
        {
            double DifferenceX = prmPoint.X - this._x;
            double DifferenceY = prmPoint.Y - this._y;
            double DifferenceZ = prmPoint.Z - this._z;

            double Distance = System.Math.Sqrt(DifferenceX * DifferenceX + DifferenceY * DifferenceY + DifferenceZ * DifferenceZ);

            return (Distance <= this._radius);
        }

        public static bool operator ==(Sphere3d lhs, Sphere3d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z && lhs.Radius == rhs.Radius)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Sphere3d lhs, Sphere3d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Sphere3d && obj is Sphere3d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Sphere3d Sphere = (Sphere3d)obj;

                    if (this.X == Sphere.X && this.Y == Sphere.Y && this.Z == Sphere.Z && this.Radius == Sphere.Radius)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartX = BitConverter.DoubleToInt64Bits(this.X);
            long PartY = BitConverter.DoubleToInt64Bits(this.Y);
            long PartZ = BitConverter.DoubleToInt64Bits(this.Z);
            long PartRadius = BitConverter.DoubleToInt64Bits(this.Radius);

            return (int)(PartX >> 32) ^ (int)(PartX & 0xFFFFFFFF) ^ (int)(PartY >> 32) ^ (int)(PartY & 0xFFFFFFFF) ^ (int)(PartZ >> 32) ^ (int)(PartZ & 0xFFFFFFFF) ^ (int)(PartRadius >> 32) ^ (int)(PartRadius & 0xFFFFFFFF);
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // MATRIX DEFINITIONS
    ///////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////
    // 2x2 Dimensional Matrix with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX2F...
    public class Matrix2f
    {
        private float _m11 = 0; private float _m12 = 0;
        private float _m21 = 0; private float _m22 = 0;

        public float M11 { get { return this._m11; } set { this._m11 = value; } }
        public float M12 { get { return this._m12; } set { this._m12 = value; } }
        public float M21 { get { return this._m21; } set { this._m21 = value; } }
        public float M22 { get { return this._m22; } set { this._m22 = value; } }

        public Matrix2f()
        {
            this._m11 = 0; this._m12 = 0;
            this._m21 = 0; this._m22 = 0;
        }

        public Matrix2f(float M11, float M12, float M21, float M22)
        {
            this._m11 = M11; this._m12 = M12;
            this._m21 = M21; this._m22 = M22;
        }

        public Matrix2f(Matrix2f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0;
            this._m21 = 0; this._m22 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m21, ref this._m12);
        }

        public float Determinant()
        {
            return (this._m11 * this._m22 - this._m21 * this._m12);
        }

        public static Matrix2f operator +(Matrix2f lhs, Matrix2f rhs)
        {
            Matrix2f Result = new Matrix2f();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M21;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;

            return Result;
        }

        public static Matrix2f operator -(Matrix2f lhs, Matrix2f rhs)
        {
            Matrix2f Result = new Matrix2f();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M21;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;

            return Result;
        }

        public static Matrix2f operator *(float lhs, Matrix2f rhs)
        {
            Matrix2f Result = new Matrix2f();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;

            return Result;
        }

        public static Matrix2f operator *(Matrix2f lhs, float rhs)
        {
            Matrix2f Result = new Matrix2f();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;

            return Result;
        }

        public static Matrix2f operator *(Matrix2f lhs, Matrix2f rhs)
        {
            Matrix2f Result = new Matrix2f();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22;
            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21;
            Result.M22 = lhs.M22 * rhs.M12 + lhs.M22 * rhs.M22;

            return Result;
        }

        public static bool operator ==(Matrix2f lhs, Matrix2f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix2f lhs, Matrix2f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix2f && obj is Matrix2f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix2f Matrix = (Matrix2f)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M21 == Matrix.M21 && this.M22 == Matrix.M22)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartM11 = BitConverter.ToInt32(BitConverter.GetBytes(this.M11), 0);
            int PartM12 = BitConverter.ToInt32(BitConverter.GetBytes(this.M12), 0);
            int PartM21 = BitConverter.ToInt32(BitConverter.GetBytes(this.M21), 0);
            int PartM22 = BitConverter.ToInt32(BitConverter.GetBytes(this.M22), 0);

            return PartM11 ^ PartM12 ^ PartM21 ^ PartM22;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 2x2 Dimensional Matrix with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX2D...
    public class Matrix2d
    {
        private double _m11 = 0; private double _m12 = 0;
        private double _m21 = 0; private double _m22 = 0;

        public double M11 { get { return this._m11; } set { this._m11 = value; } }
        public double M12 { get { return this._m12; } set { this._m12 = value; } }
        public double M21 { get { return this._m21; } set { this._m21 = value; } }
        public double M22 { get { return this._m22; } set { this._m22 = value; } }

        public Matrix2d()
        {
            this._m11 = 0; this._m12 = 0;
            this._m21 = 0; this._m22 = 0;
        }

        public Matrix2d(double M11, double M12, double M21, double M22)
        {
            this._m11 = M11; this._m12 = M12;
            this._m21 = M21; this._m22 = M22;
        }

        public Matrix2d(Matrix2f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
        }

        public Matrix2d(Matrix2d Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0;
            this._m21 = 0; this._m22 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m21, ref this._m12);
        }

        public double Determinant()
        {
            return (this._m11 * this._m22 - this._m21 * this._m12);
        }

        public static Matrix2d operator +(Matrix2d lhs, Matrix2d rhs)
        {
            Matrix2d Result = new Matrix2d();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M21;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;

            return Result;
        }

        public static Matrix2d operator -(Matrix2d lhs, Matrix2d rhs)
        {
            Matrix2d Result = new Matrix2d();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M21;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;

            return Result;
        }

        public static Matrix2d operator *(double lhs, Matrix2d rhs)
        {
            Matrix2d Result = new Matrix2d();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;

            return Result;
        }

        public static Matrix2d operator *(Matrix2d lhs, double rhs)
        {
            Matrix2d Result = new Matrix2d();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;

            return Result;
        }

        public static Matrix2d operator *(Matrix2d lhs, Matrix2d rhs)
        {
            Matrix2d Result = new Matrix2d();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22;
            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21;
            Result.M22 = lhs.M22 * rhs.M12 + lhs.M22 * rhs.M22;

            return Result;
        }

        public static bool operator ==(Matrix2d lhs, Matrix2d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix2d lhs, Matrix2d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix2d && obj is Matrix2d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix2d Matrix = (Matrix2d)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M21 == Matrix.M21 && this.M22 == Matrix.M22)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartM11 = BitConverter.DoubleToInt64Bits(this.M11);
            long PartM12 = BitConverter.DoubleToInt64Bits(this.M12);
            long PartM21 = BitConverter.DoubleToInt64Bits(this.M21);
            long PartM22 = BitConverter.DoubleToInt64Bits(this.M22);

            int PartM11a = (int)(PartM11 >> 32);
            int PartM11b = (int)(PartM11 & 0xFFFFFFFF);
            int PartM12a = (int)(PartM12 >> 32);
            int PartM12b = (int)(PartM12 & 0xFFFFFFFF);
            int PartM21a = (int)(PartM21 >> 32);
            int PartM21b = (int)(PartM21 & 0xFFFFFFFF);
            int PartM22a = (int)(PartM22 >> 32);
            int PartM22b = (int)(PartM22 & 0xFFFFFFFF);

            return PartM11a ^ PartM11b ^ PartM12a ^ PartM12b ^ PartM21a ^ PartM21b ^ PartM22a ^ PartM22b;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3x3 Dimensional Matrix with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX3F...
    public class Matrix3f
    {
        private float _m11 = 0; private float _m12 = 0; private float _m13 = 0;
        private float _m21 = 0; private float _m22 = 0; private float _m23 = 0;
        private float _m31 = 0; private float _m32 = 0; private float _m33 = 0;

        public float M11 { get { return this._m11; } set { this._m11 = value; } }
        public float M12 { get { return this._m12; } set { this._m12 = value; } }
        public float M13 { get { return this._m13; } set { this._m13 = value; } }
        public float M21 { get { return this._m21; } set { this._m21 = value; } }
        public float M22 { get { return this._m22; } set { this._m22 = value; } }
        public float M23 { get { return this._m23; } set { this._m23 = value; } }
        public float M31 { get { return this._m31; } set { this._m31 = value; } }
        public float M32 { get { return this._m32; } set { this._m32 = value; } }
        public float M33 { get { return this._m33; } set { this._m33 = value; } }

        public Matrix3f()
        {
            this._m11 = 0; this._m12 = 0; this._m13 = 0;
            this._m21 = 0; this._m22 = 0; this._m23 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 0;
        }

        public Matrix3f(float M11, float M12, float M13, float M21, float M22, float M23, float M31, float M32, float M33)
        {
            this._m11 = M11; this._m12 = M12; this._m13 = M13;
            this._m21 = M21; this._m22 = M22; this._m23 = M23;
            this._m31 = M31; this._m32 = M32; this._m33 = M33;
        }

        public Matrix3f(Matrix3f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0; this._m13 = 0;
            this._m21 = 0; this._m22 = 1; this._m23 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m12, ref this._m21);
            ToolsX.Swap(ref this._m13, ref this._m31);
            ToolsX.Swap(ref this._m23, ref this._m32);
        }

        public float Determinant()
        {
            float down1 = this._m11 * this._m22 * this._m33;
            float down2 = this._m12 * this._m23 * this._m31;
            float down3 = this._m13 * this._m21 * this._m32;
            float up1 = this._m11 * this._m32 * this._m23;
            float up2 = this._m21 * this._m12 * this._m33;
            float up3 = this._m31 * this._m22 * this._m13;

            return (down1 + down2 + down3 - up1 - up2 - up3);
        }

        public static Matrix3f operator +(Matrix3f lhs, Matrix3f rhs)
        {
            Matrix3f Result = new Matrix3f();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M12;
            Result.M13 = lhs.M13 + rhs.M13;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;
            Result.M23 = lhs.M23 + rhs.M23;
            Result.M31 = lhs.M31 + rhs.M31;
            Result.M32 = lhs.M32 + rhs.M32;
            Result.M33 = lhs.M33 + rhs.M33;

            return Result;
        }

        public static Matrix3f operator -(Matrix3f lhs, Matrix3f rhs)
        {
            Matrix3f Result = new Matrix3f();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M12;
            Result.M13 = lhs.M13 - rhs.M13;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;
            Result.M23 = lhs.M23 - rhs.M23;
            Result.M31 = lhs.M31 - rhs.M31;
            Result.M32 = lhs.M32 - rhs.M32;
            Result.M33 = lhs.M33 - rhs.M33;

            return Result;
        }

        public static Matrix3f operator *(float lhs, Matrix3f rhs)
        {
            Matrix3f Result = new Matrix3f();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M13 = lhs * rhs.M13;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;
            Result.M23 = lhs * rhs.M23;
            Result.M31 = lhs * rhs.M31;
            Result.M32 = lhs * rhs.M32;
            Result.M33 = lhs * rhs.M33;

            return Result;
        }

        public static Matrix3f operator *(Matrix3f lhs, float rhs)
        {
            Matrix3f Result = new Matrix3f();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M13 = lhs.M13 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;
            Result.M23 = lhs.M23 * rhs;
            Result.M31 = lhs.M31 * rhs;
            Result.M32 = lhs.M32 * rhs;
            Result.M33 = lhs.M33 * rhs;

            return Result;
        }

        public static Matrix3f operator *(Matrix3f lhs, Matrix3f rhs)
        {
            Matrix3f Result = new Matrix3f();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21 + lhs.M13 * rhs.M31;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22 + lhs.M13 * rhs.M32;
            Result.M13 = lhs.M11 * rhs.M13 + lhs.M12 * rhs.M23 + lhs.M13 * rhs.M33;

            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21 + lhs.M23 * rhs.M31;
            Result.M22 = lhs.M21 * rhs.M12 + lhs.M22 * rhs.M22 + lhs.M23 * rhs.M32;
            Result.M23 = lhs.M21 * rhs.M13 + lhs.M22 * rhs.M23 + lhs.M23 * rhs.M33;
            
            Result.M31 = lhs.M31 * rhs.M11 + lhs.M32 * rhs.M21 + lhs.M33 * rhs.M31;
            Result.M32 = lhs.M31 * rhs.M12 + lhs.M32 * rhs.M22 + lhs.M33 * rhs.M32;
            Result.M33 = lhs.M31 * rhs.M13 + lhs.M32 * rhs.M23 + lhs.M33 * rhs.M33;

            return Result;
        }

        public static bool operator ==(Matrix3f lhs, Matrix3f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M13 == rhs.M13 &&
                    lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22 && lhs.M23 == rhs.M23 &&
                    lhs.M31 == rhs.M31 && lhs.M32 == rhs.M32 && lhs.M33 == rhs.M33)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix3f lhs, Matrix3f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix3f && obj is Matrix3f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix3f Matrix = (Matrix3f)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M13 == Matrix.M13 &&
                        this.M21 == Matrix.M21 && this.M22 == Matrix.M22 && this.M23 == Matrix.M23 &&
                        this.M31 == Matrix.M31 && this.M32 == Matrix.M32 && this.M33 == Matrix.M33)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartM11 = BitConverter.ToInt32(BitConverter.GetBytes(this.M11), 0);
            int PartM12 = BitConverter.ToInt32(BitConverter.GetBytes(this.M12), 0);
            int PartM13 = BitConverter.ToInt32(BitConverter.GetBytes(this.M13), 0);
            int PartM21 = BitConverter.ToInt32(BitConverter.GetBytes(this.M21), 0);
            int PartM22 = BitConverter.ToInt32(BitConverter.GetBytes(this.M22), 0);
            int PartM23 = BitConverter.ToInt32(BitConverter.GetBytes(this.M23), 0);
            int PartM31 = BitConverter.ToInt32(BitConverter.GetBytes(this.M31), 0);
            int PartM32 = BitConverter.ToInt32(BitConverter.GetBytes(this.M32), 0);
            int PartM33 = BitConverter.ToInt32(BitConverter.GetBytes(this.M33), 0);

            return PartM11 ^ PartM12 ^ PartM13 ^ PartM21 ^ PartM22 ^ PartM23 ^ PartM31 ^ PartM32 ^ PartM33;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 3x3 Dimensional Matrix with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX3D...
    public class Matrix3d
    {
        private double _m11 = 0; private double _m12 = 0; private double _m13 = 0;
        private double _m21 = 0; private double _m22 = 0; private double _m23 = 0;
        private double _m31 = 0; private double _m32 = 0; private double _m33 = 0;

        public double M11 { get { return this._m11; } set { this._m11 = value; } }
        public double M12 { get { return this._m12; } set { this._m12 = value; } }
        public double M13 { get { return this._m13; } set { this._m13 = value; } }
        public double M21 { get { return this._m21; } set { this._m21 = value; } }
        public double M22 { get { return this._m22; } set { this._m22 = value; } }
        public double M23 { get { return this._m23; } set { this._m23 = value; } }
        public double M31 { get { return this._m31; } set { this._m31 = value; } }
        public double M32 { get { return this._m32; } set { this._m32 = value; } }
        public double M33 { get { return this._m33; } set { this._m33 = value; } }

        public Matrix3d()
        {
            this._m11 = 0; this._m12 = 0; this._m13 = 0;
            this._m21 = 0; this._m22 = 0; this._m23 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 0;
        }

        public Matrix3d(double M11, double M12, double M13, double M21, double M22, double M23, double M31, double M32, double M33)
        {
            this._m11 = M11; this._m12 = M12; this._m13 = M13;
            this._m21 = M21; this._m22 = M22; this._m23 = M23;
            this._m31 = M31; this._m32 = M32; this._m33 = M33;
        }

        public Matrix3d(Matrix3f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
        }

        public Matrix3d(Matrix3d Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0; this._m13 = 0;
            this._m21 = 0; this._m22 = 1; this._m23 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m12, ref this._m21);
            ToolsX.Swap(ref this._m13, ref this._m31);
            ToolsX.Swap(ref this._m23, ref this._m32);
        }

        public double Determinant()
        {
            double down1 = this._m11 * this._m22 * this._m33;
            double down2 = this._m12 * this._m23 * this._m31;
            double down3 = this._m13 * this._m21 * this._m32;
            double up1 = this._m11 * this._m32 * this._m23;
            double up2 = this._m21 * this._m12 * this._m33;
            double up3 = this._m31 * this._m22 * this._m13;

            return (down1 + down2 + down3 - up1 - up2 - up3);
        }

        public static Matrix3d operator +(Matrix3d lhs, Matrix3d rhs)
        {
            Matrix3d Result = new Matrix3d();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M12;
            Result.M13 = lhs.M13 + rhs.M13;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;
            Result.M23 = lhs.M23 + rhs.M23;
            Result.M31 = lhs.M31 + rhs.M31;
            Result.M32 = lhs.M32 + rhs.M32;
            Result.M33 = lhs.M33 + rhs.M33;

            return Result;
        }

        public static Matrix3d operator -(Matrix3d lhs, Matrix3d rhs)
        {
            Matrix3d Result = new Matrix3d();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M12;
            Result.M13 = lhs.M13 - rhs.M13;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;
            Result.M23 = lhs.M23 - rhs.M23;
            Result.M31 = lhs.M31 - rhs.M31;
            Result.M32 = lhs.M32 - rhs.M32;
            Result.M33 = lhs.M33 - rhs.M33;

            return Result;
        }

        public static Matrix3d operator *(double lhs, Matrix3d rhs)
        {
            Matrix3d Result = new Matrix3d();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M13 = lhs * rhs.M13;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;
            Result.M23 = lhs * rhs.M23;
            Result.M31 = lhs * rhs.M31;
            Result.M32 = lhs * rhs.M32;
            Result.M33 = lhs * rhs.M33;

            return Result;
        }

        public static Matrix3d operator *(Matrix3d lhs, double rhs)
        {
            Matrix3d Result = new Matrix3d();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M13 = lhs.M13 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;
            Result.M23 = lhs.M23 * rhs;
            Result.M31 = lhs.M31 * rhs;
            Result.M32 = lhs.M32 * rhs;
            Result.M33 = lhs.M33 * rhs;

            return Result;
        }

        public static Matrix3d operator *(Matrix3d lhs, Matrix3d rhs)
        {
            Matrix3d Result = new Matrix3d();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21 + lhs.M13 * rhs.M31;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22 + lhs.M13 * rhs.M32;
            Result.M13 = lhs.M11 * rhs.M13 + lhs.M12 * rhs.M23 + lhs.M13 * rhs.M33;

            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21 + lhs.M23 * rhs.M31;
            Result.M22 = lhs.M21 * rhs.M12 + lhs.M22 * rhs.M22 + lhs.M23 * rhs.M32;
            Result.M23 = lhs.M21 * rhs.M13 + lhs.M22 * rhs.M23 + lhs.M23 * rhs.M33;

            Result.M31 = lhs.M31 * rhs.M11 + lhs.M32 * rhs.M21 + lhs.M33 * rhs.M31;
            Result.M32 = lhs.M31 * rhs.M12 + lhs.M32 * rhs.M22 + lhs.M33 * rhs.M32;
            Result.M33 = lhs.M31 * rhs.M13 + lhs.M32 * rhs.M23 + lhs.M33 * rhs.M33;

            return Result;
        }

        public static bool operator ==(Matrix3d lhs, Matrix3d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M13 == rhs.M13 &&
                    lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22 && lhs.M23 == rhs.M23 &&
                    lhs.M31 == rhs.M31 && lhs.M32 == rhs.M32 && lhs.M33 == rhs.M33)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix3d lhs, Matrix3d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix3d && obj is Matrix3d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix3d Matrix = (Matrix3d)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M13 == Matrix.M13 &&
                        this.M21 == Matrix.M21 && this.M22 == Matrix.M22 && this.M23 == Matrix.M23 &&
                        this.M31 == Matrix.M31 && this.M32 == Matrix.M32 && this.M33 == Matrix.M33)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartM11 = BitConverter.DoubleToInt64Bits(this.M11);
            long PartM12 = BitConverter.DoubleToInt64Bits(this.M12);
            long PartM13 = BitConverter.DoubleToInt64Bits(this.M13);
            long PartM21 = BitConverter.DoubleToInt64Bits(this.M21);
            long PartM22 = BitConverter.DoubleToInt64Bits(this.M22);
            long PartM23 = BitConverter.DoubleToInt64Bits(this.M23);
            long PartM31 = BitConverter.DoubleToInt64Bits(this.M31);
            long PartM32 = BitConverter.DoubleToInt64Bits(this.M32);
            long PartM33 = BitConverter.DoubleToInt64Bits(this.M33);

            int PartM11a = (int)(PartM11 >> 32);
            int PartM11b = (int)(PartM11 & 0xFFFFFFFF);
            int PartM12a = (int)(PartM12 >> 32);
            int PartM12b = (int)(PartM12 & 0xFFFFFFFF);
            int PartM13a = (int)(PartM13 >> 32);
            int PartM13b = (int)(PartM13 & 0xFFFFFFFF);
            int PartM21a = (int)(PartM21 >> 32);
            int PartM21b = (int)(PartM21 & 0xFFFFFFFF);
            int PartM22a = (int)(PartM22 >> 32);
            int PartM22b = (int)(PartM22 & 0xFFFFFFFF);
            int PartM23a = (int)(PartM23 >> 32);
            int PartM23b = (int)(PartM23 & 0xFFFFFFFF);
            int PartM31a = (int)(PartM31 >> 32);
            int PartM31b = (int)(PartM31 & 0xFFFFFFFF);
            int PartM32a = (int)(PartM32 >> 32);
            int PartM32b = (int)(PartM32 & 0xFFFFFFFF);
            int PartM33a = (int)(PartM33 >> 32);
            int PartM33b = (int)(PartM33 & 0xFFFFFFFF);

            return PartM11a ^ PartM11b ^ PartM12a ^ PartM12b ^ PartM13a ^ PartM13b ^
                   PartM21a ^ PartM21b ^ PartM22a ^ PartM22b ^ PartM23a ^ PartM23b ^
                   PartM31a ^ PartM31b ^ PartM32a ^ PartM32b ^ PartM33a ^ PartM33b;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 4x4 Dimensional Matrix with "float" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX4F...
    public class Matrix4f
    {
        private float _m11 = 0; private float _m12 = 0; private float _m13 = 0; private float _m14 = 0;
        private float _m21 = 0; private float _m22 = 0; private float _m23 = 0; private float _m24 = 0;
        private float _m31 = 0; private float _m32 = 0; private float _m33 = 0; private float _m34 = 0;
        private float _m41 = 0; private float _m42 = 0; private float _m43 = 0; private float _m44 = 0;

        public float M11 { get { return this._m11; } set { this._m11 = value; } }
        public float M12 { get { return this._m12; } set { this._m12 = value; } }
        public float M13 { get { return this._m13; } set { this._m13 = value; } }
        public float M14 { get { return this._m14; } set { this._m14 = value; } }
        public float M21 { get { return this._m21; } set { this._m21 = value; } }
        public float M22 { get { return this._m22; } set { this._m22 = value; } }
        public float M23 { get { return this._m23; } set { this._m23 = value; } }
        public float M24 { get { return this._m24; } set { this._m24 = value; } }
        public float M31 { get { return this._m31; } set { this._m31 = value; } }
        public float M32 { get { return this._m32; } set { this._m32 = value; } }
        public float M33 { get { return this._m33; } set { this._m33 = value; } }
        public float M34 { get { return this._m34; } set { this._m34 = value; } }
        public float M41 { get { return this._m41; } set { this._m41 = value; } }
        public float M42 { get { return this._m42; } set { this._m42 = value; } }
        public float M43 { get { return this._m43; } set { this._m43 = value; } }
        public float M44 { get { return this._m44; } set { this._m44 = value; } }

        public Matrix4f()
        {
            this._m11 = 0; this._m12 = 0; this._m13 = 0; this._m14 = 0;
            this._m21 = 0; this._m22 = 0; this._m23 = 0; this._m24 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 0; this._m34 = 0;
            this._m41 = 0; this._m42 = 0; this._m43 = 0; this._m44 = 0;
        }

        public Matrix4f(float M11, float M12, float M13, float M14, float M21, float M22, float M23, float M24, float M31, float M32, float M33, float M34, float M41, float M42, float M43, float M44)
        {
            this._m11 = M11; this._m12 = M12; this._m13 = M13; this._m14 = M14;
            this._m21 = M21; this._m22 = M22; this._m23 = M23; this._m24 = M24;
            this._m31 = M31; this._m32 = M32; this._m33 = M33; this._m34 = M34;
            this._m41 = M41; this._m42 = M42; this._m43 = M43; this._m44 = M44;
        }

        public Matrix4f(Matrix4f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m14 = Matrix.M14;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m24 = Matrix.M24;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
            this._m34 = Matrix.M34;
            this._m41 = Matrix.M41;
            this._m42 = Matrix.M42;
            this._m43 = Matrix.M43;
            this._m44 = Matrix.M44;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0; this._m13 = 0; this._m14 = 0;
            this._m21 = 0; this._m22 = 1; this._m23 = 0; this._m24 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 1; this._m34 = 0;
            this._m41 = 0; this._m42 = 0; this._m43 = 0; this._m44 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m21, ref this._m12);
            ToolsX.Swap(ref this._m31, ref this._m13);
            ToolsX.Swap(ref this._m41, ref this._m14);
            ToolsX.Swap(ref this._m42, ref this._m24);
            ToolsX.Swap(ref this._m43, ref this._m34);
        }

        public float Determinant()
        {
            Matrix3f det11 = new Matrix3f(this._m22, this._m23, this._m24, this._m32, this._m33, this._m34, this._m42, this._m43, this._m44);
            Matrix3f det12 = new Matrix3f(this._m21, this._m23, this._m24, this._m31, this._m33, this._m34, this._m41, this._m43, this._m44);
            Matrix3f det13 = new Matrix3f(this._m21, this._m22, this._m24, this._m31, this._m32, this._m34, this._m41, this._m42, this._m44);
            Matrix3f det14 = new Matrix3f(this._m21, this._m22, this._m23, this._m31, this._m32, this._m33, this._m41, this._m42, this._m43);

            float Result = this._m11 * det11.Determinant() - this._m12 * det12.Determinant() + this._m13 * det13.Determinant() - this._m14 * det14.Determinant(); 

            return Result;
        }

        public static Matrix4f operator +(Matrix4f lhs, Matrix4f rhs)
        {
            Matrix4f Result = new Matrix4f();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M12;
            Result.M13 = lhs.M13 + rhs.M13;
            Result.M14 = lhs.M14 + rhs.M14;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;
            Result.M23 = lhs.M23 + rhs.M23;
            Result.M24 = lhs.M24 + rhs.M24;
            Result.M31 = lhs.M31 + rhs.M31;
            Result.M32 = lhs.M32 + rhs.M32;
            Result.M33 = lhs.M33 + rhs.M33;
            Result.M34 = lhs.M34 + rhs.M34;
            Result.M41 = lhs.M41 + rhs.M41;
            Result.M42 = lhs.M42 + rhs.M42;
            Result.M43 = lhs.M43 + rhs.M43;
            Result.M44 = lhs.M44 + rhs.M44;

            return Result;
        }

        public static Matrix4f operator -(Matrix4f lhs, Matrix4f rhs)
        {
            Matrix4f Result = new Matrix4f();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M12;
            Result.M13 = lhs.M13 - rhs.M13;
            Result.M14 = lhs.M14 - rhs.M14;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;
            Result.M23 = lhs.M23 - rhs.M23;
            Result.M24 = lhs.M24 - rhs.M24;
            Result.M31 = lhs.M31 - rhs.M31;
            Result.M32 = lhs.M32 - rhs.M32;
            Result.M33 = lhs.M33 - rhs.M33;
            Result.M34 = lhs.M34 - rhs.M34;
            Result.M41 = lhs.M41 - rhs.M41;
            Result.M42 = lhs.M42 - rhs.M42;
            Result.M43 = lhs.M43 - rhs.M43;
            Result.M44 = lhs.M44 - rhs.M44;

            return Result;
        }

        public static Matrix4f operator *(float lhs, Matrix4f rhs)
        {
            Matrix4f Result = new Matrix4f();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M13 = lhs * rhs.M13;
            Result.M14 = lhs * rhs.M14;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;
            Result.M23 = lhs * rhs.M23;
            Result.M24 = lhs * rhs.M24;
            Result.M31 = lhs * rhs.M31;
            Result.M32 = lhs * rhs.M32;
            Result.M33 = lhs * rhs.M33;
            Result.M34 = lhs * rhs.M34;
            Result.M41 = lhs * rhs.M41;
            Result.M42 = lhs * rhs.M42;
            Result.M43 = lhs * rhs.M43;
            Result.M44 = lhs * rhs.M44;

            return Result;
        }

        public static Matrix4f operator *(Matrix4f lhs, float rhs)
        {
            Matrix4f Result = new Matrix4f();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M13 = lhs.M13 * rhs;
            Result.M14 = lhs.M14 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;
            Result.M23 = lhs.M23 * rhs;
            Result.M24 = lhs.M24 * rhs;
            Result.M31 = lhs.M31 * rhs;
            Result.M32 = lhs.M32 * rhs;
            Result.M33 = lhs.M33 * rhs;
            Result.M34 = lhs.M34 * rhs;
            Result.M41 = lhs.M41 * rhs;
            Result.M42 = lhs.M42 * rhs;
            Result.M43 = lhs.M43 * rhs;
            Result.M44 = lhs.M44 * rhs;

            return Result;
        }

        public static Matrix4f operator *(Matrix4f lhs, Matrix4f rhs)
        {
            Matrix4f Result = new Matrix4f();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21 + lhs.M13 * rhs.M31 + lhs.M14 * rhs.M41;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22 + lhs.M13 * rhs.M32 + lhs.M14 * rhs.M42;
            Result.M13 = lhs.M11 * rhs.M13 + lhs.M12 * rhs.M23 + lhs.M13 * rhs.M33 + lhs.M14 * rhs.M43;
            Result.M14 = lhs.M11 * rhs.M14 + lhs.M12 * rhs.M24 + lhs.M13 * rhs.M34 + lhs.M14 * rhs.M44;

            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21 + lhs.M23 * rhs.M31 + lhs.M24 * rhs.M41;
            Result.M22 = lhs.M21 * rhs.M12 + lhs.M22 * rhs.M22 + lhs.M23 * rhs.M32 + lhs.M24 * rhs.M42;
            Result.M23 = lhs.M21 * rhs.M13 + lhs.M22 * rhs.M23 + lhs.M23 * rhs.M33 + lhs.M24 * rhs.M43;
            Result.M24 = lhs.M21 * rhs.M14 + lhs.M22 * rhs.M24 + lhs.M23 * rhs.M34 + lhs.M24 * rhs.M44;
            
            Result.M31 = lhs.M31 * rhs.M11 + lhs.M32 * rhs.M21 + lhs.M33 * rhs.M31 + lhs.M34 * rhs.M41;
            Result.M32 = lhs.M31 * rhs.M12 + lhs.M32 * rhs.M22 + lhs.M33 * rhs.M32 + lhs.M34 * rhs.M42;
            Result.M33 = lhs.M31 * rhs.M13 + lhs.M32 * rhs.M23 + lhs.M33 * rhs.M33 + lhs.M34 * rhs.M43;
            Result.M34 = lhs.M31 * rhs.M14 + lhs.M32 * rhs.M24 + lhs.M33 * rhs.M34 + lhs.M34 * rhs.M44;

            Result.M41 = lhs.M41 * rhs.M11 + lhs.M42 * rhs.M21 + lhs.M43 * rhs.M31 + lhs.M44 * rhs.M41;
            Result.M42 = lhs.M41 * rhs.M12 + lhs.M42 * rhs.M22 + lhs.M43 * rhs.M32 + lhs.M44 * rhs.M42;
            Result.M43 = lhs.M41 * rhs.M13 + lhs.M42 * rhs.M23 + lhs.M43 * rhs.M33 + lhs.M44 * rhs.M43;
            Result.M44 = lhs.M41 * rhs.M14 + lhs.M42 * rhs.M24 + lhs.M43 * rhs.M34 + lhs.M44 * rhs.M44;

            return Result;
        }

        public static bool operator ==(Matrix4f lhs, Matrix4f rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M13 == rhs.M13 && lhs.M14 == rhs.M14 &&
                    lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22 && lhs.M23 == rhs.M23 && lhs.M24 == rhs.M24 &&
                    lhs.M31 == rhs.M31 && lhs.M32 == rhs.M32 && lhs.M33 == rhs.M33 && lhs.M34 == rhs.M34 &&
                    lhs.M41 == rhs.M41 && lhs.M42 == rhs.M42 && lhs.M43 == rhs.M43 && lhs.M44 == rhs.M44)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix4f lhs, Matrix4f rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix4f && obj is Matrix4f)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix4f Matrix = (Matrix4f)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M13 == Matrix.M13 && this.M14 == Matrix.M14 &&
                        this.M21 == Matrix.M21 && this.M22 == Matrix.M22 && this.M23 == Matrix.M23 && this.M24 == Matrix.M24 &&
                        this.M31 == Matrix.M31 && this.M32 == Matrix.M32 && this.M33 == Matrix.M33 && this.M34 == Matrix.M34 &&
                        this.M41 == Matrix.M41 && this.M42 == Matrix.M42 && this.M43 == Matrix.M43 && this.M44 == Matrix.M44)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            int PartM11 = BitConverter.ToInt32(BitConverter.GetBytes(this.M11), 0);
            int PartM12 = BitConverter.ToInt32(BitConverter.GetBytes(this.M12), 0);
            int PartM13 = BitConverter.ToInt32(BitConverter.GetBytes(this.M13), 0);
            int PartM14 = BitConverter.ToInt32(BitConverter.GetBytes(this.M14), 0);
            int PartM21 = BitConverter.ToInt32(BitConverter.GetBytes(this.M21), 0);
            int PartM22 = BitConverter.ToInt32(BitConverter.GetBytes(this.M22), 0);
            int PartM23 = BitConverter.ToInt32(BitConverter.GetBytes(this.M23), 0);
            int PartM24 = BitConverter.ToInt32(BitConverter.GetBytes(this.M24), 0);
            int PartM31 = BitConverter.ToInt32(BitConverter.GetBytes(this.M31), 0);
            int PartM32 = BitConverter.ToInt32(BitConverter.GetBytes(this.M32), 0);
            int PartM33 = BitConverter.ToInt32(BitConverter.GetBytes(this.M33), 0);
            int PartM34 = BitConverter.ToInt32(BitConverter.GetBytes(this.M34), 0);
            int PartM41 = BitConverter.ToInt32(BitConverter.GetBytes(this.M41), 0);
            int PartM42 = BitConverter.ToInt32(BitConverter.GetBytes(this.M42), 0);
            int PartM43 = BitConverter.ToInt32(BitConverter.GetBytes(this.M43), 0);
            int PartM44 = BitConverter.ToInt32(BitConverter.GetBytes(this.M44), 0);

            return PartM11 ^ PartM12 ^ PartM13 ^ PartM14 ^ 
                   PartM21 ^ PartM22 ^ PartM23 ^ PartM24 ^ 
                   PartM31 ^ PartM32 ^ PartM33 ^ PartM34 ^ 
                   PartM41 ^ PartM42 ^ PartM43 ^ PartM44;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // 4x4 Dimensional Matrix with "double" precision
    ///////////////////////////////////////////////////////////////////////////
    #region MATRIX4D...
    public class Matrix4d
    {
        private double _m11 = 0; private double _m12 = 0; private double _m13 = 0; private double _m14 = 0;
        private double _m21 = 0; private double _m22 = 0; private double _m23 = 0; private double _m24 = 0;
        private double _m31 = 0; private double _m32 = 0; private double _m33 = 0; private double _m34 = 0;
        private double _m41 = 0; private double _m42 = 0; private double _m43 = 0; private double _m44 = 0;

        public double M11 { get { return this._m11; } set { this._m11 = value; } }
        public double M12 { get { return this._m12; } set { this._m12 = value; } }
        public double M13 { get { return this._m13; } set { this._m13 = value; } }
        public double M14 { get { return this._m14; } set { this._m14 = value; } }
        public double M21 { get { return this._m21; } set { this._m21 = value; } }
        public double M22 { get { return this._m22; } set { this._m22 = value; } }
        public double M23 { get { return this._m23; } set { this._m23 = value; } }
        public double M24 { get { return this._m24; } set { this._m24 = value; } }
        public double M31 { get { return this._m31; } set { this._m31 = value; } }
        public double M32 { get { return this._m32; } set { this._m32 = value; } }
        public double M33 { get { return this._m33; } set { this._m33 = value; } }
        public double M34 { get { return this._m34; } set { this._m34 = value; } }
        public double M41 { get { return this._m41; } set { this._m41 = value; } }
        public double M42 { get { return this._m42; } set { this._m42 = value; } }
        public double M43 { get { return this._m43; } set { this._m43 = value; } }
        public double M44 { get { return this._m44; } set { this._m44 = value; } }

        public Matrix4d()
        {
            this._m11 = 0; this._m12 = 0; this._m13 = 0; this._m14 = 0;
            this._m21 = 0; this._m22 = 0; this._m23 = 0; this._m24 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 0; this._m34 = 0;
            this._m41 = 0; this._m42 = 0; this._m43 = 0; this._m44 = 0;
        }

        public Matrix4d(double M11, double M12, double M13, double M14, double M21, double M22, double M23, double M24, double M31, double M32, double M33, double M34, double M41, double M42, double M43, double M44)
        {
            this._m11 = M11; this._m12 = M12; this._m13 = M13; this._m14 = M14;
            this._m21 = M21; this._m22 = M22; this._m23 = M23; this._m24 = M24;
            this._m31 = M31; this._m32 = M32; this._m33 = M33; this._m34 = M34;
            this._m41 = M41; this._m42 = M42; this._m43 = M43; this._m44 = M44;
        }

        public Matrix4d(Matrix4f Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m14 = Matrix.M14;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m24 = Matrix.M24;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
            this._m34 = Matrix.M34;
            this._m41 = Matrix.M41;
            this._m42 = Matrix.M42;
            this._m43 = Matrix.M43;
            this._m44 = Matrix.M44;
        }

        public Matrix4d(Matrix4d Matrix)
        {
            this._m11 = Matrix.M11;
            this._m12 = Matrix.M12;
            this._m13 = Matrix.M13;
            this._m14 = Matrix.M14;
            this._m21 = Matrix.M21;
            this._m22 = Matrix.M22;
            this._m23 = Matrix.M23;
            this._m24 = Matrix.M24;
            this._m31 = Matrix.M31;
            this._m32 = Matrix.M32;
            this._m33 = Matrix.M33;
            this._m34 = Matrix.M34;
            this._m41 = Matrix.M41;
            this._m42 = Matrix.M42;
            this._m43 = Matrix.M43;
            this._m44 = Matrix.M44;
        }

        public void Identity()
        {
            this._m11 = 1; this._m12 = 0; this._m13 = 0; this._m14 = 0;
            this._m21 = 0; this._m22 = 1; this._m23 = 0; this._m24 = 0;
            this._m31 = 0; this._m32 = 0; this._m33 = 1; this._m34 = 0;
            this._m41 = 0; this._m42 = 0; this._m43 = 0; this._m44 = 1;
        }

        public void Transpose()
        {
            ToolsX.Swap(ref this._m21, ref this._m12);
            ToolsX.Swap(ref this._m31, ref this._m13);
            ToolsX.Swap(ref this._m41, ref this._m14);
            ToolsX.Swap(ref this._m42, ref this._m24);
            ToolsX.Swap(ref this._m43, ref this._m34);
        }

        public double Determinant()
        {
            Matrix3d det11 = new Matrix3d(this._m22, this._m23, this._m24, this._m32, this._m33, this._m34, this._m42, this._m43, this._m44);
            Matrix3d det12 = new Matrix3d(this._m21, this._m23, this._m24, this._m31, this._m33, this._m34, this._m41, this._m43, this._m44);
            Matrix3d det13 = new Matrix3d(this._m21, this._m22, this._m24, this._m31, this._m32, this._m34, this._m41, this._m42, this._m44);
            Matrix3d det14 = new Matrix3d(this._m21, this._m22, this._m23, this._m31, this._m32, this._m33, this._m41, this._m42, this._m43);

            double Result = this._m11 * det11.Determinant() - this._m12 * det12.Determinant() + this._m13 * det13.Determinant() - this._m14 * det14.Determinant();

            return Result;
        }

        public static Matrix4d operator +(Matrix4d lhs, Matrix4d rhs)
        {
            Matrix4d Result = new Matrix4d();

            Result.M11 = lhs.M11 + rhs.M11;
            Result.M12 = lhs.M12 + rhs.M12;
            Result.M13 = lhs.M13 + rhs.M13;
            Result.M14 = lhs.M14 + rhs.M14;
            Result.M21 = lhs.M21 + rhs.M21;
            Result.M22 = lhs.M22 + rhs.M22;
            Result.M23 = lhs.M23 + rhs.M23;
            Result.M24 = lhs.M24 + rhs.M24;
            Result.M31 = lhs.M31 + rhs.M31;
            Result.M32 = lhs.M32 + rhs.M32;
            Result.M33 = lhs.M33 + rhs.M33;
            Result.M34 = lhs.M34 + rhs.M34;
            Result.M41 = lhs.M41 + rhs.M41;
            Result.M42 = lhs.M42 + rhs.M42;
            Result.M43 = lhs.M43 + rhs.M43;
            Result.M44 = lhs.M44 + rhs.M44;

            return Result;
        }

        public static Matrix4d operator -(Matrix4d lhs, Matrix4d rhs)
        {
            Matrix4d Result = new Matrix4d();

            Result.M11 = lhs.M11 - rhs.M11;
            Result.M12 = lhs.M12 - rhs.M12;
            Result.M13 = lhs.M13 - rhs.M13;
            Result.M14 = lhs.M14 - rhs.M14;
            Result.M21 = lhs.M21 - rhs.M21;
            Result.M22 = lhs.M22 - rhs.M22;
            Result.M23 = lhs.M23 - rhs.M23;
            Result.M24 = lhs.M24 - rhs.M24;
            Result.M31 = lhs.M31 - rhs.M31;
            Result.M32 = lhs.M32 - rhs.M32;
            Result.M33 = lhs.M33 - rhs.M33;
            Result.M34 = lhs.M34 - rhs.M34;
            Result.M41 = lhs.M41 - rhs.M41;
            Result.M42 = lhs.M42 - rhs.M42;
            Result.M43 = lhs.M43 - rhs.M43;
            Result.M44 = lhs.M44 - rhs.M44;

            return Result;
        }

        public static Matrix4d operator *(double lhs, Matrix4d rhs)
        {
            Matrix4d Result = new Matrix4d();

            Result.M11 = lhs * rhs.M11;
            Result.M12 = lhs * rhs.M12;
            Result.M13 = lhs * rhs.M13;
            Result.M14 = lhs * rhs.M14;
            Result.M21 = lhs * rhs.M21;
            Result.M22 = lhs * rhs.M22;
            Result.M23 = lhs * rhs.M23;
            Result.M24 = lhs * rhs.M24;
            Result.M31 = lhs * rhs.M31;
            Result.M32 = lhs * rhs.M32;
            Result.M33 = lhs * rhs.M33;
            Result.M34 = lhs * rhs.M34;
            Result.M41 = lhs * rhs.M41;
            Result.M42 = lhs * rhs.M42;
            Result.M43 = lhs * rhs.M43;
            Result.M44 = lhs * rhs.M44;

            return Result;
        }

        public static Matrix4d operator *(Matrix4d lhs, double rhs)
        {
            Matrix4d Result = new Matrix4d();

            Result.M11 = lhs.M11 * rhs;
            Result.M12 = lhs.M12 * rhs;
            Result.M13 = lhs.M13 * rhs;
            Result.M14 = lhs.M14 * rhs;
            Result.M21 = lhs.M21 * rhs;
            Result.M22 = lhs.M22 * rhs;
            Result.M23 = lhs.M23 * rhs;
            Result.M24 = lhs.M24 * rhs;
            Result.M31 = lhs.M31 * rhs;
            Result.M32 = lhs.M32 * rhs;
            Result.M33 = lhs.M33 * rhs;
            Result.M34 = lhs.M34 * rhs;
            Result.M41 = lhs.M41 * rhs;
            Result.M42 = lhs.M42 * rhs;
            Result.M43 = lhs.M43 * rhs;
            Result.M44 = lhs.M44 * rhs;

            return Result;
        }

        public static Matrix4d operator *(Matrix4d lhs, Matrix4d rhs)
        {
            Matrix4d Result = new Matrix4d();

            Result.M11 = lhs.M11 * rhs.M11 + lhs.M12 * rhs.M21 + lhs.M13 * rhs.M31 + lhs.M14 * rhs.M41;
            Result.M12 = lhs.M11 * rhs.M12 + lhs.M12 * rhs.M22 + lhs.M13 * rhs.M32 + lhs.M14 * rhs.M42;
            Result.M13 = lhs.M11 * rhs.M13 + lhs.M12 * rhs.M23 + lhs.M13 * rhs.M33 + lhs.M14 * rhs.M43;
            Result.M14 = lhs.M11 * rhs.M14 + lhs.M12 * rhs.M24 + lhs.M13 * rhs.M34 + lhs.M14 * rhs.M44;

            Result.M21 = lhs.M21 * rhs.M11 + lhs.M22 * rhs.M21 + lhs.M23 * rhs.M31 + lhs.M24 * rhs.M41;
            Result.M22 = lhs.M21 * rhs.M12 + lhs.M22 * rhs.M22 + lhs.M23 * rhs.M32 + lhs.M24 * rhs.M42;
            Result.M23 = lhs.M21 * rhs.M13 + lhs.M22 * rhs.M23 + lhs.M23 * rhs.M33 + lhs.M24 * rhs.M43;
            Result.M24 = lhs.M21 * rhs.M14 + lhs.M22 * rhs.M24 + lhs.M23 * rhs.M34 + lhs.M24 * rhs.M44;

            Result.M31 = lhs.M31 * rhs.M11 + lhs.M32 * rhs.M21 + lhs.M33 * rhs.M31 + lhs.M34 * rhs.M41;
            Result.M32 = lhs.M31 * rhs.M12 + lhs.M32 * rhs.M22 + lhs.M33 * rhs.M32 + lhs.M34 * rhs.M42;
            Result.M33 = lhs.M31 * rhs.M13 + lhs.M32 * rhs.M23 + lhs.M33 * rhs.M33 + lhs.M34 * rhs.M43;
            Result.M34 = lhs.M31 * rhs.M14 + lhs.M32 * rhs.M24 + lhs.M33 * rhs.M34 + lhs.M34 * rhs.M44;

            Result.M41 = lhs.M41 * rhs.M11 + lhs.M42 * rhs.M21 + lhs.M43 * rhs.M31 + lhs.M44 * rhs.M41;
            Result.M42 = lhs.M41 * rhs.M12 + lhs.M42 * rhs.M22 + lhs.M43 * rhs.M32 + lhs.M44 * rhs.M42;
            Result.M43 = lhs.M41 * rhs.M13 + lhs.M42 * rhs.M23 + lhs.M43 * rhs.M33 + lhs.M44 * rhs.M43;
            Result.M44 = lhs.M41 * rhs.M14 + lhs.M42 * rhs.M24 + lhs.M43 * rhs.M34 + lhs.M44 * rhs.M44;

            return Result;
        }

        public static bool operator ==(Matrix4d lhs, Matrix4d rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.M11 == rhs.M11 && lhs.M12 == rhs.M12 && lhs.M13 == rhs.M13 && lhs.M14 == rhs.M14 &&
                    lhs.M21 == rhs.M21 && lhs.M22 == rhs.M22 && lhs.M23 == rhs.M23 && lhs.M24 == rhs.M24 &&
                    lhs.M31 == rhs.M31 && lhs.M32 == rhs.M32 && lhs.M33 == rhs.M33 && lhs.M34 == rhs.M34 &&
                    lhs.M41 == rhs.M41 && lhs.M42 == rhs.M42 && lhs.M43 == rhs.M43 && lhs.M44 == rhs.M44)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(Matrix4d lhs, Matrix4d rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // In order to have "equality", we must have same type of objects
            if (this.GetType() == obj.GetType() && this is Matrix4d && obj is Matrix4d)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    Matrix4d Matrix = (Matrix4d)obj;

                    if (this.M11 == Matrix.M11 && this.M12 == Matrix.M12 && this.M13 == Matrix.M13 && this.M14 == Matrix.M14 &&
                        this.M21 == Matrix.M21 && this.M22 == Matrix.M22 && this.M23 == Matrix.M23 && this.M24 == Matrix.M24 &&
                        this.M31 == Matrix.M31 && this.M32 == Matrix.M32 && this.M33 == Matrix.M33 && this.M34 == Matrix.M34 &&
                        this.M41 == Matrix.M41 && this.M42 == Matrix.M42 && this.M43 == Matrix.M43 && this.M44 == Matrix.M44)
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            long PartM11 = BitConverter.DoubleToInt64Bits(this.M11);
            long PartM12 = BitConverter.DoubleToInt64Bits(this.M12);
            long PartM13 = BitConverter.DoubleToInt64Bits(this.M13);
            long PartM14 = BitConverter.DoubleToInt64Bits(this.M14);
            long PartM21 = BitConverter.DoubleToInt64Bits(this.M21);
            long PartM22 = BitConverter.DoubleToInt64Bits(this.M22);
            long PartM23 = BitConverter.DoubleToInt64Bits(this.M23);
            long PartM24 = BitConverter.DoubleToInt64Bits(this.M24);
            long PartM31 = BitConverter.DoubleToInt64Bits(this.M31);
            long PartM32 = BitConverter.DoubleToInt64Bits(this.M32);
            long PartM33 = BitConverter.DoubleToInt64Bits(this.M33);
            long PartM34 = BitConverter.DoubleToInt64Bits(this.M34);
            long PartM41 = BitConverter.DoubleToInt64Bits(this.M41);
            long PartM42 = BitConverter.DoubleToInt64Bits(this.M42);
            long PartM43 = BitConverter.DoubleToInt64Bits(this.M43);
            long PartM44 = BitConverter.DoubleToInt64Bits(this.M44);

            int PartM11a = (int)(PartM11 >> 32);
            int PartM11b = (int)(PartM11 & 0xFFFFFFFF);
            int PartM12a = (int)(PartM12 >> 32);
            int PartM12b = (int)(PartM12 & 0xFFFFFFFF);
            int PartM13a = (int)(PartM13 >> 32);
            int PartM13b = (int)(PartM13 & 0xFFFFFFFF);
            int PartM14a = (int)(PartM14 >> 32);
            int PartM14b = (int)(PartM14 & 0xFFFFFFFF);
            int PartM21a = (int)(PartM21 >> 32);
            int PartM21b = (int)(PartM21 & 0xFFFFFFFF);
            int PartM22a = (int)(PartM22 >> 32);
            int PartM22b = (int)(PartM22 & 0xFFFFFFFF);
            int PartM23a = (int)(PartM23 >> 32);
            int PartM23b = (int)(PartM23 & 0xFFFFFFFF);
            int PartM24a = (int)(PartM24 >> 32);
            int PartM24b = (int)(PartM24 & 0xFFFFFFFF);
            int PartM31a = (int)(PartM31 >> 32);
            int PartM31b = (int)(PartM31 & 0xFFFFFFFF);
            int PartM32a = (int)(PartM32 >> 32);
            int PartM32b = (int)(PartM32 & 0xFFFFFFFF);
            int PartM33a = (int)(PartM33 >> 32);
            int PartM33b = (int)(PartM33 & 0xFFFFFFFF);
            int PartM34a = (int)(PartM34 >> 32);
            int PartM34b = (int)(PartM34 & 0xFFFFFFFF);
            int PartM41a = (int)(PartM41 >> 32);
            int PartM41b = (int)(PartM41 & 0xFFFFFFFF);
            int PartM42a = (int)(PartM42 >> 32);
            int PartM42b = (int)(PartM42 & 0xFFFFFFFF);
            int PartM43a = (int)(PartM43 >> 32);
            int PartM43b = (int)(PartM43 & 0xFFFFFFFF);
            int PartM44a = (int)(PartM44 >> 32);
            int PartM44b = (int)(PartM44 & 0xFFFFFFFF);

            return PartM11a ^ PartM11b ^ PartM12a ^ PartM12b ^ PartM13a ^ PartM13b ^ PartM14a ^ PartM14b ^
                   PartM21a ^ PartM21b ^ PartM22a ^ PartM22b ^ PartM23a ^ PartM23b ^ PartM24a ^ PartM24b ^
                   PartM31a ^ PartM31b ^ PartM32a ^ PartM32b ^ PartM33a ^ PartM33b ^ PartM34a ^ PartM34b ^
                   PartM41a ^ PartM41b ^ PartM42a ^ PartM42b ^ PartM43a ^ PartM43b ^ PartM44a ^ PartM44b;
        }
    }
    #endregion
}