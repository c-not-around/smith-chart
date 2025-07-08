using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace SmithChart
{
    public class RPoint
    {
        #region Ctors
        public RPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public RPoint(double angle)
        {
            X = Math.Cos(angle);
            Y = Math.Sin(angle);
        }
        #endregion

        #region Properties
        public double X { get; set; }

        public double Y { get; set; }

        public double Length => Math.Sqrt(X*X + Y*Y);

        public double Angle => Math.Atan2(Y, X);
        #endregion

        #region Operators
        public static RPoint operator+(RPoint a, RPoint b) => new RPoint(a.X + b.X, a.Y + b.Y);

        public static RPoint operator-(RPoint a, RPoint b) => new RPoint(a.X - b.X, a.Y - b.Y);

        public static RPoint operator*(double k, RPoint p) => new RPoint(k * p.X, k * p.Y);

        public static RPoint operator*(RPoint p, double k) => k * p;

        public static RPoint operator/(RPoint p, double k) => (1.0 / k) * p;

        public static RPoint operator/(double k, RPoint p) => p / k;
        #endregion
    }

    public class SmithChart : Control
    {
        #region Fields
        private Bitmap   _Bitmap;
        private Graphics _Graphics;

        private int      _Border;
        private int      _Length;
        private double   _PxPerObject;
        private int      _Center;
        
        private RPoint   _Offset;
        private double   _Scale;
        private int      _Scroll;
        private RPoint   _CapturePoint;
        private double   _CaptureRho;

        private double   _R;
        private double   _X;
        private double   _G;
        private double   _B;
        private double   _RhoReal;
        private double   _RhoImag;
        private double   _RhoAbs;
        private double   _RhoArg;
        private double   _Ktw;
        private double   _Ksw;
        private double   _DxLambda;

        private bool     _FixedHorizontal;
        private bool     _FixedVertical;
        private bool     _FixedRadial;

        private Color    _BackColor;
        private Pen      _ZColor;
        private Pen      _KColor;
        private Pen      _RColor;
        private Pen      _XColor;
        private Pen      _RhoColor;
        private Pen      _DxLambdaColor;

        private bool     _InfoEnable;
        #endregion

        #region Constructors
        public SmithChart()
        {
            _Border = 20;
            _Length = 100;

            _Offset       = new RPoint(0.0, 0.0);
            _CapturePoint = new RPoint(0.0, 0.0);

            _Scale  = 1.25;
            _Scroll = 0;

            _FixedHorizontal = false;
            _FixedVertical   = false;
            _FixedRadial     = false;

            _R = 1.0;
            _X = 1.0;
            _G = 0.5;
            _B = -0.5;
            CalculateRho();

            _BackColor     = Color.Black;
            _ZColor        = new Pen(Color.White);
            _KColor        = new Pen(Color.Orange);
            _RColor        = new Pen(Color.Red);
            _XColor        = new Pen(Color.Green);
            _RhoColor      = new Pen(Color.Blue);
            _DxLambdaColor = new Pen(Color.Purple);

            _InfoEnable = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
        #endregion

        #region Properties
        public double R
        {
            get => _R;
            set
            {
                if (0.0 <= value)
                {
                    _R = value;
                    _G =  _R / (_R * _R + _X * _X);
                    _B = -_X / (_R * _R + _X * _X);

                    CalculateRho();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина R должна быть в интервале [ 0 ; +∞ ).");
                }
            }
        }

        public double X
        {
            get => _X;
            set
            {
                _X = value;
                _G =  _R / (_R * _R + _X * _X);
                _B = -_X / (_R * _R + _X * _X);

                CalculateRho();
                Redraw();
                RhoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public double Z => Math.Sqrt(_X * _X + _R * _R);

        public double G
        {
            get => _G;
            set
            {
                if (0.0 <= value)
                {
                    _G = value;
                    _R =  _G / (_G * _G + _B * _B);
                    _X = -_B / (_G * _G + _B * _B);

                    CalculateRho();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина G должна быть в интервале [ 0 ; +∞ ).");
                }
            }
        }

        public double B
        {
            get => _B;
            set
            {
                _B = value;
                _R =  _G / (_G * _G + _B * _B);
                _X = -_B / (_G * _G + _B * _B);

                CalculateRho();
                Redraw();
                RhoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public double Y => Math.Sqrt(_G * _G + _B * _B);

        public double ReRho => _RhoReal;

        public double ImRho => _RhoImag;

        public double Rho
        {
            get => _RhoAbs;
            set
            {
                if (0.0 <= value && value <= 1.0)
                {
                    _RhoAbs  = value;

                    _RhoReal = _RhoAbs * Math.Cos(_RhoArg);
                    _RhoImag = _RhoAbs * Math.Sin(_RhoArg);

                    _Ktw = (1.0 - _RhoAbs) / (1.0 + _RhoAbs);
                    _Ksw = (1.0 + _RhoAbs) / (1.0 - _RhoAbs);

                    CalculateRX();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина ρ должна быть в интервале [ 0 ; 1 ].");
                }
            }
        }

        public double ArgRho
        {
            get => _RhoArg;
            set
            {
                if (0.0 <= value && value <= 2.0 * Math.PI)
                {
                    _RhoArg   = value;

                    _RhoReal  = _RhoAbs * Math.Cos(_RhoArg);
                    _RhoImag  = _RhoAbs * Math.Sin(_RhoArg);
                    _DxLambda = 0.25 * (1.0 - _RhoArg / Math.PI);

                    CalculateRX();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина ϕ должна быть в интервале [ 0 ; 2π ).");
                }
            }
        }

        public double Ktw
        {
            get => _Ktw;
            set
            {
                if (0.0 <= value && value <= 1.0)
                {
                    _Ktw     = value;

                    _Ksw     = 1.0 / _Ktw;
                    _RhoAbs  = (1.0 - _Ktw) / (1.0 + _Ktw);
                    _RhoReal = _RhoAbs * Math.Cos(_RhoArg);
                    _RhoImag = _RhoAbs * Math.Sin(_RhoArg);

                    CalculateRX();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина KБВ должна быть в интервале [ 0 ; 1 ].");
                }
            }
        }

        public double Ksw
        {
            get => _Ksw;
            set
            {
                if (1.0 <= value)
                {
                    _Ksw     = value;

                    _Ktw     = 1.0 / _Ksw;
                    _RhoAbs  = (_Ksw - 1.0) / (_Ksw + 1.0);
                    _RhoReal = _RhoAbs * Math.Cos(_RhoArg);
                    _RhoImag = _RhoAbs * Math.Sin(_RhoArg);

                    CalculateRX();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина KСВН должна быть в интервале [ 1 ; +∞ ).");
                }
            }
        }

        public double Dxl
        {
            get => _DxLambda;
            set
            {
                if (0.0 <= value && value <= 0.5)
                {
                    _DxLambda = value;

                    _RhoArg   = Math.PI * (1.0 - 4.0 * _DxLambda);
                    _RhoReal  = _RhoAbs * Math.Cos(_RhoArg);
                    _RhoImag  = _RhoAbs * Math.Sin(_RhoArg);

                    CalculateRX();
                    Redraw();
                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ShowError("Величина Δx/λ должна быть в интервале [ 0 ; 0.5 ].");
                }
            }
        }

        public RPoint Offset
        {
            get => _Offset;
            set
            {
                _Offset = value;
                Redraw();
            }
        }

        public new double Scale => Math.Pow(_Scale, _Scroll);

        public double ScaleStep
        {
            get => _Scale;
            set
            {
                double factor = Math.Pow(_Scale, -_Scroll);

                _PxPerObject *= factor;
                _Offset      *= factor;

                _Scale  = value;
                _Scroll = 0;

                Redraw();
            }
        }

        public new Color BackColor
        {
            get => _BackColor;
            set
            {
                _BackColor = value;
                Redraw();
            }
        }

        public new Color ForeColor
        {
            get => _ZColor.Color;
            set
            {
                _ZColor.Color = value;
                Redraw();
            }
        }

        public Color RColor
        {
            get => _RColor.Color;
            set
            {
                _RColor.Color = value;
                Redraw();
            }
        }

        public Color XColor
        {
            get => _XColor.Color;
            set
            {
                _XColor.Color = value;
                Redraw();
            }
        }

        public Color RhoColor
        {
            get => _RhoColor.Color;
            set
            {
                _RhoColor.Color = value;
                Redraw();
            }
        }

        public Color KColor
        {
            get => _KColor.Color;
            set
            {
                _KColor.Color = value;
                Redraw();
            }
        }

        public Color DxlColor
        {
            get => _DxLambdaColor.Color;
            set
            {
                _DxLambdaColor.Color = value;
                Redraw();
            }
        }

        public float LinesWidth
        {
            get => _ZColor.Width;
            set
            {
                if (0.0f < value && value < 10.0f)
                {
                    _ZColor.Width        = value;
                    _RColor.Width        = value;
                    _XColor.Width        = value;
                    _KColor.Width        = value;
                    _RhoColor.Width      = value;
                    _DxLambdaColor.Width = value;

                    Redraw();
                }
            }
        }

        public bool InfoEnable
        {
            get => _InfoEnable;
            set
            {
                if (value ^ _InfoEnable)
                {
                    _InfoEnable = value;
                    Redraw();
                }
            }
        }
        #endregion

        #region Methods
        public void Save(string filename, ImageFormat format)
        {
            using (Bitmap saved = new Bitmap(Width, Height))
            {
                DrawToBitmap(saved, new Rectangle(0, 0, Width, Height));
                saved.Save(filename, format);
            }
        }
        #endregion

        #region Events
        public event EventHandler RhoChanged;
        #endregion

        #region Utils
        public static void ShowError(string text) => MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private static int Round(double x) => (int)System.Convert.ToInt64(Math.Round(x));

        private Point Convert(double x, double y) => new Point(_Center + Round((x - _Offset.X) * _PxPerObject),
                                                               _Center - Round((y - _Offset.Y) * _PxPerObject));

        private RPoint Convert(int x, int y) => new RPoint((x - _Border - _Center) / _PxPerObject + _Offset.X,
                                                           (_Border + _Center - y) / _PxPerObject + _Offset.Y);

        private Point Convert(RPoint p) => Convert(p.X, p.Y);

        private RPoint Convert(Point p) => Convert(p.X, p.Y);
        #endregion

        #region Routines
        private Point[] MakeCurve(Func<double, double> X, Func<double, double> Y, double t0 = 0.0, double t1 = 2.0 * Math.PI)
        {
            double  dt = 5e-3;
            Point[] pt = new Point[Round((t1 - t0) / dt)];

            for (int i = 0; i < pt.Length; i++)
            {
                double t = t0 + i * dt;
                pt[i] = Convert(X(t), Y(t));
            }

            return pt;
        }

        private void RedrawK()
        {
            Point[] pt = MakeCurve(t => _RhoAbs * Math.Cos(t),
                                   t => _RhoAbs * Math.Sin(t));
            _Graphics.DrawLines(_KColor, pt);
        }

        private void RedrawR()
        {
            Point[] pt = MakeCurve(t => _R / (1.0 + _R) + 1.0 / (1.0 + _R) * Math.Cos(t),
                                   t => 1.0 / (1.0 + _R) * Math.Sin(t));
            _Graphics.DrawLines(_RColor, pt);
        }

        private void RedrawX()
        {
            Point[] pt = MakeCurve(t => 1.0 + 1.0 / Math.Abs(_X) * Math.Cos(t),
                                   t => 1.0 / _X + 1.0 / _X * Math.Sin(t),
                                   Math.PI / 2.0 + 2.0 * Math.Atan(1.0 / Math.Abs(_X)),
                                   3.0 * Math.PI / 2.0);
            try
            {
                _Graphics.DrawLines(_XColor, pt);
            }
            catch
            {

            }
        }

        private void RedrawRho()
        {
            try
            {
                Point p = Convert(_RhoReal, _RhoImag);

                _Graphics.DrawLine(_RhoColor, Convert(0.0, 0.0), p);
                _Graphics.DrawLine(_DxLambdaColor, p, Convert(new RPoint(_RhoArg)));
            }
            catch
            {

            }
        }

        private void RedrawBorder()
        {
            Point[] pt = MakeCurve(t => Math.Cos(t), t => Math.Sin(t));
            _Graphics.DrawClosedCurve(_ZColor, pt);
        }

        private void Redraw()
        {
            if (_Bitmap != null)
            {
                _Graphics.Clear(_BackColor);
                _Graphics.DrawLine(_ZColor, Convert(-1.0, 0.0), Convert(1.0, 0.0));

                RedrawK();
                RedrawR();
                RedrawX();
                RedrawRho();
                RedrawBorder();

                if (_InfoEnable)
                {
                    string zoom = "x" + Math.Pow(_Scale, _Scroll).Format(2);
                    string xpos = "x: " + _Offset.X.Format(4);
                    string ypos = "y: " + _Offset.Y.Format(4);

                    var font = new Font("consolas", 10, FontStyle.Regular, GraphicsUnit.Point);

                    _Graphics.DrawString("Offset: ", font, Brushes.White, 0, 0);
                    _Graphics.DrawString(xpos, font, Brushes.White, 5, 15);
                    _Graphics.DrawString(ypos, font, Brushes.White, 5, 30);

                    _Graphics.DrawString("Scale: ", font, Brushes.White, 0, _Length - 35);
                    _Graphics.DrawString(zoom, font, Brushes.White, 5, _Length - 20);
                }

                Invalidate();
            }
        }

        private void CalculateRX()
        {
            double k = _RhoReal * _RhoReal + _RhoImag * _RhoImag;

            _R = (1.0 - k)      / (1.0 + k - 2.0 * _RhoReal);
            _X = 2.0 * _RhoImag / (1.0 + k - 2.0 * _RhoReal);

            _G =  _R / (_R * _R + _X * _X);
            _B = -_X / (_R * _R + _X * _X);
        }

        private void CalculateRho()
        {
            double a  = Math.Pow(_R + 1.0, 2) + _X * _X;

            _RhoReal  = (_R * _R + _X * _X - 1.0) / a;
            _RhoImag  = 2.0 * _X / a;
            _RhoAbs   = Math.Sqrt(_RhoReal * _RhoReal + _RhoImag * _RhoImag);
            _RhoArg   = Math.Atan2(_RhoImag, _RhoReal);

            _Ktw      = (1.0 - _RhoAbs) / (1.0 + _RhoAbs);
            _Ksw      = (1.0 + _RhoAbs) / (1.0 - _RhoAbs);

            _DxLambda = 0.25 * (1.0 - _RhoArg / Math.PI);
        }

        private void Resume()
        {
            _Bitmap = new Bitmap(_Length + 1, _Length + 1);
            _Graphics = Graphics.FromImage(_Bitmap);
            _Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Redraw();
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(_BackColor);
            e.Graphics.DrawImage(_Bitmap, _Border, _Border);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            int len = Math.Min(Size.Width, Size.Height);

            if (len > 2*_Border)
            {
                Width  = len;
                Height = len;

                _Length      = len - 2 * _Border;
                _PxPerObject = _Length / 2.0 * Math.Pow(_Scale, _Scroll);
                _Center      = _Length / 2;

                Resume();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Right)
            {
                if (_Border < e.X && e.X < _Border + _Length &&
                    _Border < e.Y && e.Y < _Border + _Length)
                {
                    _CapturePoint = Convert(e.Location);
                    Cursor        = Cursors.SizeAll;
                }
            }

            Focus();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Right)
            {
                RPoint p = Convert(e.Location);

                if (_FixedHorizontal)
                {
                    p.X = _CapturePoint.X;
                }

                if (_FixedVertical)
                {
                    p.Y = _CapturePoint.Y;
                }

                _Offset += _CapturePoint - p;

                Redraw();
            }
            else if (e.Button == MouseButtons.Left)
            {
                RPoint p = Convert(e.Location);

                if (_FixedHorizontal)
                {
                    p.X = _RhoReal;
                }

                if (_FixedVertical)
                {
                    p.Y = _RhoImag;
                }

                if (_FixedRadial)
                {
                    p.X = Math.Abs(p.X) <= _RhoAbs ? p.X : Math.Sign(p.X) * _RhoAbs;
                    p.Y = (p.Y < 0.0 ? -1.0 : 1.0) * Math.Sqrt(_CaptureRho * _CaptureRho - p.X * p.X);
                }

                double k = p.X * p.X + p.Y * p.Y;

                if (k < 1.0)
                {
                    Cursor = Cursors.Cross;

                    _R = (1.0 - k) / (1.0 + k - 2.0 * p.X);
                    _X = 2.0 * p.Y / (1.0 + k - 2.0 * p.X);

                    _G =  _R / (_R * _R + _X * _X);
                    _B = -_X / (_R * _R + _X * _X);

                    _RhoReal  = p.X;
                    _RhoImag  = p.Y;
                    _RhoAbs   = p.Length;
                    _RhoArg   = p.Angle;

                    _Ktw      = (1.0 - _RhoAbs) / (1.0 + _RhoAbs);
                    _Ksw      = (1.0 + _RhoAbs) / (1.0 - _RhoAbs);

                    _DxLambda = 0.25 * (1.0 - _RhoArg / Math.PI);

                    Redraw();

                    RhoChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    Cursor = Cursors.Arrow;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (e.Delta > 0)
            {
                if (_Scroll < 20)
                {
                    _PxPerObject *= _Scale;
                    _Offset      *= _Scale;
                    _Scroll++;

                    Redraw();
                }
            }
            else
            {
                if (_Scroll > -8)
                {
                    _PxPerObject /= _Scale;
                    _Offset      /= _Scale;
                    _Scroll--;

                    Redraw();
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            _FixedHorizontal = e.Control;
            _FixedVertical   = e.Shift;
            _FixedRadial     = e.Alt;

            _CaptureRho      = _RhoAbs;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            _FixedHorizontal = e.Control;
            _FixedVertical   = e.Shift;
            _FixedRadial     = e.Alt;
        }
        #endregion
    }
}